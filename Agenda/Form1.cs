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
                string[] datos = File.ReadAllLines(@"Datos\Personas.csv");
                //Muestra la primera línea del archivo (Nombre, Apellido, Email)
                //Si cambias el [0] por [1] muestra la segunda línea (Que sería el primer contacto)
                MessageBox.Show(datos[0]);
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
