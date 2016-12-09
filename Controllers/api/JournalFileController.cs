using explorer_api.Repository;
using explorer_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace explorer_api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class JournalFileController : Controller
    {
        private IJournalFileRepository _journalFileRepository;

        public JournalFileController(IJournalFileRepository journalFileRepository)
        {
            _journalFileRepository = journalFileRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody]JournalFile journalFile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok("Ok");
        }
    }
}