
namespace AsisMed
{
    partial class DatosUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuario2 = new System.Windows.Forms.Label();
            this.lblContrasenia2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblApePaterno = new System.Windows.Forms.Label();
            this.lblApeMaterno = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Materno:";
            // 
            // lblUsuario2
            // 
            this.lblUsuario2.AutoSize = true;
            this.lblUsuario2.Location = new System.Drawing.Point(133, 23);
            this.lblUsuario2.Name = "lblUsuario2";
            this.lblUsuario2.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario2.TabIndex = 5;
            this.lblUsuario2.Text = "Usuario";
            // 
            // lblContrasenia2
            // 
            this.lblContrasenia2.AutoSize = true;
            this.lblContrasenia2.Location = new System.Drawing.Point(133, 54);
            this.lblContrasenia2.Name = "lblContrasenia2";
            this.lblContrasenia2.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia2.TabIndex = 6;
            this.lblContrasenia2.Text = "Contraseña";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(133, 86);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(44, 13);
            this.lblNombre2.TabIndex = 7;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblApePaterno
            // 
            this.lblApePaterno.AutoSize = true;
            this.lblApePaterno.Location = new System.Drawing.Point(133, 121);
            this.lblApePaterno.Name = "lblApePaterno";
            this.lblApePaterno.Size = new System.Drawing.Size(63, 13);
            this.lblApePaterno.TabIndex = 8;
            this.lblApePaterno.Text = "ApePaterno";
            // 
            // lblApeMaterno
            // 
            this.lblApeMaterno.AutoSize = true;
            this.lblApeMaterno.Location = new System.Drawing.Point(133, 156);
            this.lblApeMaterno.Name = "lblApeMaterno";
            this.lblApeMaterno.Size = new System.Drawing.Size(65, 13);
            this.lblApeMaterno.TabIndex = 9;
            this.lblApeMaterno.Text = "ApeMaterno";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(101, 191);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // DatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 239);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblApeMaterno);
            this.Controls.Add(this.lblApePaterno);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblContrasenia2);
            this.Controls.Add(this.lblUsuario2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblUsuario2;
        public System.Windows.Forms.Label lblContrasenia2;
        public System.Windows.Forms.Label lblNombre2;
        public System.Windows.Forms.Label lblApePaterno;
        public System.Windows.Forms.Label lblApeMaterno;
    }
}