﻿using ETicaretAPI.Application.Abstractions.Services.Configurations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationServicesController : ControllerBase
    {
        readonly IApplicationService _applicationService;

        public ApplicationServicesController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult AuthorizeDefinitionEndPoints()
        {
            var datas = _applicationService.GetAuthorizeDefinitionEndpoints(typeof(Program));
            return Ok(datas);
        }
    }
}