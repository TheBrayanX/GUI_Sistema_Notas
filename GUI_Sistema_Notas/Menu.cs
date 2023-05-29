using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Sistema_Notas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Salir de la pestaña.
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instancia que se abre una pestaña y se cierra la actual cuando se le da click al botón.
            definitiva_Final df = new definitiva_Final();
            df.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instancia que se abre una pestaña y se cierra la actual cuando se le da click al botón.
            datos_Vivienda dv = new datos_Vivienda();
            dv.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
