
namespace Formularios
{
    partial class GestionDeEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarNuevoEmpleado = new System.Windows.Forms.Button();
            this.dgvTablaEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de empleados";
            // 
            // btnAgregarNuevoEmpleado
            // 
            this.btnAgregarNuevoEmpleado.Location = new System.Drawing.Point(45, 240);
            this.btnAgregarNuevoEmpleado.Name = "btnAgregarNuevoEmpleado";
            this.btnAgregarNuevoEmpleado.Size = new System.Drawing.Size(161, 23);
            this.btnAgregarNuevoEmpleado.TabIndex = 2;
            this.btnAgregarNuevoEmpleado.Text = "Agregar nuevo empleado";
            this.btnAgregarNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoEmpleado.Click += new System.EventHandler(this.btnAgregarNuevoEmpleado_Click);
            // 
            // dgvTablaEmpleados
            // 
            this.dgvTablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaEmpleados.Location = new System.Drawing.Point(198, 44);
            this.dgvTablaEmpleados.Name = "dgvTablaEmpleados";
            this.dgvTablaEmpleados.RowTemplate.Height = 25;
            this.dgvTablaEmpleados.Size = new System.Drawing.Size(519, 151);
            this.dgvTablaEmpleados.TabIndex = 3;
       
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTablaEmpleados);
            this.Controls.Add(this.btnAgregarNuevoEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarNuevoEmpleado;
        private System.Windows.Forms.DataGridView dgvTablaEmpleados;
    }
}