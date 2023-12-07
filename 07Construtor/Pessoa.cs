using System;

class Pessoa
{
    /* 
    Construtor é um metodo de mesmo nome da classe que é chamado quando a classe é instânciada e podem ter vários construtores de nome igual
    desde que tenham caracteristicas diferentes por exemplo adicionando parametros.
    */

    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá, " + nome);
    }
}