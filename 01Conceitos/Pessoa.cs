using System;

class Pessoa
{
    //Atributos - Caracteristicas que a pessoa pode ter.
    public string? nome;
    public int idade;

    //Métodos
    public void mensagem()
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos!");
    }
}