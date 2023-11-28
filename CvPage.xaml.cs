using Xamarin.Forms;

namespace TuProyecto
{
    public partial class CvPage : ContentPage
    {
        public CvPage(string nombre, string apellido, string fechaNacimiento, string correo, string telefono, string dni)
        {
            InitializeComponent();

            nombreLabel.Text = $"Nombre: {nombre}";
            apellidoLabel.Text = $"Apellido: {apellido}";
            fechaNacimientoLabel.Text = $"Fecha de Nacimiento: {fechaNacimiento}";
            correoLabel.Text = $"Correo: {correo}";
            telefonoLabel.Text = $"Teléfono: {telefono}";
            dniLabel.Text = $"DNI: {dni}";
        }
    }
}
