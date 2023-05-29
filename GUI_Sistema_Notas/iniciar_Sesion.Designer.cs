namespace GUI_Sistema_Notas
{
    partial class iniciar_Sesion
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
            this.txtcc = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sugar Snow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "INICIO DE SESION";
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(92, 131);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(176, 23);
            this.txtcc.TabIndex = 9;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(92, 198);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(176, 23);
            this.txtpassword.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cedula de Ciudadanía: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "ENTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "OLVIDE MI CONTRASEÑA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.label1);
            this.Name = "iniciar_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.iniciar_Sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtcc;
        private TextBox txtpassword;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}