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
                //Lee solo las líneas del encabezado 
                //Es un arreglo de strings
                string[] renglones = File.ReadAllLines(@"Datos\Personas.csv");

                bool esContacto = false;
                foreach (string renglon in renglones)
                {
                    if (esContacto == false)
                    {
                        continue;
                    }

                    esContacto = true;
                    MessageBox.Show(renglon);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
