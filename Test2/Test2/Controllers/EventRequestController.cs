
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Daihoc_FPT_News.Models;
using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Daihoc_FPT_News.Controllers
{
            [Route("[controller]")]
            [ApiController]
            public class EventRequestController : BaseController
            {
                IEventRequestRepository repository; 
                IPostRepository repositoryPost;
                public EventRequestController(IEventRequestRepository _repository, ICacheHelper cacheHelper, IPostRepository _repositoryPost )  : base(cacheHelper)
                {
                    repository = _repository; 
                    repositoryPost = _repositoryPost;
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
                            //return NotFound();
                        } 
                        ViewBag.listEventRequest = dataList;
                        ViewBag.EventRequestCount = dataList.Count;
                        return View();
                }
                    catch (Exception e)
                    {
                        return BadRequest(e.Message + " - " + e.InnerException);
                    }
                }

                [HttpPost]
                [Route("receiveData")]
                public JsonResult YourMethod(string o)
                {
                ////var saveObject = Newtonsoft.Json.JsonConvert.DeserializeObject<clsMail>(o);
                //clsMail a = new clsMail(); 
                //a.Send(o, "Gửi mail demo", "<h1>Nội dung mail gửi đi<h1>");
                return Json("ok");
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
                    catch (Exception e)
                    {
                        return BadRequest(e.Message + " - " + e.InnerException);
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

                        var novaticResponse = NovaticResponse.SUCCESS(dataList.Cast<object>().ToList());
                        return Ok(novaticResponse);
                    }
                    catch (Exception e)
                    {
                        return BadRequest(e.Message + " - " + e.InnerException);
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
                    catch (Exception e)
                    {
                        return BadRequest(e.Message + " - " + e.InnerException);
                    }
                }

                [HttpPost]
                [Route("api/edit")]
                public async Task<IActionResult> Update([FromBody] EventRequest model)
                {
                    if (ModelState.IsValid)
                    {
                        try
                        {
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
                    catch (Exception e)
                    {
                        return BadRequest(e.Message + " - " + e.InnerException);
                    }
                }


                [HttpPost]
                [Route("api/Add")]
                public async Task<IActionResult> Add([FromBody]EventRequest model)
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
                        //Lấy thông tin account và thông tin sự kiện sau đó gửi Email
                        //#region
                        //var AccountRegisterObj = await repositoryAccount.Detail(model.AccountId);
                        //var EventRegisterObj = await repositoryPost.Detail(model.PostId);
                        //if (AccountRegisterObj != null && EventRegisterObj != null)
                        //{
                        //    var eventTime = EventRegisterObj[0].OpenTime.ToString("dd'/'MM'/'yyyy HH:mm:ss") + " đến " + EventRegisterObj[0].ClosedTime.ToString("dd'/'MM'/'yyyy HH:mm:ss");

                        //    string body = EmailUtil.RegisterEventSuccess(AccountRegisterObj[0].Username, AccountRegisterObj[0].Name, AccountRegisterObj[0].Email, AccountRegisterObj[0].Phone, "Chưa có", "Chưa có", eventTime, EventRegisterObj[0].Name, EventRegisterObj[0].EventAddress);
                        //    EmailUtil.SendEmail(AccountRegisterObj[0].Email, "Thông báo đăng ký tham gia sự kiện thành công", body);
                        //}

                        //#endregion
                        var novaticResponse = NovaticResponse.CREATED(model);
                                return Created("", novaticResponse);
                            }
                            else
                            {
                                return NotFound();
                            }
                        }
                        catch (Exception e)
                        {

                            return BadRequest(e.Message + " - " + e.InnerException);
                        }
                    }
                    return BadRequest();
                } 
         

                [HttpPost]
                [Route("api/Delete")]
                public async Task<IActionResult> Delete([FromBody]EventRequest model)
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
                public async Task<IActionResult> DeletePermanently([FromBody]EventRequest model)
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
                    catch (Exception e)
                    {
                        return BadRequest(e.Message + " - " + e.InnerException);
                    }
                }


                [HttpGet]
                [Route("api/Count")]
                public int CountEventRequest()
                {
                    int result = repository.CountEventRequest();
                    return result;
                }
            }
        }
    