using F1TeamApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1TeamApplication.Services
{
    public interface ITeamService
    {
        List<Team> GetAllTeams();
    }
}
