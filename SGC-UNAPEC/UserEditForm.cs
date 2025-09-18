using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace SGC_UNAPEC
{
    public partial class UserEditForm : Form
    {
        private int _id;
        private string _nombre;
        private string _cedula;
        private string _rol;
        private float _limiteCredito;
        private string _clave;
        private bool _estadoBoolean;
        private UserListForm _userListForm;

        public UserEditForm(int id, string nombre, string cedula, string rol, float limiteCredito, bool estadoBoolean, UserListForm userListForm)
        {
            InitializeComponent();
            _id = id;
            _nombre = nombre;
            _cedula = cedula;
            _rol = rol;
            _limiteCredito = limiteCredito;
            _estadoBoolean = estadoBoolean;
            _userListForm = userListForm;

            nombreUserEditFormTxt.Content = _nombre;
            cedulaUserEditFormTxt.Content = _cedula;
            rolUserEditFormCombo.SelectedItem = _rol;
            limiteCreditoUserEditFormTxt.Content = _limiteCredito.ToString();
            estadoUserEditFormCheck.Checked = _estadoBoolean;

        }

        private void editarRolEditFormBtn_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(nombreUserEditFormTxt.Content) ||
                    string.IsNullOrWhiteSpace(cedulaUserEditFormTxt.Content) ||
                    string.IsNullOrWhiteSpace(rolUserEditFormCombo.SelectedItem.ToString()) ||
                    string.IsNullOrWhiteSpace(limiteCreditoUserEditFormTxt.Content) ||
                    string.IsNullOrWhiteSpace(nuevaContraseñaUserEditFormTxt.Content) ||
                    string.IsNullOrWhiteSpace(confirmarContraseñaUserEditFormTxt.Content)
                    )
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DBConnection.con.State == ConnectionState.Closed)
                {
                    DBConnection.con.Open();
                }

                ActualizarUsuario();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public void ActualizarUsuario()
        {
            if (nuevaContraseñaUserEditFormTxt.Content != confirmarContraseñaUserEditFormTxt.Content)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nombreUserEditFormTxt.Content = nombreUserEditFormTxt.Content.Trim();
            cedulaUserEditFormTxt.Content = cedulaUserEditFormTxt.Content.Trim();
            rolUserEditFormCombo.SelectedItem = rolUserEditFormCombo.SelectedItem.ToString().Trim();
            limiteCreditoUserEditFormTxt.Content = limiteCreditoUserEditFormTxt.Content.Trim();
            nuevaContraseñaUserEditFormTxt.Content = nuevaContraseñaUserEditFormTxt.Content.Trim();
            confirmarContraseñaUserEditFormTxt.Content = confirmarContraseñaUserEditFormTxt.Content.Trim();
            int estado = estadoUserEditFormCheck.Checked ? 1 : 0;

            // Hashear la nueva contraseña
            string hashedPassword = HashPassword(nuevaContraseñaUserEditFormTxt.Content);

            try
            {
                using (var command = new Microsoft.Data.SqlClient.SqlCommand())
                {
                    command.Connection = DBConnection.con;
                    command.CommandText = @"
                        UPDATE usuarios 
                        SET nombre = @nombre, 
                            cedula = @cedula, 
                            rol = @rol, 
                            limite_credito = @limite_credito, 
                            clave = @clave, 
                            estado = @estado
                        WHERE ID = @id";
                    command.Parameters.AddWithValue("@nombre", nombreUserEditFormTxt.Content);
                    command.Parameters.AddWithValue("@cedula", cedulaUserEditFormTxt.Content);
                    command.Parameters.AddWithValue("@rol", rolUserEditFormCombo.SelectedItem);
                    command.Parameters.AddWithValue("@limite_credito", limiteCreditoUserEditFormTxt.Content);
                    command.Parameters.AddWithValue("@clave", hashedPassword); // Usar la contraseña hasheada
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@id", _id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Indicar que la operación fue exitosa
                        this.Close(); // Cerrar el formulario
                        _userListForm.CargarUsuarios(); // Refrescar la lista de usuarios en el formulario principal
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarRoles()
        {
            try
            {
                if (DBConnection.con.State == ConnectionState.Closed)
                {
                    DBConnection.con.Open();
                }
                string query = "SELECT tipo_usuario FROM tipo_usuarios WHERE estado = 1";
                using (SqlCommand command = new SqlCommand(query, DBConnection.con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        rolUserEditFormCombo.Refresh(); // Limpia antes de agregar
                        while (reader.Read())
                        {
                            rolUserEditFormCombo.AddItem(reader["tipo_usuario"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
