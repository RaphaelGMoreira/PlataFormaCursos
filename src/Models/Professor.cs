using PlataformaCursos.src.Models;

namespace PlataformaCurso.Models;

public class Professor : Funcionario
{
    public Professor(string nome) : base(nome)
    {
    }

    public bool ValidaSeSabeConhecimento(string conhecimento)
    {
        return Conhecimentos.Contains(conhecimento);
    }
}