using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Formularios
{
    public partial class Salon : Form
    {

        Mesa[] mesasDelBar = Bar.ArrayMesas;

        List<Producto> listaProductos = Bar.ListaProductos;
        Dictionary<int, Button> botonesParaCadaMesa = new Dictionary<int, Button>();

        Dictionary<int, Mesa> numeromesa = new Dictionary<int, Mesa>();

        public Salon()
        {
            InitializeComponent();
            AsociarBotones();
            AsociarMesas();
           

        }

        private void Salon_Load(object sender, EventArgs e)
        {
            EstadoDeLasMesas();
        }

        private void EstadoDeLasMesas()
        {
            for (int i = 0 + 1; i < mesasDelBar.Length; i++)
            {
                if (mesasDelBar[i].Disponiblidad is true)
                {
                    botonesParaCadaMesa[i].BackColor = Color.Green;
                }
                else
                {
                    botonesParaCadaMesa[i].BackColor = Color.Red;
                }
            }
        }

        private void AsociarBotones()
        {
            botonesParaCadaMesa.Add(1, this.btnMesa1);
            botonesParaCadaMesa.Add(2, this.btnMesa2);
            botonesParaCadaMesa.Add(3, this.btnMesa3);
            botonesParaCadaMesa.Add(4, this.btnMesa4);
            botonesParaCadaMesa.Add(5, this.btnMesa5);
            botonesParaCadaMesa.Add(6, this.btnMesa6);
            botonesParaCadaMesa.Add(7, this.btnMesa7);
            botonesParaCadaMesa.Add(8, this.btnMesa8);
            botonesParaCadaMesa.Add(9, this.btnMesa9);
            botonesParaCadaMesa.Add(10, this.btnMesa10);
            botonesParaCadaMesa.Add(11, this.btnMesa11);
            botonesParaCadaMesa.Add(12, this.btnMesa12);
            botonesParaCadaMesa.Add(13, this.btnMesa13);
            botonesParaCadaMesa.Add(14, this.btnMesa14);
            botonesParaCadaMesa.Add(15, this.btnMesa15);
            botonesParaCadaMesa.Add(16, this.btnMesa16);
            botonesParaCadaMesa.Add(17, this.btnMesa17);
            botonesParaCadaMesa.Add(18, this.btnMesa18);
            botonesParaCadaMesa.Add(19, this.btnMesa19);
            botonesParaCadaMesa.Add(20, this.btnMesa20);
        }
        private void AsociarMesas()
        {

            numeromesa.Add(1, mesasDelBar[0]);
            numeromesa.Add(2, mesasDelBar[1]);
            numeromesa.Add(3, mesasDelBar[2]);
            numeromesa.Add(4, mesasDelBar[3]);
            numeromesa.Add(5, mesasDelBar[4]);
            numeromesa.Add(6, mesasDelBar[5]);
            numeromesa.Add(7, mesasDelBar[6]);
            numeromesa.Add(8, mesasDelBar[7]);
            numeromesa.Add(9, mesasDelBar[8]);
            numeromesa.Add(10, mesasDelBar[9]);
            numeromesa.Add(11, mesasDelBar[10]);
            numeromesa.Add(12, mesasDelBar[11]);
            numeromesa.Add(13, mesasDelBar[12]);
            numeromesa.Add(14, mesasDelBar[13]);
            numeromesa.Add(15, mesasDelBar[14]);
            numeromesa.Add(16, mesasDelBar[15]);
            numeromesa.Add(17, mesasDelBar[16]);
            numeromesa.Add(18, mesasDelBar[17]);
            numeromesa.Add(19, mesasDelBar[18]);
            numeromesa.Add(20, mesasDelBar[19]);
        }



        private List<Producto> ProductosDisponibles(int nmesa)
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
                foreach (Producto pr in Bar.ListaProductos)
                {
                    cmbProductos.Items.Add(pr.Nombre);
                }
            }
            return listAux;
        }
        #region


        private void CalcularPrecios()
        {
            int c = Convert.ToInt32(cmbCantidad.SelectedItem);
            string p = (string)cmbProductos.SelectedItem;

            Producto prod = Consumo.ProductoSeleccionado(p);
            float precio = prod.ValorXUnidad;
            float final = precio * c;
            lblReferenciaValorIndicativo.Text = final.ToString();
        }





        #endregion


        private void cmbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }
        private void cmbCantidad_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int m=Convert.ToInt32(lblMesaOrientativo.Text);
            int c = Convert.ToInt32(cmbCantidad.SelectedItem);

            string pr =cmbProductos.SelectedItem.ToString();
            Producto prodSel= Producto.ProductoSeleccionado(pr);
            float PrecioTotal = prodSel.ValorXUnidad * c;
            numeromesa[m].TotaldelaCuenta = PrecioTotal;
           
            Consumo consumicion = new Consumo(c,pr,prodSel.ValorXUnidad,PrecioTotal);

           

            numeromesa[m].Consumos.Add(consumicion);

            lstBoxPedidosCargados.Items.Clear();
            foreach (var item in numeromesa[m].Consumos)
            {
                lstBoxPedidosCargados.Items.Add(item.MostrarConsumoEnDetalle());
            }
            float precioConsumido = numeromesa[m].TotaldelaCuenta;
            foreach (var item in numeromesa[m].Consumos)
            {

               precioConsumido+= item.PrecioXConsumo; 
            }

            lblTotalConsumido.Text = precioConsumido.ToString();
            MessageBox.Show($" {numeromesa[m].Consumos.Count}");
         

         
            //Consumo consumicion = new Consumo(c, p);
            //consumos.Add(consumicion);

            

          


        }



        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            int.TryParse(lblMesaOrientativo.Text, out int m);


            numeromesa[m].Disponiblidad = true;
            numeromesa[m].Consumos = null;
            numeromesa[m].TotaldelaCuenta = 00.0f;

            botonesParaCadaMesa[m].BackColor = Color.Green;
            lstBoxPedidosCargados.Items.Clear();
            lblTotalConsumido.Text = "";
        }

        #region EventosClick  de cada Mesa
        private void btnMesa1_MouseClick(object sender, MouseEventArgs e)
        {
            int m = 1;
            

            lblMesaOrientativo.Text = m.ToString();
            
        }
        private void btnMesa2_MouseClick(object sender, MouseEventArgs e)
        {
            int m = 2;
            numeromesa[m]
            lblMesaOrientativo.Text = m.ToString();
        }


        private void btnMesa19_MouseClick(object sender, MouseEventArgs e)
        {
            int m = 19;
            lblMesaOrientativo.Text = m.ToString();
        }
        #endregion



        private void lblMesaOrientativo_TextChanged(object sender, EventArgs e)
        {
            cmbProductos.Items.Clear();
            int m = Convert.ToInt32(lblMesaOrientativo.Text);
            List<Producto> lispr = Producto.ProductosDisponibles(m);


            EstadoDeLasMesas();

            foreach (var item in lispr)
            {
                cmbProductos.Items.Add(item.Nombre);
            }

            if (numeromesa[m].Consumos.Count ==0 )
            {
                lstBoxPedidosCargados.Items.Clear();
                lstBoxPedidosCargados.Items.Add("/Indicar Pedido/");

            }
            else
            {
                

                foreach (var item in numeromesa[m].Consumos) 
                {
                    lstBoxPedidosCargados.Items.Add(item.MostrarConsumoEnDetalle());
                }  
            }

           
            
             lblTotalConsumido.Text = ($" {numeromesa[m].TotaldelaCuenta}");
                   


        }


        
    }
}


















