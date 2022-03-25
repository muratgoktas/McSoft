
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
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    [Route("api/[controller]")]
    [ApiController]
    public class EducationInformationsController : ControllerBase
    {
         
       private IEducationInfoService _educationInfoService;
        public EducationInformationsController(IEducationInfoService educationInfoService)
        {
            _educationInfoService = educationInfoService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _educationInfoService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbypersonal")]
        public IActionResult GetbyPersonal(int personelId)
        {
            var result = _educationInfoService.GetbyPersonal(personelId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetbyId(int Id)
        {
            var result = _educationInfoService.GetbyId(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(EducationInformation educationInformation)
        {
            var result = _educationInfoService.Add(educationInformation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(EducationInformation educationInformation)
        {
            var result = _educationInfoService.Delete(educationInformation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(EducationInformation educationInformation)
        {
            var result = _educationInfoService.Update(educationInformation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
