class Pessoa
{

public double peso, altura;

public double calculaImc()
{
    double valorImc = peso / (altura * altura);

    return valorImc;
}

public string grauObesidade(double valorImc)
{
    switch (valorImc)
    {
        case < 18.5: return "Abaixo do peso";

        case < 25: return "Peso normal";

        case < 30: return "Acima do peso";

        case < 35: return "Obesidade I";

        case < 40: return "Obesidade II";

        case >= 40: return "Obesidade III";

        default: return "Erro no grau de obesidade";                  
    }

}
public void mensagem()
{
    double getImc = calculaImc();
    string getObesidade = grauObesidade(getImc);
    Console.WriteLine("O calculo do valor do seu IMC é de: " + getImc + " e sua situação é: "+ getObesidade);
}

}