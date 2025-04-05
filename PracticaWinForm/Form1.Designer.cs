
namespace PracticaWinForm
{
    partial class practica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.BtnSaludar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelSaludar = new System.Windows.Forms.Label();
            this.labelDire = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.BtnDespedir = new System.Windows.Forms.Button();
            this.labelDespedir = new System.Windows.Forms.Label();
            this.labelDi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(281, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(92, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre y Apellido";
            // 
            // BtnSaludar
            // 
            this.BtnSaludar.Location = new System.Drawing.Point(379, 131);
            this.BtnSaludar.Name = "BtnSaludar";
            this.BtnSaludar.Size = new System.Drawing.Size(75, 23);
            this.BtnSaludar.TabIndex = 1;
            this.BtnSaludar.Text = "Saludar";
            this.BtnSaludar.UseVisualStyleBackColor = true;
            this.BtnSaludar.Click += new System.EventHandler(this.BtnSaludar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(379, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // labelSaludar
            // 
            this.labelSaludar.AutoSize = true;
            this.labelSaludar.Location = new System.Drawing.Point(395, 172);
            this.labelSaludar.Name = "labelSaludar";
            this.labelSaludar.Size = new System.Drawing.Size(0, 13);
            this.labelSaludar.TabIndex = 3;
            // 
            // labelDire
            // 
            this.labelDire.AutoSize = true;
            this.labelDire.Location = new System.Drawing.Point(298, 93);
            this.labelDire.Name = "labelDire";
            this.labelDire.Size = new System.Drawing.Size(52, 13);
            this.labelDire.TabIndex = 4;
            this.labelDire.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(379, 90);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // BtnDespedir
            // 
            this.BtnDespedir.Location = new System.Drawing.Point(379, 230);
            this.BtnDespedir.Name = "BtnDespedir";
            this.BtnDespedir.Size = new System.Drawing.Size(75, 23);
            this.BtnDespedir.TabIndex = 6;
            this.BtnDespedir.Text = "Despedir";
            this.BtnDespedir.UseVisualStyleBackColor = true;
            this.BtnDespedir.Click += new System.EventHandler(this.BtnDespedir_Click);
            // 
            // labelDespedir
            // 
            this.labelDespedir.AutoSize = true;
            this.labelDespedir.Location = new System.Drawing.Point(376, 285);
            this.labelDespedir.Name = "labelDespedir";
            this.labelDespedir.Size = new System.Drawing.Size(0, 13);
            this.labelDespedir.TabIndex = 7;
            // 
            // labelDi
            // 
            this.labelDi.AutoSize = true;
            this.labelDi.Location = new System.Drawing.Point(389, 211);
            this.labelDi.Name = "labelDi";
            this.labelDi.Size = new System.Drawing.Size(0, 13);
            this.labelDi.TabIndex = 8;
            // 
            // practica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDi);
            this.Controls.Add(this.labelDespedir);
            this.Controls.Add(this.BtnDespedir);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.labelDire);
            this.Controls.Add(this.labelSaludar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.BtnSaludar);
            this.Controls.Add(this.labelNombre);
            this.Name = "practica";
            this.Text = "Practica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button BtnSaludar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelSaludar;
        private System.Windows.Forms.Label labelDire;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button BtnDespedir;
        private System.Windows.Forms.Label labelDespedir;
        private System.Windows.Forms.Label labelDi;
    }
}

