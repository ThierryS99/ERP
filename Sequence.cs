using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    class Sequence // SEQUENCIA DO ROTEIRO
    {
        public int IdSequence { get; set; } // NÚMERO DA SEQUENCIA
        public int Machine { get; set; } // MÁQUINA
        public int Operation { get; set; } // OPERAÇÃO DE FABRICAÇÃO
        public TimeSpan RegulationTime { get; set; } // TEMPO PARA REGULAR
        public TimeSpan ProductionTime { get; set; } // TEMPO PARA PRODUZIR

        public Sequence() { }

    }
}
