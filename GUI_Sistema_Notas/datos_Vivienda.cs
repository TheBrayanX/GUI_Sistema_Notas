using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_Sistema_Notas
{
    public partial class datos_Vivienda : Form
    {
        public datos_Vivienda()
        {
            InitializeComponent();
        }

        private void enviar_datos_Click(object sender, EventArgs e)
        {
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string tipo_hogar = txthogar.Text;
            string localidad = txtlocalidad.Text;
            string barrio = txtbarrio.Text; 
            

            string sql = "INSERT INTO `datos_vivienda` (`Direccion`, `Telefono_Hogar`, `Tipo_Casa`, `Localidad`, `Barrio`) VALUES ('" + direccion + "','" + telefono + "','" + tipo_hogar + "','" + localidad + "', '" + barrio + "');";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand codigo = new MySqlCommand(sql, conexionBD);
                codigo.ExecuteNonQuery();   
                Menu devolver = new Menu();
                devolver.Show();
                this.Close();
                MessageBox.Show("Gracias por los datos, servirán de encuesta.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
