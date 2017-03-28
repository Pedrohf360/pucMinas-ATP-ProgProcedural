using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_23_Microondas
{
    class Microondas
    {
        private int potencia;
        private Boolean ligado;
        private Boolean portaAberta;
        private Boolean temporizadorAtivo;
        private int temporizadorMin;
        private int temporizadorSeg;

        public Microondas()
        {
            this.potencia = 10;
            this.ligado = false;
            this.portaAberta = false;
            this.temporizadorMin = 0;
            this.temporizadorSeg = 0;
        }

        public void Desligar()
        {
            this.ligado = false;   
        }

        public void Ligar()
        {
            this.ligado = true;
        }

        public void AjusteTemporizador(int minutos, int segundos)
        {
            if (this.ligado == true)
            {
                this.temporizadorMin = minutos;
                this.temporizadorSeg = segundos;
            }
        }

        // Métodos GET/SET:

        public int Potencia
        {
            get { return this.potencia; }
            set
            {
                if (value > 0 && value <= 10)
                this.potencia = value;
            }
        }

        public Boolean PortaAberta
        {
            get { return this.portaAberta; }
            set { this.portaAberta = value; }
        }

        public Boolean Ligado
        {
            get { return this.ligado; }
            set { this.ligado = value; }
        }

        public Boolean TemporizadorAtivo
        {
            get { return this.temporizadorAtivo; }
            set
            {   if (this.ligado == true) // Permite mudar o estado (false p/ true) apenas se o microondas estiver ligado.
                this.temporizadorAtivo = value;
            }
        }

        public int TemporizadorMin
        {
            get { return this.temporizadorMin; }
            set { this.temporizadorMin = value; }
        }

        public int TemporizadorSeg
        {
            get { return this.temporizadorSeg; }
            set { this.temporizadorSeg = value; }
        }
    }
}
