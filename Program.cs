namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
       Console.Write("Digite seu nome: ");
        aluno1.nome = Console.ReadLine();
       Console.Write("Digite sua 1° nota: ");
       aluno1.nota1 = Convert.ToDouble(Console.ReadLine());
       Console.Write("Digite sua 2° nota: ");
       aluno1.nota2 = Convert.ToDouble(Console.ReadLine());
       aluno1.mensagem();


    }
}
