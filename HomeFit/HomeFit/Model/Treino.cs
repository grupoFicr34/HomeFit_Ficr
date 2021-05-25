using System;
using System.Collections.Generic;
using System.Text;


namespace HomeFit.Model
{
    public partial class Treino
    {
        private int ID;
        private DateTime DataInicial;
        private DateTime DataFinal;
        private Usuario Use;
        private double Baixo;
        private double Medio;
        private double Avancado;
        //public enum TipoDeTreino { Baixo, Medio, Avancado };
        List<String> exercicios = new List<string>();


        public DateTime datainical
        {
            get { return DataInicial; }
            set { DataInicial = value; }
        }

        public DateTime datafinal
        {
            get { return DataInicial; }
            set { DataInicial = value; }
        }

        public Usuario use
        {
            get { return Use; }
            set { Use = value; }
        }

        public double baixo
        {
            get { return Baixo; }
            set { Baixo = value; }
        }

        public double medio
        {
            get { return Medio; }
            set { Medio = value; }
        }

        public double avancado
        {
            get { return Avancado; }
            set { Avancado = value; }
        }


        public Boolean CriandoTreino(Usuario use) 
        {
            
            if ( use.imc <= 18.5)
            {
                Baixo = use.imc;
                return true;
            }
            else if ((use.imc > 18.5) && (use.imc < 30))
            {
                Medio = use.imc;
                return true;
            }   
            else if (use.imc >= 30)
            {
                Avancado = use.imc;
                return true;
            }
            else 
            {
                Console.WriteLine("Imc não encontrado");
                return false;
            }
        }


    }
}
