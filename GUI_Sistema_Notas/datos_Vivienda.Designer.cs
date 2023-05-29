namespace GUI_Sistema_Notas
{
    partial class datos_Vivienda
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthogar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.enviar_datos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sugar Snow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(166, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATOS VIVIENDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digita tu dirección:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(70, 98);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(176, 23);
            this.txtdireccion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Escribe tu telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(335, 98);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(176, 23);
            this.txttelefono.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de hogar (Apto, Casa,)";
            // 
            // txthogar
            // 
            this.txthogar.Location = new System.Drawing.Point(70, 179);
            this.txthogar.Name = "txthogar";
            this.txthogar.Size = new System.Drawing.Size(176, 23);
            this.txthogar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Localidad:";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Location = new System.Drawing.Point(328, 179);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(176, 23);
            this.txtlocalidad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Barrio:";
            // 
            // txtbarrio
            // 
            this.txtbarrio.Location = new System.Drawing.Point(199, 274);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(176, 23);
            this.txtbarrio.TabIndex = 16;
            // 
            // enviar_datos
            // 
            this.enviar_datos.Location = new System.Drawing.Point(226, 351);
            this.enviar_datos.Name = "enviar_datos";
            this.enviar_datos.Size = new System.Drawing.Size(122, 47);
            this.enviar_datos.TabIndex = 18;
            this.enviar_datos.Text = "ENVIAR DATOS";
            this.enviar_datos.UseVisualStyleBackColor = true;
            this.enviar_datos.Click += new System.EventHandler(this.enviar_datos_Click);
            // 
            // datos_Vivienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 427);
            this.Controls.Add(this.enviar_datos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbarrio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label1);
            this.Name = "datos_Vivienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar datos adicionales";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtdireccion;
        private Label label2;
        private TextBox txttelefono;
        private Label label4;
        private TextBox txthogar;
        private Label label5;
        private TextBox txtlocalidad;
        private Label label6;
        private TextBox txtbarrio;
        private Button enviar_datos;
    }
}