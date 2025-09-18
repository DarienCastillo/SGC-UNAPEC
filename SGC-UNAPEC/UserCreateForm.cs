using System.Data;
using Microsoft.Data.SqlClient;

namespace SGC_UNAPEC
{
    public partial class UserCreateForm : Form
    {
        private UserListForm _userListForm;

        public UserCreateForm(UserListForm userListForm)
        {
            InitializeComponent();
            _userListForm = userListForm;
        }

        private void estadoUserCreateFormCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (estadoUserCreateFormCheck.Checked)
            {
                estadoUserCreateFormCheck.Content = "Activo";
            }
            else
            {
                estadoUserCreateFormCheck.Content = "Inactivo";
            }
        }

        private void limpiarUserCreateFormBtn_Click(object sender, EventArgs e)
        {
            nombreUserCreateFormTxt.Content = "";
            cedulaUserCreateFormTxt.Content = "";
            rolUserCreateFormCombo.SelectedItem = null;
            limiteCreditoUserCreateFormTxt.Content = "";
            contraseñaUserCreateFormTxt.Content = "";
            confirmarContraseñaUserCreateFormTxt.Content = "";
            estadoUserCreateFormCheck.Checked = true;
        }

        private void crearUserCreateFormBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreUserCreateFormTxt.Content) || 
                string.IsNullOrWhiteSpace(cedulaUserCreateFormTxt.Content) || 
                string.IsNullOrWhiteSpace(rolUserCreateFormCombo.SelectedItem) || 
                string.IsNullOrWhiteSpace(limiteCreditoUserCreateFormTxt.Content) || 
                string.IsNullOrWhiteSpace(contraseñaUserCreateFormTxt.Content) || 
                string.IsNullOrWhiteSpace(confirmarContraseñaUserCreateFormTxt.Content)
                )
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DBConnection.con.State == ConnectionState.Closed)
            {
                DBConnection.con.Open();
            }

            InsertarUsuario();
        }

        private void InsertarUsuario()
        {
            try
            {
                if (contraseñaUserCreateFormTxt.Content != confirmarContraseñaUserCreateFormTxt.Content)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query = @"
                INSERT INTO usuarios (nombre, cedula, tipo_usuario, limite_credito, clave, estado, fecha_registro, fecha_modificacion)
                VALUES (@nombre, @cedula, @tipo_usuario, @limite_credito, @clave, @estado, GETDATE(), GETDATE())";
                using (SqlCommand command = new SqlCommand(query, DBConnection.con))
                {
                    command.Parameters.AddWithValue("@nombre", nombreUserCreateFormTxt.Content);
                    command.Parameters.AddWithValue("@cedula", cedulaUserCreateFormTxt.Content);
                    command.Parameters.AddWithValue("@tipo_usuario", rolUserCreateFormCombo.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@limite_credito", decimal.Parse(limiteCreditoUserCreateFormTxt.Content));
                    command.Parameters.AddWithValue("@clave", contraseñaUserCreateFormTxt.Content);
                    command.Parameters.AddWithValue("@estado", estadoUserCreateFormCheck.Checked ? 1 : 0);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _userListForm.CargarUsuarios();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        rolUserCreateFormCombo.SelectedItem = null;
                        while (reader.Read())
                        {
                            rolUserCreateFormCombo.Items.Append(reader["rol"].ToString());
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
