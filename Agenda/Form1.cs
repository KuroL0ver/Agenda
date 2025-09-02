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
                //Lee solo las l�neas del encabezado 
                //Es un arreglo de strings
                string[] datos = File.ReadAllLines(@"Datos\Personas.csv");
                //Muestra la primera l�nea del archivo (Nombre, Apellido, Email)
                //Si cambias el [0] por [1] muestra la segunda l�nea (Que ser�a el primer contacto)
                MessageBox.Show(datos[0]);
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
