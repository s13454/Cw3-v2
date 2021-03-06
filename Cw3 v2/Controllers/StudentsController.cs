﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3_v2.DAL;
using Cw3_v2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Cw3_v2.Controllers
{
    [ApiController]
    [Route("api/students")]
   
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
		{
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy) 
       {
            return Ok(_dbService.GetStudents());
        }


     //   [HttpGet]
      //  public string GetStudent()
      //  {
      //      return "Kowalski, Malewski, Andrzejewski";
      //  }
      //  [HttpGet("{id}")]
      //  public IActionResult GetStudent(int id) 
     //   {
     //       if (id == 1)
     //       {
     //           return Ok("Kowalski");
     //       }
     //       else if (id==2)
    //        {
     //           return Ok("Malewski");
     //       }
      //      return NotFound("Nie znaleziono Studenta");


//        }
      //  [HttpGet]
       // public string GetStudents(string orderBy) 
       // {
         //   return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        //}

        [HttpPost]

        public IActionResult CreateStudents(Student student) 
        {
            //...add to database
            // ... generating index number
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {

            if (id < 1)
            {
                return Ok("Aktualizacja dokończona");
            }
         
            return NotFound("Nie znaleziono Studenta");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok("Usuwanie ukończone");
        }

    }
}