
using System.Data;

namespace SGC_UNAPEC
{
    public partial class RolEditForm : Form
    {
        private int _id;
        private RolListForm _rolListForm;

        public RolEditForm(int id, string rol, string descripcion, bool estadoBoolean, RolListForm rolListForm)
        {
            InitializeComponent();
            _id = id;
            _rolListForm = rolListForm;

            rolTxt.Content = rol;
            descTxt.Content = descripcion;
            estadoRoleEditFormCheck.Checked = estadoBoolean;
        }

        private void editarRolEditFormBtn_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(rolTxt.Content) || string.IsNullOrWhiteSpace(descTxt.Content))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DBConnection.con.State == ConnectionState.Closed)
                {
                    DBConnection.con.Open();
                }

                ActualizarRol();
            }
        }

        private void ActualizarRol()
        {
            rolTxt.Content = rolTxt.Content.Trim();
            descTxt.Content = descTxt.Content.Trim();
            int estado = estadoRoleEditFormCheck.Checked ? 1 : 0;

            try
            {
                using (var command = new Microsoft.Data.SqlClient.SqlCommand())
                {
                    command.Connection = DBConnection.con;
                    command.CommandText = @"
                        UPDATE tipo_usuarios 
                        SET tipo_usuario = @tipo_usuario, 
                            descripcion = @descripcion, 
                            estado = @estado
                        WHERE ID = @id";

                    command.Parameters.AddWithValue("@tipo_usuario", rolTxt.Content);
                    command.Parameters.AddWithValue("@descripcion", descTxt.Content);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@id", _id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rol actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _rolListForm.CargarRoles(); // Recargar la lista de roles
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el rol. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void estadoRoleEditFormCheck_CheckedChanged(object sender, EventArgs e)
        {
            estadoRoleEditFormCheck.Content = estadoRoleEditFormCheck.Checked ? "Activo" : "Inactivo";
        }
    }

}
