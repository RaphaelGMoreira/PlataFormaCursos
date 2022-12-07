namespace PlataformaCurso.Models;

public class Extensao : Cadastro
{
    

    public Extensao(string nome, Professor ProfessorResponsavel) : base(nome, ProfessorResponsavel)
    {
    }

    public override bool MatricularAluno(Aluno aluno)
    {
        if (this.Alunos.Count < 100)
        {
            this.Alunos.Add(aluno);
            return true;
        }

        return false;
    }
}