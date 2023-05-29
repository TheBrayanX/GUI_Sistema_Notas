namespace GUI_Sistema_Notas
{
    partial class olvidar_Contraseña
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_pass1 = new System.Windows.Forms.TextBox();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Digite nueva contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cedula de Ciudadanía: ";
            // 
            // new_pass1
            // 
            this.new_pass1.Location = new System.Drawing.Point(65, 175);
            this.new_pass1.Name = "new_pass1";
            this.new_pass1.Size = new System.Drawing.Size(176, 23);
            this.new_pass1.TabIndex = 15;
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(65, 108);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(176, 23);
            this.txtcc.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sugar Snow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "FORGET MY PASSWORD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // olvidar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_pass1);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.label1);
            this.Name = "olvidar_Contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OLVIDE MI CONTRASEÑA";
            this.Load += new System.EventHandler(this.olvidar_Contraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox new_pass1;
        private TextBox txtcc;
        private Label label1;
        private Button button1;
    }
}