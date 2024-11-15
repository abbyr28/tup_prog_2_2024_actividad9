using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class CuentaCorriente:IComparable<CuentaCorriente>
    {
        Cliente titular;
        int nroCuenta;

        public CuentaCorriente(int  nroCuenta, Cliente titular)
        {
            this.nroCuenta = nroCuenta;
            this.titular = titular;
        }
        public int CompareTo(CuentaCorriente? other)
        {
            if (other != null) return this.nroCuenta.CompareTo(other.nroCuenta);
            else return -1;
            throw new NotImplementedException();
        }

    }

}
