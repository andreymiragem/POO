namespace _01Conceitos;

class Program
{
    static void Main(string[] args)
    {
        //Instanciar um objeto
        Pessoa obj = new Pessoa();
        obj.nome = "Andrey";
        obj.idade = 25;
        obj.mensagem();
    }
}
