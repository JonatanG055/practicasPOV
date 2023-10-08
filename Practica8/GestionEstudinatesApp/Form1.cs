using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionEstudinatesApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=JONATAN\\SQLEXPRESS;Initial Catalog=GestionEstudiantes;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Nombre, Codigo, Telefono, Ciudad FROM Estudiantes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewEstudiantes.DataSource = dataTable;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEstudiante();
        }

        private void AgregarEstudiante()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Estudiantes (Nombre, Codigo, Telefono, Ciudad) " +
                                   "VALUES (@Nombre, @Codigo, @Telefono, @Ciudad)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Codigo", txtCodigo.Text); 
                    command.Parameters.AddWithValue("@Telefono",txtTelefono.Text); 
                    command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        CargarEstudiantes();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEstudiante();
        }

        private void EditarEstudiante()
        {
            int rowIndex = dataGridViewEstudiantes.CurrentCell.RowIndex;

            if (rowIndex >= 0)
            {
                int estudianteId = (int)dataGridViewEstudiantes.Rows[rowIndex].Cells["Id"].Value;

                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEstudiante();
        }

        private void EliminarEstudiante()
        {
            int rowIndex = dataGridViewEstudiantes.CurrentCell.RowIndex;

            if (rowIndex >= 0)
            {
                int estudianteId = (int)dataGridViewEstudiantes.Rows[rowIndex].Cells["Id"].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Estudiantes WHERE Id = @EstudianteId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EstudianteId", estudianteId);

                    command.ExecuteNonQuery();

                    CargarEstudiantes();
                }
            }
        }

        private void LimpiarCampos()
        {
            // Limpia los campos de entrada de texto después de agregar un estudiante.
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
