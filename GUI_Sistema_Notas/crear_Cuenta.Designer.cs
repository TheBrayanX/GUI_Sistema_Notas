namespace GUI_Sistema_Notas
{
    partial class crear_Cuenta
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
            this.txtcc = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(107, 123);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(176, 23);
            this.txtcc.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(107, 190);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(176, 23);
            this.txtname.TabIndex = 1;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(107, 261);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(176, 23);
            this.txtapellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sugar Snow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(84, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "CREAR CUENTA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREAR CUENTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite tu número de documento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digita tu nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digita tu apellido:";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(107, 330);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(176, 23);
            this.txtpassword.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Digita una contraseña: ";
            // 
            // crear_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcc);
            this.Name = "crear_Cuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.crear_Cuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtcc;
        private TextBox txtname;
        private TextBox txtapellido;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtpassword;
        private Label label6;
    }
}