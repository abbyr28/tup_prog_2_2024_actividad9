using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class Ticket
    {
        protected int nroOrden;
        DateTime fechaHora;

        public int VerNroOrden()
        {
            return nroOrden;
        }
        public DateTime VerFechaH()
        {
            return fechaHora;
        }
    }
}
