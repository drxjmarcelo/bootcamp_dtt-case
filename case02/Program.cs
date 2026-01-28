using System;

class Cadastro
{
    static void Main()
    {
        string nome;

        
        while (true)
        {
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                break;
            }

            Console.WriteLine("NOME INVÁLIDO! O nome não pode estar vazio.");
        }

        int idade;

        
        while (true)
        {
            Console.WriteLine("Digite sua idade:");
            string idadeTexto = Console.ReadLine();

            if (!int.TryParse(idadeTexto, out idade))
            {
                Console.WriteLine("VALOR INVÁLIDO! A idade deve ser um número.");
                continue;
            }

            if (idade <= 0)
            {
                Console.WriteLine("VALOR INVÁLIDO! A idade deve ser maior que zero.");
                continue;
            }

            break;
        }

        Console.WriteLine("Cadastro realizado com sucesso!");
    }
}