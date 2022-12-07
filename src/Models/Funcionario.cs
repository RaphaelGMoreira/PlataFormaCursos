using PlataformaCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaCursos.src.Models
{
    public abstract class Funcionario
    {

        public int NumeroCadastro { get; private set; }
        public string Nome { get; set; }
        public string GrauDeFormacao { get; set; } = "";
        public List<string> Conhecimentos { get; set; } = new List<string>();


        public Funcionario(string nome)
        {
            this.Nome = nome;
        }

        public abstract bool ValidaSeSabeConhecimento(string conhecimento);


    }

    

}
