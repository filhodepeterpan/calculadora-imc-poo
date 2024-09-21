using System;

namespace exercicioPooIMC
{
    public class CalculadoraIMC
    {
        private double imc = 0f;
        private string classificacao = "";
        public double calculaIMC(Pessoa pessoa)
        {
            imc = pessoa.Peso / (pessoa.Altura*pessoa.Altura);

            return imc;
        }

        public string classificaPessoa (Pessoa pessoa)
        {   
            if (imc < 18.5)
                classificacao = "Abaixo do peso";

            else if (imc < 25)
                classificacao = "Peso normal";

            else if (imc < 30)
                classificacao = "Acima do peso";

            else if (imc < 35)
                classificacao = "Obesidade Grau I";

            else if (imc < 40)
                classificacao = "Obesidade Grau II";
                
            else
                classificacao = "Obesidade Grau III";

            return classificacao;
        }
    }
}