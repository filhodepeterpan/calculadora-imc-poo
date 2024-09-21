using System;

namespace exercicioPooIMC
{
    class Program
    {
        static void Main(string[] args)
        {    
            Pessoa pessoa = new Pessoa("", 0, 0);
            CalculadoraIMC calculadora = new CalculadoraIMC();

            for (int i = 1; i<=3; i++)
            {
                switch(i)
                {
                    case 1:
                    Console.WriteLine("Digite seu nome:");
                    pessoa.Nome =  Console.ReadLine() ?? "";
                    Console.Write("\n");
                    break;

                    case 2:
                    Console.WriteLine("Digite sua altura:");
                    pessoa.Altura =  double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("\n");
                    break;

                    case 3:
                    Console.WriteLine("Digite seu peso:");
                    pessoa.Peso =  double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("\n");
                    break;
                }
            }

            double imc = Math.Round(calculadora.calculaIMC(pessoa), 1);
            string classificacao = calculadora.classificaPessoa(pessoa);

            Console.WriteLine($@"
            SEUS DADOS:
            Nome: {pessoa.Nome}
            Peso: {pessoa.Peso}
            Altura: {pessoa.Altura}

            O seu IMC é de {imc} e isso é considerado {classificacao}.-> 
            ");
        }
    }
}