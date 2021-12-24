using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleRESTAPI.Data;
using SampleRESTAPI.Dtos;
using SampleRESTAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleRESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IAuthor _author;
        private IMapper _mapper;

        public AuthorsController(IAuthor author, IMapper mapper)
        {
            _author = author;
            _mapper = mapper;
        }
        // GET: api/<CoursesController>
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorDto>>> Get()
        { 
            var results = await _author.GetAll();
            return Ok(_mapper.Map<IEnumerable<AuthorDto>>(results));
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDto>> Get(int id)
        {
            var result = await _author.GetById(id.ToString());
            if (result == null)
                return NotFound();

            return Ok(_mapper.Map<CourseDto>(result));
        }

        // POST api/<CoursesController>
        [HttpPost]
        public async Task<ActionResult<AuthorDto>> Post([FromBody] AuthorForCreateDto body)
        {
            try
            {
                var data = _mapper.Map<Models.Author>(body);
                var result = await _author.Insert(data);
                var coursedto = _mapper.Map<Dtos.AuthorDto>(result);
                return Ok(coursedto);  
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<AuthorDto>> Put(int id, [FromBody] AuthorForCreateDto courseToCreateDto)
        {
            try
            {
                var course = _mapper.Map<Models.Author>(courseToCreateDto);
                var result = await _author.Update(id.ToString(), course);
                var coursedto = _mapper.Map<Dtos.AuthorDto>(result);
                return Ok(coursedto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _author.Delete(id.ToString());
                return Ok($"delete data id {id} berhasil");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("bytitle")]
        public async Task<IEnumerable<Author>> GetByTitle(string title)
        {
            var results = await _author.GetByTitle(title);
            return results;
        }
    }
}
