using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using static UI.FormLoguin;

namespace Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        private bool tipoUSuario = VariablesCompartidas.TipoUsuario;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            DibujarFormPorTipoUSuario(tipoUSuario);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ControlStock stock = new ControlStock();
            stock.Show();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            GestionDeEmpleados formEmpleados = new GestionDeEmpleados();
            formEmpleados.ShowDialog();
        }



        private void AbrirFormHijo(object forHijo)
        {
            if (this.panelContenedor.Controls.Count>0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form frm = forHijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frm);
            this.panelContenedor.Tag = frm;
            frm.Show();

        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Salon()) ;
        }


        private void DibujarFormPorTipoUSuario(bool esAdministrador)
        {
            if (esAdministrador is false)
            {
               this.btnEmpleados.Visible =false;
            }

        }

        #region MoverApp en tiempo de Ejecucion;
        //bool movimiento = true;
        //private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        //{
        //    movimiento = true;
        //}

        //private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (movimiento==true)
        //    {
        //        this.Location = Cursor.Position;
        //    }
        //}

        //private void barraTitulo_MouseUp(object sender, MouseEventArgs e)
        //{
        //    movimiento = false;
        //}
        #endregion

       
    }
}
