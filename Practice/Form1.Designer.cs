
namespace Practice
{
    partial class Ventana
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
            this.btbSaludar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.labelSaludar = new System.Windows.Forms.Label();
            this.labelDire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btbSaludar
            // 
            this.btbSaludar.Location = new System.Drawing.Point(369, 151);
            this.btbSaludar.Name = "btbSaludar";
            this.btbSaludar.Size = new System.Drawing.Size(75, 23);
            this.btbSaludar.TabIndex = 0;
            this.btbSaludar.Text = "Saludar";
            this.btbSaludar.UseVisualStyleBackColor = true;
            this.btbSaludar.Click += new System.EventHandler(this.btbSaludar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(322, 71);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(311, 116);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(369, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(369, 113);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(100, 20);
            this.txtDire.TabIndex = 4;
            // 
            // labelSaludar
            // 
            this.labelSaludar.AutoSize = true;
            this.labelSaludar.Location = new System.Drawing.Point(369, 201);
            this.labelSaludar.Name = "labelSaludar";
            this.labelSaludar.Size = new System.Drawing.Size(0, 13);
            this.labelSaludar.TabIndex = 5;
            // 
            // labelDire
            // 
            this.labelDire.AutoSize = true;
            this.labelDire.Location = new System.Drawing.Point(372, 235);
            this.labelDire.Name = "labelDire";
            this.labelDire.Size = new System.Drawing.Size(0, 13);
            this.labelDire.TabIndex = 6;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDire);
            this.Controls.Add(this.labelSaludar);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btbSaludar);
            this.Name = "Ventana";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbSaludar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.Label labelSaludar;
        private System.Windows.Forms.Label labelDire;
    }
}

