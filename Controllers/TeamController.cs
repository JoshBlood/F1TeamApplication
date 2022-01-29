using F1TeamApplication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1TeamApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("Teams")]
        [Authorize(Roles = "Administrator")]
        public IActionResult TeamsEndpoint()
        {
            var teams = _teamService.GetAllTeams();

            return Ok(teams);
        }
    }
}
