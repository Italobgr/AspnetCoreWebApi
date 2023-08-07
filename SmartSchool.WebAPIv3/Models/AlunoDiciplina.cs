using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPIv3.Models
{
    public class AlunoDiciplina
    {

        public AlunoDiciplina() {}
        public AlunoDiciplina(int alunoId, int diciplinaId) 
        {
            this.AlunoId = alunoId;
            this.DiciplinaId = diciplinaId;
   
        }
                public int AlunoId { get; set; }
          public Aluno Aluno { get; set; }
        public int DiciplinaId { get; set; }
        public Diciplina Diciplinas { get; set; }
    }
}