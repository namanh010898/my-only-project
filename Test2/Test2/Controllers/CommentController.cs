﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Daihoc_FPT_News.Models;
using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util;
//using GappingWorld.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Daihoc_FPT_News.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentController : BaseController
    {
        ICommentRepository repository;  
        public CommentController(ICacheHelper cacheHelper, ICommentRepository _repository) : base(cacheHelper)
        {
            repository = _repository; 
        }


        [HttpGet]
        [Route("admin/List")]
        public async Task<IActionResult> AdminList()
        {   
            try
            {
                var dataList = await repository.List();

                if (dataList == null || dataList.Count == 0)
                { 
                } 

                ViewBag.listComment = dataList;
                ViewBag.CommentCount = dataList.Count;
                return View(); 
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        [HttpGet]
        [Route("add/comment")]
        public async Task<IActionResult> AddComment()
        { 
            return View();
        }

        [HttpGet]
        [Route("api/List")]
        public async Task<IActionResult> List()
        {
            try
            {
                var dataList = await repository.ListCommentAdmin();
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
        [HttpGet]
        [Route("api/ListPaging/{PostID}/{pageIndex}/{pageSize}")]
        public async Task<IActionResult> ListCommentPaging(int PostID, int pageIndex, int pageSize)
        {
            if (pageIndex < 0 || pageSize < 0 || PostID == 0) return BadRequest();
            try
            {
                //string lang = "vi";
                //try
                //{
                //    lang = HttpContext.Session.GetString("LanguageCode");
                //    if (lang == null)
                //    {
                //        lang = "vi";
                //    }
                //}
                //catch (Exception)
                //{
                //}
                var dataList = await repository.ListPagingPost(PostID, pageIndex, pageSize);
                //if (lang == "en")
                //{
                //    dataList = NovaticUtil.ChangePostLanguage(dataList, lang);
                //}
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
        [Route("api/ListPagingUser/{UserID}/{pageIndex}/{pageSize}")]
        public async Task<IActionResult> ListCommentPagingUser(int UserID, int pageIndex, int pageSize)
        {
            if (pageIndex < 0 || pageSize < 0 || UserID == 0) return BadRequest();
            try
            {
                //string lang = "vi";
                //try
                //{
                //    lang = HttpContext.Session.GetString("LanguageCode");
                //    if (lang == null)
                //    {
                //        lang = "vi";
                //    }
                //}
                //catch (Exception)
                //{
                //}
                var dataList = await repository.ListPagingUser(UserID, pageIndex, pageSize);
                //if (lang == "en")
                //{
                //    dataList = NovaticUtil.ChangePostLanguage(dataList, lang);
                //}
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
        public async Task<IActionResult> Add([FromBody] Comment model)
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
                    model.Website = "default.com.vn";
                    model.CreatedTime = DateTime.Now;
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
        public async Task<IActionResult> Update([FromBody] Comment model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //1. business logic 


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
        public async Task<IActionResult> Delete([FromBody] Comment model)
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
        [Route("api/DeletePermanently")]
        public async Task<IActionResult> DeletePermanently([FromBody] Comment model)
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

        [HttpGet]
        [Route("api/Count")]
        public int CountCommentUnChecked()
        {
            int result = repository.CountCommentUnChecked();
            return result;
        }
    }
}
