using Xamarin.Forms;

namespace TuProyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GuardarDatos(object sender, System.EventArgs e)
        {
            string nombre = nombreEntry.Text;
            string apellido = apellidoEntry.Text;
            string fechaNacimiento = fechaNacimientoEntry.Text;
            string correo = correoEntry.Text;
            string telefono = telefonoEntry.Text;
            string dni = dniEntry.Text;

            
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(fechaNacimiento) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(dni))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            // Navegar a la página de currículum vitae y pasar los datos
            Navigation.PushAsync(new CvPage(nombre, apellido, fechaNacimiento, correo, telefono, dni));
        }
    }
}
