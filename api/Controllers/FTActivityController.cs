using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FTActivity.Entities;
using FTActivity.Models;
using Microsoft.AspNetCore.Mvc;

namespace FTActivity.Controllers
{
    [ApiController]
    [ApiVersion( "1.0" )]
    [Route( "api/v{version:apiVersion}/[controller]" )]    
    public class FTActivityController : ControllerBase
    {
        private IActivityRepository _activityRepository;

        public FTActivityController(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        // GET api/v{version}/ftactivity
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Mapper.Map<IEnumerable<ActivityDTO>>(_activityRepository.FindAll().OrderByDescending(a => a.Date)));
        }

        // GET api/v{version}/ftactivity/5
        [HttpGet("{id}", Name = nameof(Get))]
        public ActionResult Get(int id)
        {
            return Ok(Mapper.Map<IEnumerable<ActivityDTO>>(_activityRepository.FindByCondition(a => a.ActivityId == id)));
        }

        // POST api/v{version}/ftactivity
        [HttpPost]
        public IActionResult Post([FromBody] ActivityCreationDTO _activityCreationDTO)
        {
            if(_activityCreationDTO == null)
            {
                return BadRequest();
            }

            var _activity = Mapper.Map<Activity>(_activityCreationDTO);
            _activity.Date = DateTime.Now;

            _activityRepository.Create(_activity);
            _activityRepository.Save();

            return CreatedAtRoute(nameof(FTActivityController.Get), new { id = _activity.ActivityId }, _activity);

        }

        // PUT api/v{version}/ftactivity/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/v{version}/ftactivity/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
