using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuesto
{
    public class CalculadoraImpuesto
    {
        const decimal porcentajeIva = 0.16m;
        public decimal ObtenerIVA(decimal montoReserva)
        {
            return montoReserva * porcentajeIva;
        }

        public decimal ObtenerIHS(decimal montoReserva, decimal procentajeISH)
        {
            return montoReserva * procentajeISH;
        }
    }
}
