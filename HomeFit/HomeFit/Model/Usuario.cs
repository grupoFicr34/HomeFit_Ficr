using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFit.Model
{
    public class Usuario
    {
        private int ID;
        private String Nome;
        private int Idade;
        private double Peso;
        private double Altura;
        private double Imc;
        List<Treino> use = new List<Treino>();

    
        public Usuario(string Nome, int Idade, double Peso, double Altura)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Imc = CalcularImc(Peso, Altura);
        }

        public String nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public int idade
        {
            get { return Idade; }
            set { Idade = value; }
        }

        public double peso
        {
            get { return Peso; }
            set { Peso = value; }
        }

        public double altura
        {
            get { return Altura; }
            set { Altura = value; }
        }

        public double imc
        {
            get { return Imc; }
            set { Imc = value; }
        }

        public double CalcularImc(double peso, double altura) 
        {
            this.Imc = peso/(altura * altura);
            return Imc;
        }

        public override string ToString()
        {
            return "\nID      : " + this.ID +
                "\nNome      : " + this.Nome +
                   "\nIdade    : " + this.Idade +
                   "\nPeso: " + this.Peso +
                   "\nAltura  : " + this.Altura +
                    "\nIMC  : " + this.Imc;
        }
    }
}
