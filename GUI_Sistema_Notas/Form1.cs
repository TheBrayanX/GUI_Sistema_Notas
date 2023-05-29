namespace GUI_Sistema_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Cierra la pestaña.
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se llama la ventana.
            crear_Cuenta cc = new crear_Cuenta();
            cc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se llama la ventana.
            iniciar_Sesion ii = new iniciar_Sesion();
            ii.Show();
        }
    }
}