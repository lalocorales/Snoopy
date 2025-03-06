using Snoopy.Controller;
using Snoopy.Model;
using System.Net;

namespace Snoopy
{
    public partial class Form1 : Form
    {
        private IControllerSnoopy controller = new ControllerSnoopy();
        private List<SnoopyModel> personajes = new List<SnoopyModel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPersonajes();
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            try
            {
                personajes = controller.ObtenerPersonajes(); // Obtener los personajes desde el controlador

                cmbSnoopy.DisplayMember = "Nombre";  // Mostrar el nombre en el ComboBox
                cmbSnoopy.ValueMember = "ImagenURL"; // Guardar la URL de la imagen
                cmbSnoopy.DataSource = personajes;   // Asignar la lista al ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los personajes: " + ex.Message);
            }
        }

        // Evento para cambiar la imagen cuando se seleccione un personaje en el ComboBox



        private async Task CargarImagen(string url)
        {
            try
            {
                // Verificar si la URL es válida antes de hacer la solicitud
                if (string.IsNullOrWhiteSpace(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    throw new Exception("URL de imagen no válida.");
                }

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Verificar si la respuesta fue exitosa (código 200 OK)
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"Error al obtener la imagen. Código HTTP: {response.StatusCode}");
                    }

                    byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                    // Intentar cargar la imagen en el PictureBox
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictoreSnoopy.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error de conexión al obtener la imagen: " + ex.Message);
                pictoreSnoopy.Image = null;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("La imagen descargada no es válida: " + ex.Message);
                pictoreSnoopy.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                pictoreSnoopy.Image = null;
            }
        }



        private void CargarPersonajes()
        {
            try
            {
                dgvPersonajes.DataSource = controller.ObtenerPersonajes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private async void cmbSnoopy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? imageUrl = cmbSnoopy.SelectedValue as string;

            if (!string.IsNullOrEmpty(imageUrl))
            {
                await CargarImagen(imageUrl); // Agregar 'await' para esperar la carga de la imagen
            }
            else
            {
                pictoreSnoopy.Image = null;
            }
        }

    }
}
