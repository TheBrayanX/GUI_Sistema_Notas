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

namespace GUI_Sistema_Notas
{
    public partial class olvidar_Contraseña : Form
    {
        public olvidar_Contraseña()
        {
            InitializeComponent();
        }

        private void olvidar_Contraseña_Load(object sender, EventArgs e)
        {
            new_pass1.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            String cedula = txtcc.Text;
            String nueva_contraseña = new_pass1.Text;

            string SQL = "UPDATE `datos` SET `contraseña` = '"+nueva_contraseña+"' WHERE `datos`.`cedula` = '"+cedula+"';";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand codigo = new MySqlCommand(SQL, conexionBD);
                codigo.ExecuteNonQuery();
                iniciar_Sesion devolver = new iniciar_Sesion();
                devolver.Show();
                this.Close();
                MessageBox.Show("Has modificado tu contraseña.");
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conexionBD.Close(); 
            }
        }
    }
}
