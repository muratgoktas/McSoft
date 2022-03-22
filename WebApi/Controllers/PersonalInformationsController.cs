using McSoft.BusinessLayer.Abstract;
using McSoft.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInformationsController : ControllerBase
    {
        private IPersonalInfoService _personalInfoService;

        public PersonalInformationsController(IPersonalInfoService personalInfoService)
        {
            _personalInfoService = personalInfoService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _personalInfoService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        /*
         [HttpGet("getbypersonal")]
          public IActionResult GetbyPersonal(int Id)
          {
              var result = _personalInfoService.GetbyPersonal(Id);
              if (result.Success)
              {
                  return Ok(result.Data);
              }

              return BadRequest(result.Message);
          }
        */
        [HttpGet("getbyid")]
        public IActionResult GetbyId(int Id)
        {
            var result = _personalInfoService.GetbyId(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(PersonalInformation personalInformation)
        {
            var result = _personalInfoService.Add(personalInformation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PersonalInformation personalInformation)
        {
            var result = _personalInfoService.Delete(personalInformation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(PersonalInformation personalInformation)
        {
            var result = _personalInfoService.Update(personalInformation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
