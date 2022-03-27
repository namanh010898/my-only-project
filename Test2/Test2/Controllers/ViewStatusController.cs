
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Daihoc_FPT_News.Models;
using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util;
//using Daihoc_FPT_News.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Daihoc_FPT_News.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ViewStatusController : BaseController
    {
        IViewStatusRepository repository; 
        public ViewStatusController(ICacheHelper cacheHelper, IViewStatusRepository _repository) : base(cacheHelper)
        { 
            repository = _repository; 
        }


        [HttpGet]
        [Route("admin/List")]
        public async Task<IActionResult> AdminList()
        { 
            try
            {
                var listViewStatus = await repository.List();

                // return 404 nếu list null
                if (listViewStatus == null || listViewStatus.Count == 0)
                {
                    return NotFound(); 
                }

                ViewBag.listViewStatus = listViewStatus;
                ViewBag.ViewStatusCount = listViewStatus.Count;
                return View();
                
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("add/viewStatus")]
        public async Task<IActionResult> AddViewStatus()
        {
            //var listPost = await repositoryPost.List();
            //ViewBag.Posts = listPost;
            //ViewBag.PostCount = listPost.Count;
            return View();
        }


        [HttpGet]
        [Route("api/List")]
        public async Task<IActionResult> List()
        {
            try
            {
                var dataList = await repository.List();

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }

                var novaticResponse = NovaticResponse.SUCCESS(dataList.Cast<object>().ToList());
                //var response = Newtonsoft.Json.JsonConvert.SerializeObject(novaticResponse);
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/Detail/{Id}")]
        public async Task<IActionResult> Detail(int? Id)
        { 
            if (Id == null)
            {
                return BadRequest();
            }

            try
            {
                var dataList = await repository.Detail(Id);

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }
                // đẩy dữ liệu về json
                var response = JsonSerializer.Serialize(dataList.Cast<object>().ToList());
                //var novaticResponse = NovaticResponse.SUCCESS(dataList.Cast<object>().ToList());
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/Search")]
        public async Task<IActionResult> Search(string keyword)
        {
            try
            {
                var dataList = await repository.Search(keyword);

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }

                var novaticResponse = NovaticResponse.SUCCESS(dataList.Cast<object>().ToList());
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/ListPaging")]
        public async Task<IActionResult> ListPaging(int pageIndex, int pageSize)
        {
            if (pageIndex < 0 || pageSize < 0) return BadRequest();
            try
            {
                var dataList = await repository.ListPaging(pageIndex, pageSize);

                if (dataList == null || dataList.Count == 0)
                {
                    return NotFound();
                }

                var novaticResponse = NovaticResponse.SUCCESS(dataList.Cast<object>().ToList());
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("api/Add")]
        public async Task<IActionResult> Add([FromBody]ViewStatus model)
        {
            if (ModelState.IsValid)
            {
                //1. business logic

                //data validation
                if (model.Name.Length == 0)
                {
                    return BadRequest();
                }

                //auto correct
                model.Active = 1;

                //2. add new object
                try
                {
                    var newObj = await repository.Add(model);
                    if (newObj.Id > 0)
                    {
                        var novaticResponse = NovaticResponse.CREATED(model);
                        return Created("", novaticResponse);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("api/edit")]
        public async Task<IActionResult> Update([FromBody]ViewStatus model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Active = 1;
                    //2. update object
                    await repository.Update(model);

                    var novaticResponse = NovaticResponse.SUCCESS(model);
                    return Ok(novaticResponse);
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("api/Delete")]
        public async Task<IActionResult> Delete([FromBody]ViewStatus model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //1. business logic
                    //set Active to 0
                    model.Active = 0;

                    //2. logically delete object
                    await repository.Delete(model);

                    var response = NovaticResponse.SUCCESS(model);
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("api/DeletePermanently")]
        public async Task<IActionResult> DeletePermanently([FromBody]Menu model)
        {
            int result = 0;

            if (!(model.Id > 0))
            {
                return BadRequest();
            }

            try
            {
                //physically delete object
                result = await repository.DeletePermanently(model.Id);
                if (result == 0)
                {
                    return NotFound();
                }
                var novaticResponse = NovaticResponse.SUCCESS(model);
                return Ok(novaticResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
