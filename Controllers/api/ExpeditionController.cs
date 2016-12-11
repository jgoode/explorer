using System;
using AutoMapper;
using explorer_api.Models;
using explorer_api.Repository;
using explorer_api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace explorer_api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ExpeditionController: Controller
    {
        private IExpeditionRepository _expeditionRepository;
        private ApplicationUser _user;

        public ExpeditionController(IExpeditionRepository expeditionRepository)
        {
            _expeditionRepository = expeditionRepository;
            _user = new ApplicationUser()
            {
                Email = "johnhgoode@gmail.com",
                Id = "b704abf2-2b79-48e8-b410-239fe905fc86",
                EmailConfirmed = true,
                UserName = "The Mule"
            };
        }

        [HttpPost("/api/v{version:apiVersion}/expeditions")]
        public IActionResult Create([FromBody] ExpeditionViewModel expedition)
        {
            if (_user == null) return Unauthorized();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newExpedition = Mapper.Map<ExpeditionViewModel, Expedition>(expedition);
            newExpedition.Created = DateTime.Now;
            newExpedition.Updated = DateTime.Now;
            newExpedition.UserId = _user.Id;
            _expeditionRepository.Add(newExpedition);

            try
            {
                _expeditionRepository.Commit();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    result="error",
                    message=ex.Message,
                    stacktrace=ex.StackTrace,
                    innerExceptionMessage=ex.InnerException.Message,
                    innerExceptionStackTrace=ex.InnerException.StackTrace
                });
            }

            expedition = Mapper.Map<Expedition, ExpeditionViewModel>(newExpedition);

            return Ok(new
            {
                result = "ok",
                commander = _user.UserName,
                Id = expedition.Id,
                createDate = expedition.Created
            });
        }
    }
}