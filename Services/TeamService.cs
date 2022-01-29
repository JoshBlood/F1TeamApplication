using F1TeamApplication.Context;
using F1TeamApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1TeamApplication.Services
{
    public class TeamService : ITeamService
    {
        private readonly TeamsDBContext _teamsDBContext;

        public TeamService(TeamsDBContext teamsDBContext)
        {
            _teamsDBContext = teamsDBContext;
        }

        public List<Team> GetAllTeams()
        {
            return _teamsDBContext.Teams.ToList();
        }
    }
}
