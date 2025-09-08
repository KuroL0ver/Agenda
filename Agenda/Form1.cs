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
                List<Contacto> contactos = new List<Contacto>();

                bool esEncabezado = true;
                foreach (string renglon in renglones)
                {
                    if (esEncabezado == true)
                    {
                        esEncabezado = false;
                        continue;
                    }
                    //El split sirve para acomodar los renglones en columnas
                    string[] columnas = renglon.Split(',');
                    Contacto contacto = new Contacto();
                    contacto.Nombre = columnas[0];
                    contacto.Apellido = columnas[1];
                    contacto.Email = columnas[2];

                    contactos.Add(contacto);
                }
                DgvContactos.DataSource = contactos;
            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
