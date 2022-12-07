namespace PlataformaCurso.Models;


public abstract class Cadastro
{

    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    public Professor? ProfessorResponsavel { get; set; }

    public Cadastro(string nome, Professor? professorResponsavel)
    {
        this.Nome = nome;

        if(professorResponsavel?.ValidaSeSabeConhecimento(nome) ?? false)
        {
            this.ProfessorResponsavel = professorResponsavel;
        }
        else
        {
            Console.WriteLine("Professor não está apto para ministrar esta matéria");
            this.ProfessorResponsavel = null;
        }
    }
        public abstract bool MatricularAluno(Aluno aluno);


        


}