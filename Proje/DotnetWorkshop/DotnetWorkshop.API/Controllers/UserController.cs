using AutoMapper;
using DotnetWorkshop.Core.DTOs;
using DotnetWorkshop.Core.Models;
using DotnetWorkshop.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWorkshop.API.Controllers
{
    public class UserController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }
        // api/Team/
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var users = await _userService.GetAllAsync();
            var userDto = _mapper.Map<List<UserDto>>(users.ToList());
            return CreateActionResult(GlobalResponseDto<List<UserDto>>.Success(200, userDto));
        }

        [HttpGet("{id}")]
        // Get api/user/3
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(GlobalResponseDto<UserDto>.Success(200, userDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserDto userDto)
        {
            await _userService.UpdateAsync(_mapper.Map<User>(userDto));
            return CreateActionResult(GlobalResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            await _userService.RemoveAsync(user);

            return CreateActionResult(GlobalResponseDto<NoContentDto>.Success(204));
        }

        [HttpPost("Login")]
        public IActionResult Login(AuthRequestDto requestDto)
        {
            var result = _userService.Login(requestDto);

            if (result.User != null)
                return CreateActionResult(GlobalResponseDto<AuthResponseDto>.Success(200, result));
            else
                return CreateActionResult(GlobalResponseDto<AuthResponseDto>.Success(401, result));
        }

        [HttpPost("Signup")]
        public async Task<IActionResult> SignUp(AuthRequestDto requestDto)
        {
            var user = _userService.SignUp(requestDto);
            return CreateActionResult(GlobalResponseDto<UserDto>.Success(201, user));
        }
    }

}
