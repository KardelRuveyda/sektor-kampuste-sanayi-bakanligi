using AutoMapper;
using DotnetWorkshop.Core.DTOs;
using DotnetWorkshop.Core.Models;
using DotnetWorkshop.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWorkshop.API.Controllers
{
    public class TeamController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITeamService _teamService;

        public TeamController(IMapper mapper, ITeamService teamService)
        {
            _mapper = mapper;
            _teamService = teamService;
        }

        [HttpGet]
        // api/Team
        public async Task<IActionResult> All()
        {
            var teams = await _teamService.GetAllAsync();
            var teamsDto = _mapper.Map<List<TeamDto>>(teams.ToList());
            return CreateActionResult(GlobalResponseDto<List<TeamDto>>.Success(200, teamsDto));
        }

        [HttpGet("{id}")]
        // Get api/Team/3
        public async Task<IActionResult> GetById(int id)
        {
            var team = await _teamService.GetByIdAsync(id);
            var teamDto = _mapper.Map<TeamDto>(team);
            return CreateActionResult(GlobalResponseDto<TeamDto>.Success(200, teamDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TeamDto teamDto)
        {
            var team = await _teamService.AddAsync(_mapper.Map<Team>(teamDto));
            var teamDtos = _mapper.Map<TeamDto>(team);
            return CreateActionResult(GlobalResponseDto<TeamDto>.Success(201,teamDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TeamDto teamDto)
        {
            await _teamService.UpdateAsync(_mapper.Map<Team>(teamDto));
            return CreateActionResult(GlobalResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var team = await _teamService.GetByIdAsync(id);
            await _teamService.RemoveAsync(team);

            return CreateActionResult(GlobalResponseDto<NoContentDto>.Success(204));
        }

    }
}
