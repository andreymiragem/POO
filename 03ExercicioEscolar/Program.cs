namespace _03ExercicoEscolar;

class Program
{
    static void Main(string[] args)
    {
        //Instanciar objeto da classe Aluno
       Aluno aluno = new Aluno();
       
       aluno.nome = "Andrey";
       aluno.nota1 = 7;
       aluno.nota2 = 10;
       aluno.mensagem();

    }
}
