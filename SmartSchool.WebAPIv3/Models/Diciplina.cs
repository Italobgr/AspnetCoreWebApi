using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPIv3.Models
{
    public class Diciplina
    {
        public Diciplina()
        {
            
        }

        public Diciplina(int id,string nome ,int professorId) 
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
            //this.ProfessorId = professorId;
          
   
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        //o entity identifica que esta prop esta referenciando a class Professor com o id no final
        public int ProfessorId  { get; set; }
        public Professor Professor { get; set; }

        public IEnumerable<AlunoDiciplina> AlunoDiciplina { get; set; }

    }
}
