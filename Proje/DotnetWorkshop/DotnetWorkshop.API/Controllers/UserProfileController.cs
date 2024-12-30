using AutoMapper;
using DotnetWorkshop.Core.DTOs;
using DotnetWorkshop.Core.Models;
using DotnetWorkshop.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWorkshop.API.Controllers
{
    public class UserProfileController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserProfileService _userProfileService;
        public UserProfileController(IMapper mapper, IUserProfileService userProfileService)
        {
            _mapper = mapper;
            _userProfileService = userProfileService;
        }
        // api/UserProfile/
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var userProfiles = await _userProfileService.GetAllAsync();
            var userProfilesDto = _mapper.Map<List<UserProfileDto>>(userProfiles.ToList());
            return CreateActionResult(GlobalResponseDto<List<UserProfileDto>>.Success(200, userProfilesDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var userProfile = await _userProfileService.GetByIdAsync(id);
            var userProfileDto = _mapper.Map<UserProfileDto>(userProfile);
            return CreateActionResult(GlobalResponseDto<UserProfileDto>.Success(200, userProfileDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(UserProfileDto userProfileDto)
        {
            var userProfile = await _userProfileService.AddAsync(_mapper.Map<UserProfile>(userProfileDto));
            var userProfileDtos = _mapper.Map<UserProfileDto>(userProfile);
            return CreateActionResult(GlobalResponseDto<UserProfileDto>.Success(201, userProfileDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserProfileDto userProfileDto)
        {
            await _userProfileService.UpdateAsync(_mapper.Map<UserProfile>(userProfileDto));
            return CreateActionResult(GlobalResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var userProfile = await _userProfileService.GetByIdAsync(id);
            await _userProfileService.RemoveAsync(userProfile);

            return CreateActionResult(GlobalResponseDto<NoContentDto>.Success(204));
        }
    }
}
