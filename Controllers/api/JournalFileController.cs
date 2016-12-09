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

// ReSharper disable once CheckNamespace

namespace explorer_api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class JournalFileController : Controller
    {
        private IJournalFileRepository _journalFileRepository;
        private string _userId = "b704abf2-2b79-48e8-b410-239fe905fc86";
        private ApplicationUser _user;

        public JournalFileController(IJournalFileRepository journalFileRepository)
        {
            _journalFileRepository = journalFileRepository;
            _user = new ApplicationUser()
            {
                Email = "johnhgoode@gmail.com",
                Id = "b704abf2-2b79-48e8-b410-239fe905fc86",
                EmailConfirmed = true,
                UserName = "The Mule"
            };
        }

        public IActionResult Get()
        {
            if (_user == null)
            {
                return Unauthorized();
            }

            IEnumerable<JournalFile> journalFiles = _journalFileRepository
                .FindBy(p => p.UserId == _user.Id)
                .ToList();

            if (!journalFiles.Any() || null == journalFiles)
                return NoContent();

            return Ok(new
            {
                commander = _user.UserName,
                files = journalFiles.Select(p => new
                {
                    id = p.Id,
                    file = p.FileName,
                    createDate=p.Created
                })
            });
        }

        [HttpPost]
        public IActionResult Create([FromBody] JournalFileViewModel journalFile)
        {
            if (_user == null)
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newJournalFile = Mapper.Map<JournalFileViewModel, JournalFile>(journalFile);
            newJournalFile.UserId = _userId;
            newJournalFile.Created = DateTime.Now;
            newJournalFile.Updated = DateTime.Now;

            _journalFileRepository.Add(newJournalFile);
            try
            {
                _journalFileRepository.Commit();
            }
            catch (Exception ex)
            {
                return BadRequest(new {message=ex.Message, stacktrace=ex.StackTrace, innerExceptionMessage=ex.InnerException.Message, innerExceptionStackTrace=ex.InnerException.StackTrace});
            }
            //newJournalFile.User = _user;
            journalFile = Mapper.Map<JournalFile, JournalFileViewModel>(newJournalFile);

            return Ok(new
            {
                commander=_user.UserName,
                fileId = journalFile.Id,
                file=journalFile.FileName,
                createDate=journalFile.Created,
            });
        }
    }
}