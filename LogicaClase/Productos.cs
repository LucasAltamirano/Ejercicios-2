using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public enum ETipo
    {
        comestible,
        bebible,
    }

    public class Producto
    {
        private static int idIncremental;
        private int idProducto;
        private string nombre;
        private float valorXUnidad;
        private int cantidadStock;
        private ETipo tipo;

        static Producto()
        {
            idIncremental = 1;
        }
        public Producto(string nombre, float valorXUnidad, int cantidadStock, ETipo tipo)
        {
            this.IdProducto = idIncremental;
            this.nombre = nombre;
            this.valorXUnidad = valorXUnidad;
            this.cantidadStock = cantidadStock;
            this.tipo = tipo;
            idIncremental++;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public float ValorXUnidad { get => valorXUnidad; set => valorXUnidad = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }

        public string GetProductos()
        {
            return this.MostrarProducto();
        }


        public string MostrarProducto()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre :{Nombre}");
            stringBuilder.AppendLine($"Tipo de producto :{Tipo}");
            stringBuilder.AppendLine($"Valor Unitario :{ValorXUnidad}");
            stringBuilder.AppendLine($"Cantidad de Stock :{CantidadStock}");
            stringBuilder.AppendLine($"Codigo de producto :{IdProducto}");

            return stringBuilder.ToString();
        }


        public static List<Producto> ProductosDisponibles(int nmesa)
        {
            List<Producto> listAux = new List<Producto>();

            if (nmesa >= 15)
            {
                foreach (Producto p in Bar.ListaProductos)
                {
                    if (p.Tipo == ETipo.bebible)
                    {

                        listAux.Add(p);
                    }
                }
            }
            else
            {
                foreach (Producto p in Bar.ListaProductos)
                {
                    listAux.Add(p);
                }
            }
            return listAux;
        }

        public static Producto ProductoSeleccionado(string prd)
        {
            Producto aux = null;
            foreach (var item in Bar.ListaProductos)
            {
                if (item.Nombre == prd)
                {
                    aux= item;
                    
                }
               
            }
            return aux;
        }

    }
}



