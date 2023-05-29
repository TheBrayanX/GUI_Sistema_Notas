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
    public partial class iniciar_Sesion : Form
    {
        public iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void iniciar_Sesion_Load(object sender, EventArgs e)
        {
            //Se encripta la contraseña del TextBox reemplazandose por asterisco, se llama la variable y se concatena la propiedad definiendo el valor.
            txtpassword.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Define la cadena de texto de los TextBox.
            string Cedula = txtcc.Text;
            string password = txtpassword.Text;

            //Se instancia el comando de MySQL con una variable.
            MySqlCommand codigo = new MySqlCommand();
            //Se llama la clase conexión y se crea una variable para que pueda ser manejado.
            MySqlConnection conexionBD = Conexion.conexion();
            //Se abre la conexión.
            conexionBD.Open();
            //Se le dice que el codigo es igual a la conexión de la base de datos.
            codigo.Connection = conexionBD;
            //Dice que el codigo es igual a la cadena de texto que define la consulta.
            codigo.CommandText = "SELECT cedula,contraseña FROM `datos` WHERE cedula='" + Cedula + "' and contraseña='" + password + "'";

            //Se llama el objeto y se instancia como Leer para que ejecute la consulta.
            MySqlDataReader leer = codigo.ExecuteReader();

            //Si la consulta se lee
            if (leer.Read())
            {
                //Se instancia la pestaña Menu y se cierra la actual.
                Menu m = new Menu();
                m.Show();
                this.Close();
            } else
            {
                //Si el usuario esta mal, enviará un aviso.
                MessageBox.Show("Su usuario no está encontrado. ");
            }
            //Se cierra la conexión.
            conexionBD.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se instancia la pestaña de olvidar costeña en caso contrario necesites recuperarla y se cierra la actual.
            olvidar_Contraseña oc = new olvidar_Contraseña();
            oc.Show();
            this.Close();
        }
    }
}
