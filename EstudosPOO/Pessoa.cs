using System.Runtime.InteropServices;

public class Pessoa 
{
    public int Idade;
    public string Nome;

    // Método sem argumento e sem retorno
    public void Andar();

    // Método com argumento do tipo Comida e sem retorno
    public void Comer(Comida comida);

    // Método construtor não possui nome e nem retorno ele recebe o mesmo nome da classe
    public Pessoa(int Idade, string Nome)
    {
        Idade = Idade;
        Nome = Nome;
    }
}