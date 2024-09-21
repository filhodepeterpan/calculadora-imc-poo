using System;

namespace exercicioPooIMC
{
    public class Pessoa
    {   
        private string nome = "";
        private double altura = 0f;
        private double peso = 0f;


        public string Nome
        {
            get {return nome;}
            set {nome = value;}
        }

        public double Altura
        {
            get {return altura;}
            set {altura = value;}
        }
        public double Peso
        {
            get {return peso;}
            set {peso = value;}
        }


        public Pessoa (string nome, double altura, double peso)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }
    }
}