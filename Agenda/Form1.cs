namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCargarContactos_Click(object sender, EventArgs e)
        {
            try
            {
                string datos = System.IO.File.ReadAllText(@"Datos\Personas.csv");
                MessageBox.Show(datos);
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
