using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using study.automapper.Repository;
using AutoMapper;
using study.automapper.Models;

namespace study.automapper.Controllers
{
    public class StudentsController : ControllerBase
    {
        private readonly StudentRepository studentRepository = null;

        private readonly IMapper _mapper;

        public StudentsController(IMapper mapper)
        {
            studentRepository = new StudentRepository();
            _mapper = mapper;
        }

        [Route("")]
        public IActionResult GetStudents()
        {
            var data = studentRepository.GetAllStudents();
            StudentModel[] studentModel = _mapper.Map<StudentModel[]>(data);
            if (studentModel == null) return NotFound();
            return Ok(studentModel);
        }

    }
}