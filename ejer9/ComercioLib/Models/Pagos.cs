using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class Pagos:Ticket
    {
        static int nroInicio = 0;
        CuentaCorriente ficha;
        public Pagos(CuentaCorriente cuenta)
        {
            ficha = cuenta;
           nroOrden = ++nroInicio;
        }
    }
}
