using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Consumo
    {

        int  cantidad;
        string producto;
        float precioUnitario;      
        float precioXConsumo;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Producto { get => producto; set => producto = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public float PrecioXConsumo { get => precioXConsumo; set => precioXConsumo = value; }

        public Consumo(int cantidad, string producto, float precioUnitario, float precioXConsumo)
        {
            this.Cantidad = cantidad;
            this.Producto = producto;
            this.PrecioUnitario = precioUnitario;
            this.PrecioXConsumo = precioXConsumo;
        }

        public string MostrarConsumoEnDetalle()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{cantidad}");
            str.Append($"  {producto}");
            str.Append($"  {precioUnitario}");
            str.Append($" ={precioXConsumo}");
           

            return str.ToString();
        }

        public static Producto ProductoSeleccionado(string prod)
        {
            Producto aux = null;
            foreach (var item in Bar.ListaProductos)
            {
                if (item.Nombre == prod)
                {
                    aux = item;
                    break;
                }
            }

            return aux;
        }








    }





}
