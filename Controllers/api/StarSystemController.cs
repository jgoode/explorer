using explorer_api.Repository;
using explorer_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using explorer_api.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace explorer_api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class StarSystemController: Controller
    {
        private IStarSystemRepository _starSystemRepository;
        private ApplicationUser _user;

        public StarSystemController(IStarSystemRepository starSystemRepository)
        {
            _starSystemRepository = starSystemRepository;
            _user = new ApplicationUser()
            {
                Email = "johnhgoode@gmail.com",
                Id = "b704abf2-2b79-48e8-b410-239fe905fc86",
                EmailConfirmed = true,
                UserName = "The Mule"
            };
        }

        [HttpPost("/api/v{version:apiVersion}/starsystems")]
        public IActionResult Create([FromBody] StarSystemViewModel starSystem)
        {
            if (_user == null) return Unauthorized();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newStarSystem = Mapper.Map<StarSystemViewModel, StarSystem>(starSystem);
            newStarSystem.Created = DateTime.Now;
            newStarSystem.Updated = DateTime.Now;

            _starSystemRepository.Add(newStarSystem);

            try
            {
                _starSystemRepository.Commit();
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

            starSystem = Mapper.Map<StarSystem, StarSystemViewModel>(newStarSystem);

            return Ok(new
            {
                result = "ok",
                commander = _user.UserName,
                journalId = starSystem.Id,
                createDate = starSystem.Created
            });
        }
    }
}