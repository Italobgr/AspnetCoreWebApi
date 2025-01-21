using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPIv3.Data;
using SmartSchool.WebAPIv3.Models;

namespace SmartSchool.WebAPIv3.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _context;
          public ProfessorController(SmartContext context)
          {
            _context = context;
          }


        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_context.Professores);
        }


 //api/aluno
      
        //api/aluno/ById/{id}
         [HttpGet("ById/{id}")]
        public  IActionResult GetById(int id)
        {
            //pega  primeiro aluno se o id do body for igual ao do aluno
            var aluno = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não foi encontrado"); 
            // if (aluno == null) return BadRequest("Professor não foi encontrado");
            return Ok(aluno);
        }

        //api/aluno/name
        [HttpGet("name")]
        public  IActionResult GetByName(string name, string sobrenome)
        {
            
            var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(name) && a.Sobrenome.Contains(sobrenome));//verifica se o nome do body e igual ao de um aluno existente
            if (aluno == null) return BadRequest("Professor não foi encontrado"); 
            return Ok(aluno);
        }

        //api/aluno/nome
        [HttpPost]
        public  IActionResult Post(Professor professor)
        {         
            _context.Add(professor);// add um aluno
            _context.SaveChanges();  
            return Ok(professor);
        }

        //api/aluno/nome/"Numero do id"
        //o json passa as informação junto com o id para n criar outro
        [HttpPut("{id}")]
        public  IActionResult Put(int id, Professor professor)
        {
            var alun = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);//verifica se o id e existe
            if (professor == null)
            return BadRequest("Aluno não foi encontrado");
           _context.Update(professor);// atualiza um aluno
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public  IActionResult Patch(int id, Professor professor)
        {

            //AsNoTracking() não deixa travar depois de passar por esse primeiro select de verificação
           var alu = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);//verifica se o id e existe
            if (professor == null)
            return BadRequest("Aluno não foi encontrado");

            _context.Update(professor);// atualiza um aluno
            _context.SaveChanges();
            return Ok(professor);
            
        }

        //api/aluno/nome
        [HttpDelete("{id}")]
        public  IActionResult Delete(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);//verifica se o id e existe
            if (aluno == null)
            return BadRequest("Aluno não foi encontrado");
             _context.Remove(id);// deleta um aluno
            _context.SaveChanges();
            return Ok();
        }

#region -- [Deleta grupo]
        /*[HttpDelete("{id}")]
            public  IActionResult DeleteRT(int id)
            {
            //apagara o grupo de  usuarios
                return Ok();
            }*/
#endregion

    }
}
