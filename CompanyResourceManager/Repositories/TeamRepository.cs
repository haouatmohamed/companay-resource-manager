using System;
using System.Collections.Generic;
using System.Linq;
using CompanyResourceManager.DTOs;
using CompanyResourceManager.Models;

namespace CompanyResourceManager.Repositories
{
    public sealed class TeamRepository
    {
        private readonly List<Team> _teams;

        public TeamRepository(List<Team> teams)
        {
            _teams = teams;
        }

        public long AddTeam(TeamDto teamDto)
        {
            var id = _teams.Max(team => team.Id) + 1;
            _teams.Add(new Team(id, teamDto.Value));
            return id;
        }

        public Team GetTeamById(long id)
        {
            return _teams.FirstOrDefault(team => team.Id == id);
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return _teams.ToArray();
        }

        public void Save()
        {
            _teams.ForEach(team =>
            {
                Console.WriteLine($"Id: {team.Id}, Value: {team.Value}");
            });
        }
    }
}
