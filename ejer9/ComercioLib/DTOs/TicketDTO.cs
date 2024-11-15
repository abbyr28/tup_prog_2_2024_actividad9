using ComercioLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.DTOs
{
   public class TicketDTO
    {
       public int NroOrden { get; set; }
       public DateTime fechaHora { get; set; }
       public int tipo { get; set; }

        public TicketDTO(Ticket tic) 
        {
            NroOrden = tic.VerNroOrden();
            fechaHora = tic.VerFechaH();
            if (tic is Cliente)
            {
                tipo = 1;

            }
            else tipo = 2;
        }

    }
}
