using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static UI.FormLoguin;

namespace UI
{
    public partial class frmInformacionMesa : Form
    {
        float consumoTotal = 0.00f;
        string pedidosCargados = "";
        List<Producto> listaProductos = Bar.ListaProductos;
        List<Producto> productosCargados = new List<Producto>();


        private Mesa auxmesa;

        public Mesa GetMesaCargada
        {
            get
            { return auxmesa; }
        }


        Cuenta cuenta = new Cuenta();
        int nMesa = Convert.ToInt32(VariablesCompartidas.NumeroMesa.ToString());

        #region codigoLimpio

        public frmInformacionMesa()
        {
            InitializeComponent();
        }

        private void frmInformacionMesa_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            lblNumMesaOrientativo.Text = nMesa.ToString();
        }


        private void MostrarProductos()
        {
            foreach (Producto pr in Bar.ListaProductos)
            {
                cmbProductos.Items.Add(pr.Nombre);
            }
        }

        private void CalcularPrecios()
        {
            int c = Convert.ToInt32(cmbCantidad.SelectedItem);
            int index = cmbProductos.SelectedIndex;
            float precio = listaProductos[index].ValorXUnidad;
            float final = precio * c;
            lblReferenciaValor.Text = final.ToString();
        }

        private void cmbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void cmbCantidad_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }


        private void checkUsoEstacionamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUsoEstacionamiento.Checked)
            {
                consumoTotal += 500;
            }
            else
            {
                consumoTotal -= 500;
            }
            lblTotalConsumido.Text = consumoTotal.ToString();
        }
        private void checkPagoConTarjeta_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkPagoConTarjeta.Checked)
            {
                consumoTotal = consumoTotal + (consumoTotal * 10 / 100);
            }

            lblTotalConsumido.Text = consumoTotal.ToString();
        }
        #endregion     
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int prodSelec = cmbProductos.SelectedIndex;
            productosCargados.Add(listaProductos[prodSelec]);

            float.TryParse(lblReferenciaValor.Text, out float consumo);
            consumoTotal = consumoTotal + consumo;
            lblTotalConsumido.Text = consumoTotal.ToString();

            pedidosCargados = $"{Convert.ToInt32(cmbCantidad.SelectedItem)} {listaProductos[prodSelec].Nombre}" +
                $" {listaProductos[prodSelec].ValorXUnidad} {lblReferenciaValor.Text}";

            lstBoxPedidosCargados.Items.Add(pedidosCargados);


            //auxmesa = new Mesa(nMesa, consumoTotal, productosCargados, false);


            


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
