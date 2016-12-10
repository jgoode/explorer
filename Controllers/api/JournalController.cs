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
    public class JournalController: Controller
    {
        private IJournalRepository _journalRepository;
        private ApplicationUser _user;

        public JournalController(IJournalRepository journalRepository)
        {
            _journalRepository = journalRepository;

            _user = new ApplicationUser()
            {
                Email = "johnhgoode@gmail.com",
                Id = "b704abf2-2b79-48e8-b410-239fe905fc86",
                EmailConfirmed = true,
                UserName = "The Mule"
            };
        }


        [HttpPost("/api/v{version:apiVersion}/journals")]
        public IActionResult Create([FromBody] JournalViewModel journal)
        {
            if (_user == null) return Unauthorized();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newJournal = Mapper.Map<JournalViewModel, Journal>(journal);
            newJournal.Created = DateTime.Now;
            newJournal.Updated = DateTime.Now;

            _journalRepository.Add(newJournal);

            try
            {
                _journalRepository.Commit();
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

            journal = Mapper.Map<Journal, JournalViewModel>(newJournal);

            return Ok(new
            {
                result = "ok",
                commander = _user.UserName,
                journalId = journal.Id,
                createDate = journal.Created
            });
        }
    }
}