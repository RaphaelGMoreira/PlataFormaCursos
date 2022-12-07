namespace PlataformaCurso.Models;

public class Materia : Cadastro {
    

    public Materia(string nome, Professor ProfessorResponsavel) : base(nome, ProfessorResponsavel)
    {
    }

    public override bool MatricularAluno(Aluno aluno)
    {
        if(!aluno.TemPendenciaFinanceira && this.Alunos.Count < 50) {
            this.Alunos.Add(aluno);
            return true;
        }

        return false;
    }
}