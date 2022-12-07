using PlataformaCursos.src.Models;

namespace PlataformaCurso.Models;

public class Coordenador : Funcionario
{
    public Coordenador(string nome) : base(nome)
    {
    }

    public List<string> AreasDeAtuacao { get; set; } = new List<string>();

   

    public bool ValidaSeSabeConhecimento(string conhecimento)
    {
        return Conhecimentos.Contains(conhecimento)
            || AreasDeAtuacao.Contains(conhecimento);
    }
}