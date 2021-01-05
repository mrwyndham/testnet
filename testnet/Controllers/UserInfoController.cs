using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testnet.Models;
using testnet.Models.Services;

namespace testnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {
        private readonly UserInfoService _userInfoDbService;

        public UserInfoController(UserInfoService userInfoDbService)
        {
            _userInfoDbService = userInfoDbService;
        }

        [HttpGet]
        public IEnumerable<UserInfo> Get()
        {
            return _userInfoDbService.FindAll();
        }


        [HttpPost]
        public UserInfo Insert(UserInfo dto)
        {
            _userInfoDbService.Insert(dto);
            return dto;
        }
    }
}
