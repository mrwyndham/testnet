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
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsService _productsDbService;

        public ProductsController(ProductsService userInfoDbService)
        {
            _productsDbService = userInfoDbService;
        }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return _productsDbService.FindAll();
        }


        [HttpPost]
        public Products Insert(Products dto)
        {
            _productsDbService.Insert(dto);
            return dto;
        }
    }
}
