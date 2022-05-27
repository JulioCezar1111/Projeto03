using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julio0030
{
    class Calculo
    {
        private double P1, P2, P3, P4, P5, P6;

        public Calculo(double P1, double P2, double P3, double P4, double P5, double P6)
        {
            this.P1 = P1;
            this.P2 = P2;
            this.P3 = P3;
            this.P4 = P4;
            this.P5 = P5;
            this.P6 = P6;
        }
        public double MediasDasNotas()
        {
            double Media = (P1 + P2 + P3 + P4 + P5 + P6) / 6;
            return Media;
        }
        public double SomatorioDasNotas()
        {
            double soma = P1 + P2 + P3 + P4 + P5 + P6;
            return soma;
        }
        public double MaiorNota()
        {
            double[] notas = new double[] {P1, P2, P3, P4, P5, P6};
            Array.Sort(notas);
            return notas[5];
        }
        public double MenorNota()
        {
            double[] notas_1 = new double[] { P1, P2, P3, P4, P5, P6 };
            Array.Sort(notas_1);
            return notas_1[0];
        }
    }
}
