



using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Mesa
    {
        private List<Consumo> consumos;
        private int id;
        private bool disponiblidad;
        private float totaldelaCuenta;

      

        public Mesa()
        {
        }
        public Mesa(int id,  float totaldelaCuenta, bool disponiblidad)
        {
            this.id = id;
            this.totaldelaCuenta = totaldelaCuenta;
            this.disponiblidad = disponiblidad;
        }

        public Mesa(int id, List<Consumo> consumos, bool disponiblidad, float totaldelaCuenta)
        {
            this.id = id;
            this.consumos = consumos;
            this.disponiblidad = disponiblidad;
            this.totaldelaCuenta = totaldelaCuenta;
        }


        public int Id { get => id; set => id = value; }
        public float TotaldelaCuenta { get => totaldelaCuenta; set => totaldelaCuenta = value; }

        public bool Disponiblidad { get => disponiblidad; set => disponiblidad = value; }
        public List<Consumo> Consumos { get => consumos; set => consumos = value; }

       

        public string MostrarMesa()
        {
            StringBuilder stgb = new StringBuilder();

            stgb.AppendLine($"Numero de mesa : {Id} Estado : {Disponiblidad}");
            foreach (var item in consumos)
            {
                stgb.AppendLine($"{item.MostrarConsumoEnDetalle()}");
            }

            stgb.AppendLine($"Consumido: {TotaldelaCuenta}");


            return stgb.ToString();
        }

        public float IndicarConsumoMesa()
        {
            int cant;
            float precioXunidad;
            float precXconsumicion;
            float precioTotal = 00.0f;
            foreach (var item in Consumos)
            {
                cant = item.Cantidad;
                //precioXunidad = item.Producto.ValorXUnidad;
                //precXconsumicion = cant * precioXunidad;
                //precioTotal = precioTotal + precXconsumicion;
            }

            return precioTotal;
        }
        public string IndicarConsumoMesa(Mesa mesa)
        {
            int cant;
            float precioXunidad;
            float precXconsumicion;
            float precioTotal = 00.0f;
            foreach (var item in mesa.Consumos)     
            {
                cant = item.Cantidad;
                //precioXunidad = item.Producto.ValorXUnidad;
                //precXconsumicion = cant * precioXunidad;
                //precioTotal = precioTotal + precXconsumicion;
            }

            return precioTotal.ToString();
        }



        //public void AgregarConsumicion(int cantidad,Producto prod,float pre)
        //{
        //    Consumo consumicion = new Consumo (cantidad,prod,pre);

        //    consumos.Add(consumicion);
        //}


        public float ConsumidoAlmomento()
        {
            float consumo = 0.00F;
            foreach (var item in consumos)
            {
                consumo = consumo +item.PrecioXConsumo;
            }
            return consumo;
        }

    }
}
