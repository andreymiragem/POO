using System;

class Pessoa
{
    //Você pode ter métodos com o mesmo nome porém com parâmetros diferentes.
    //Método 01
    public void apresentar()
    {
        Console.WriteLine("Olá!!!");
    }
    //Método 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
    //Método 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos.");
    }
}