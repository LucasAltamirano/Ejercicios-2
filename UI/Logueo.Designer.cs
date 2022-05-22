
namespace UI
{
    partial class FormLoguin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.picBoxBotonApagado = new System.Windows.Forms.PictureBox();
            this.btnRelleano = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBotonApagado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.Location = new System.Drawing.Point(220, 465);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(107, 38);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsuario.Location = new System.Drawing.Point(206, 207);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PlaceholderText = "Usuario";
            this.txbUsuario.Size = new System.Drawing.Size(141, 31);
            this.txbUsuario.TabIndex = 8;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPassword.Location = new System.Drawing.Point(206, 352);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PlaceholderText = "Contraseña";
            this.txbPassword.Size = new System.Drawing.Size(141, 31);
            this.txbPassword.TabIndex = 9;
            // 
            // picBoxBotonApagado
            // 
            this.picBoxBotonApagado.Image = global::UI.Properties.Resources.btnCerrar2;
            this.picBoxBotonApagado.Location = new System.Drawing.Point(1, 690);
            this.picBoxBotonApagado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxBotonApagado.Name = "picBoxBotonApagado";
            this.picBoxBotonApagado.Size = new System.Drawing.Size(63, 58);
            this.picBoxBotonApagado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBotonApagado.TabIndex = 10;
            this.picBoxBotonApagado.TabStop = false;
            this.picBoxBotonApagado.Click += new System.EventHandler(this.picBoxBotonApagado_Click);
            // 
            // btnRelleano
            // 
            this.btnRelleano.Location = new System.Drawing.Point(452, 349);
            this.btnRelleano.Name = "btnRelleano";
            this.btnRelleano.Size = new System.Drawing.Size(112, 34);
            this.btnRelleano.TabIndex = 11;
            this.btnRelleano.Text = "rellenar";
            this.btnRelleano.UseVisualStyleBackColor = true;
            this.btnRelleano.Click += new System.EventHandler(this.btnRelleano_Click);
            // 
            // FormLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::UI.Properties.Resources.loguin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 750);
            this.Controls.Add(this.btnRelleano);
            this.Controls.Add(this.picBoxBotonApagado);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.btnIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueo";
            this.Load += new System.EventHandler(this.FormLoguin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBotonApagado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.PictureBox picBoxBotonApagado;
        private System.Windows.Forms.Button btnRelleano;
    }
}

