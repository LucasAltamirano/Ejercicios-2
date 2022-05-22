using System.Collections.Generic;

namespace Logica
{
    public static class Bar
    {

        static private List<Usuarios> listaUsuarios;
        static private List<Producto> listaProductos;
        static private Mesa[] mesasDelSalon;
        static private Dictionary<string, int> keysProductos;
        static Bar()
        {
            HarcodeoUsuarios();
            HarcodeoProductos();
            HarcodeoMesas();
            DiccionarioProductos();
        }

        private static void HarcodeoUsuarios()
        {

            listaUsuarios = new List<Usuarios>();
            Administrador user1 = new Administrador(1, "lucas", "admi", true);
            Usuarios user2 = new Empleado(2, "lucas", "empleado", false);

            listaUsuarios.Add(user1);
            listaUsuarios.Add(user2);

        }

        private static void HarcodeoProductos()
        {
            listaProductos = new List<Producto>();
            Producto p1 = new Producto("Pancho", 50.00f, 100, ETipo.comestible);
            Producto p2 = new Producto("Pepsi", 60.00f, 100, ETipo.bebible);
            Producto p3 = new Producto("Fanta", 70.00f, 100, ETipo.bebible);
            Producto p4 = new Producto("Milanesa", 55.00f, 100, ETipo.comestible);
            Producto p5 = new Producto("Paso de los Toros", 60.00f, 100, ETipo.bebible);
            Producto p6 = new Producto("Cerveza", 80.00f, 100, ETipo.bebible);

            listaProductos.Add(p1);
            listaProductos.Add(p2);
            listaProductos.Add(p3);
            listaProductos.Add(p4);
            listaProductos.Add(p5);
            listaProductos.Add(p6);

        }

        private static void HarcodeoMesas()
        {
            mesasDelSalon = new Mesa[20];

            Mesa mesa1 = new Mesa(1, new List<Consumo>(), true, 00.0f);
            Mesa mesa2 = new Mesa(2, new List<Consumo>(), true, 00.0f);
            Mesa mesa3 = new Mesa(3, new List<Consumo>(), false, 00.0f);
            Mesa mesa4 = new Mesa(4, new List<Consumo>(), true, 00.0f);
            Mesa mesa5 = new Mesa(5, new List<Consumo>(), false, 00.0f);
            Mesa mesa6 = new Mesa(6, new List<Consumo>(), true, 00.0f);
            Mesa mesa7 = new Mesa(7, new List<Consumo>(), true, 00.0f);
            Mesa mesa8 = new Mesa(8, new List<Consumo>(), true, 00.0f);
            Mesa mesa9 = new Mesa(9, new List<Consumo>(), true, 00.0f);
            Mesa mesa10 = new Mesa(10, new List<Consumo>(), true, 00.0f);
            Mesa mesa11 = new Mesa(11, new List<Consumo>(), true, 00.0f);
            Mesa mesa12 = new Mesa(12, new List<Consumo>(), true, 00.0f);
            Mesa mesa13 = new Mesa(13, new List<Consumo>(), true, 00.0f);
            Mesa mesa14 = new Mesa(14, new List<Consumo>(), true, 00.0f);
            Mesa mesa15 = new Mesa(15, new List<Consumo>(), true, 00.0f);
            Mesa mesa16 = new Mesa(16, new List<Consumo>(), true, 00.0f);
            Mesa mesa17 = new Mesa(17, new List<Consumo>(), true, 00.0f);
            Mesa mesa18 = new Mesa(18, new List<Consumo>(), true, 00.0f);
            Mesa mesa19 = new Mesa(19, new List<Consumo>(), true, 00.0f);
            Mesa mesa20 = new Mesa(20, new List<Consumo>(), true, 00.0f);

            mesasDelSalon[0] = mesa1;
            mesasDelSalon[1] = mesa2;
            mesasDelSalon[2] = mesa3;
            mesasDelSalon[3] = mesa4;
            mesasDelSalon[4] = mesa5;
            mesasDelSalon[5] = mesa6;
            mesasDelSalon[6] = mesa7;
            mesasDelSalon[7] = mesa8;
            mesasDelSalon[8] = mesa9;
            mesasDelSalon[9] = mesa10;
            mesasDelSalon[10] = mesa11;
            mesasDelSalon[11] = mesa12;
            mesasDelSalon[12] = mesa13;
            mesasDelSalon[13] = mesa14;
            mesasDelSalon[14] = mesa15;
            mesasDelSalon[15] = mesa16;
            mesasDelSalon[16] = mesa17;
            mesasDelSalon[17] = mesa18;
            mesasDelSalon[18] = mesa19;
            mesasDelSalon[19] = mesa20;
        }

        private static void DiccionarioProductos()
        {
            KeysProductos = new Dictionary<string, int>();
            KeysProductos.Add("Pepsi", 1);
            KeysProductos.Add("Fanta", 2);
            KeysProductos.Add("Milanesa", 3);
            KeysProductos.Add("Paso de los Toros", 4);
            KeysProductos.Add("Cerveza", 5);
        }



        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
        }

        public static List<Usuarios> ListaUsuarios
        {
            get { return listaUsuarios; }
        }

        public static Mesa[] ArrayMesas
        {
            get { return mesasDelSalon; }
        }

        public static Dictionary<string, int> KeysProductos { get => keysProductos; set => keysProductos = value; }

        public static void AgregarProductoALaLista(Producto producto)
        {
            if (producto is not null)
            {
                listaProductos.Add(producto);
            }
        }

        public static void EliminarProductoDeLista(Producto producto)
        {
            if (producto is not null)
            {
                listaProductos.Remove(producto);
            }
        }

        public static void AgreagarProducAlDiccionario(int id, string nombre)
        {
            KeysProductos.Add(nombre, id);
        }




        public static void AgregarEmpleadoALaLista(Empleado empleado)
        {
            if (empleado is not null)
            {
                listaUsuarios.Add(empleado);
            }
        }




        public static List<int> RetornarNºMesasVacias(Mesa[] mesasDelSalon)
        {

            List<int> mesasDisp = new List<int>();

            for (int i = 0; i < mesasDelSalon.Length; i++)
            {
                if (mesasDelSalon[i].Consumos == null)
                {
                    mesasDisp.Add(i + 1);
                }
            }
            return mesasDisp;

        }








        //public static Usuarios BuscarUsuario(string usuario, string pass)
        //{


        //    foreach (var usuarioRegistrado in listaEmpleados)
        //    {
        //        if (usuarioRegistrado.NombreUsuario == usuario && usuarioRegistrado.Pass == pass)
        //        {

        //            return usuarioRegistrado;
        //        }

        //    }

        //    return null;
        //}



        public static List<Usuarios> ListarSegunTipo(int tipo)
        {
            List<Usuarios> listaRetornada = new List<Usuarios>();

            if (tipo == 1)
            {
                foreach (var admin in listaUsuarios)
                {
                    if (admin.EsAdministrador == true)
                    {
                        listaRetornada.Add(admin);
                    }
                }
            }
            if (tipo == 2)
            {
                foreach (var empleado in listaUsuarios)
                {
                    if (empleado.EsAdministrador == false)
                    {
                        listaRetornada.Add(empleado);
                    }
                }
            }

            return listaRetornada;
        }



        //public static void AgregarPedidoAlaMesa (int id,)
        //{
        //    listaMesas[id] = mesa;

        //}



    }//end class
}//end namespace
