using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cuenta
    {
        private int numerMesa;
        private float totaldelaCuenta;
        private List<Producto> productosConsumidos;
        private bool cuentaCerrada;

        public Cuenta  () 
        {
        }
       
   
        public Cuenta(int numerMesa, float totaldelaCuenta,  bool cuentaCerrada, List<Producto> productosConsumidos)
        {
            this.NumerMesa = numerMesa;
            this.TotaldelaCuenta = totaldelaCuenta;
            this.ProductosConsumidos = productosConsumidos;
            this.CuentaCerrada = cuentaCerrada;
        }

        public int NumerMesa { get => numerMesa; set => numerMesa = value; }
        public float TotaldelaCuenta { get => totaldelaCuenta; set => totaldelaCuenta = value; }
        public List<Producto> ProductosConsumidos { get => productosConsumidos; set => productosConsumidos = value; }
        public bool CuentaCerrada { get => cuentaCerrada; set => cuentaCerrada = value; }

















    }
}
