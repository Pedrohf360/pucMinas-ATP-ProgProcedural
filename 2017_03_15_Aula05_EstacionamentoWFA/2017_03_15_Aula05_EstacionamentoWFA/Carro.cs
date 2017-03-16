using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_15_Aula05_EstacionamentoWFA
{
    class Carro
    {
        static double tarifaBase; // PERTENCE À CLASSE.
        private string placa;
        private DateTime horaEntrada;
        private DateTime horaSaida;

        static Carro()
        {
            tarifaBase = 9.00;
        }

        public Carro(string placa)
        {
            this.placa = placa;
            this.horaEntrada = new DateTime(1, 1, 1, 0, 0, 0);
            this.horaSaida = new DateTime(1, 1, 1, 0, 0, 0);
        }

        public string getPlaca() { return this.placa; }
        public DateTime getHoraEntrada() { return this.horaEntrada; }
        public DateTime getHoraSaida() { return this.horaSaida; }

        public void setHoraEntrada(string hora, string min)
        {
            int h = int.Parse(hora);
            int m = int.Parse(min);
            this.setHoraEntrada(h, m);
        }

        // Valida hora digitada.
        public void setHoraEntrada(int hora, int min)
        {
            if (hora >= 0 && hora < 24 && min >= 0 && min < 60)
                this.horaEntrada = new DateTime(1, 1, 1, hora, min, 0);
        }

        public void setHoraSaida(int hora, int min)
        {
            if (hora >= 0 && hora < 24 && min >= 0 && min < 60)
                this.horaSaida = new DateTime(1, 1, 1, hora, min, 0);
        }

        private double CalcTempoPassado()
        {
            TimeSpan chegada = horaSaida.Subtract(horaEntrada);
            return chegada.TotalHours;
        }

        public double TarifaPagar()
        {
            return tarifaBase * CalcTempoPassado();
        }


    }
}
