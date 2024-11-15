using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class Comercio
    {
        Queue <Pagos> colaPagos = new Queue<Pagos> ();
        Queue <Cliente> colaClientes = new Queue<Cliente> ();   
        List <CuentaCorriente> cuentas = new List<CuentaCorriente> ();
        List <Ticket> listaAtendidos = new List<Ticket> (); 
        public void AgregarTicket(Ticket ticket)
        {
            if(ticket is Cliente)
            {
                colaClientes.Enqueue((Cliente)ticket);
            } else if(ticket is Pagos)
            {
                colaPagos.Enqueue((Pagos)ticket);
            }
        }
        public CuentaCorriente VerCC (int nroCuenta)
        {
            Cliente cli = new Cliente("500000");
            CuentaCorriente c = new CuentaCorriente(nroCuenta, cli);
            cuentas.Sort();
            int i = cuentas.BinarySearch(c);
            if (i >= 0)
            {
                return cuentas[i];
            }
            else
            {
                return null;
            }
        }
       public Ticket AtenderTicket (int tipo)
        {
            Ticket ticket = null;
            if (tipo == 1)
            {
                if (colaClientes.Count > 0)
                {
                    ticket = colaClientes.Dequeue();
                }
            }
            else if (tipo == 2)
            {
                if (colaPagos.Count > 0)
                {
                    ticket = colaPagos.Dequeue();
                }
            }
            if (ticket != null)
            {
                listaAtendidos.Add(ticket);
            }
            return ticket;
        } 
        public CuentaCorriente AgregarCuentaC(int nroCuenta, string dni)
        {
            CuentaCorriente CC = VerCC(nroCuenta);
            if (CC == null) 
            {
                Cliente c = new Cliente(dni);
                CC = new CuentaCorriente(nroCuenta, c);
            }
            cuentas.Add(CC);
            return CC;
        }
    }
}
