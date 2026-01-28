using System;

class Cadastro
{
    static void Main()
    {
        
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade:");
        string idadeTxt = Console.ReadLine();
        
        if(string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("NOME INVÁLIDO! O nome não pode estar vazio.");
        }

        int idade;

        if(!int.TryParse(idadeTxt, out idade))
        {
            Console.WriteLine("VALOR INVÁLIDO! A idade deve ser um número.");
            return;
        }

        if(idade <= 0)
        {
            Console.WriteLine("VALOR INVALIDO! A idade deve ser maior que zero.");
            return;
        }

        Console.WriteLine("Cadastro finalizado com sucesso!");
        
    }
}