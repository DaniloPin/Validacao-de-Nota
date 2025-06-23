public class Avaliacao 
{
    public string Aluno { get; set; }
    public double Nota { get; private set; }

    public Avaliacao(string aluno) {
        Aluno = aluno;
    }

    public void AtribuirNota(double nota) { 
        Nota = nota;

        if (nota >= 0 && nota <= 10) {
            Nota = nota;

        }
        else {
            Console.WriteLine("Erro: A nota deve estar entre 0 e 10.");
        }
    }

}