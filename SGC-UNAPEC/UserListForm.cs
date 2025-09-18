using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_UNAPEC
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
            userListDgv.CellMouseEnter += UserListDgv_CellMouseEnter;
            userListDgv.CellMouseLeave += UserListDgv_CellMouseLeave;
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            if (DBConnection.con.State == ConnectionState.Closed)
            {
                DBConnection.con.Open();
            }


            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            string query = @"
            SELECT 
                id AS 'ID', 
                nombre AS 'Nombre', 
                cedula AS 'Cédula', 
                tipo_usuario AS 'Rol',
                limite_credito AS 'Límite de Crédito',
                clave AS 'Contraseña',
                CASE 
                    WHEN estado = 1 THEN 'Activo'
                    WHEN estado = 0 THEN 'Inactivo'
                    ELSE 'Desconocido'
                END AS 'Estado'
                fecha_registro AS 'Fecha de Registro',
                fecha_modificacion AS 'Fecha de Modificación'
            FROM usuarios";

            using (SqlCommand command = new SqlCommand(query, DBConnection.con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    userListDgv.DataSource = dt;
                    userListDgv.Columns["ID"].Visible = false;
                    userListDgv.Columns["Nombre"].DisplayIndex = 0;
                    userListDgv.Columns["Cédula"].DisplayIndex = 1;
                    userListDgv.Columns["Rol"].DisplayIndex = 2;
                    userListDgv.Columns["Límite de Crédito"].DisplayIndex = 3;
                    userListDgv.Columns["Contraseña"].DisplayIndex = 4;
                    userListDgv.Columns["Estado"].DisplayIndex = 5;
                    userListDgv.Columns["Fecha de Registro"].DisplayIndex = 6;
                    userListDgv.Columns["Fecha de Modificación"].DisplayIndex = 7;
                    userListDgv.Columns["Editar"].DisplayIndex = 3;
                    userListDgv.Columns["Eliminar"].DisplayIndex = 4;
                }
            }
        }

        private void crearUserListFormBtn_Click(object sender, EventArgs e)
        {
            using (UserCreateForm createForm = new UserCreateForm(this))
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
        }

        private void refrescarUserListFormBtn_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void userListDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userListDgv.Columns[e.ColumnIndex].Name == "Editar")
            {
                // Obtener el índice de la fila
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    // Capturar los datos de la fila seleccionada
                    int id = Convert.ToInt32(userListDgv.Rows[rowIndex].Cells["ID"].Value);
                    string nombre = userListDgv.Rows[rowIndex].Cells["Nombre"].Value.ToString();
                    string cedula = userListDgv.Rows[rowIndex].Cells["Cédula"].Value.ToString();
                    string rol = userListDgv.Rows[rowIndex].Cells["Rol"].Value.ToString();
                    string limiteCredito = userListDgv.Rows[rowIndex].Cells["Límite de Crédito"].Value.ToString();
                    string clave = userListDgv.Rows[rowIndex].Cells["Contraseña"].Value.ToString();
                    string estado = userListDgv.Rows[rowIndex].Cells["Estado"].Value.ToString();
                    bool estadoBoolean = estado == "Activo";

                    // Abrir formulario de edición con los datos
                    using (UserEditForm editForm = new UserEditForm(id, nombre, cedula, rol, limiteCredito, clave, estadoBoolean, this))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            // Recargar la lista después de la edición
                            CargarUsuarios();
                        }
                    }
                }
            }
            else if (userListDgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    int id = Convert.ToInt32(userListDgv.Rows[rowIndex].Cells["ID"].Value);
                    string nombre = userListDgv.Rows[rowIndex].Cells["Nombre"].Value.ToString();

                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro que desea eliminar el usuario '{nombre}'?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string query = "DELETE FROM usuarios WHERE id = @Id";
                            using (SqlCommand cmd = new SqlCommand(query, DBConnection.con))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Usuario eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarUsuarios();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void UserListDgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (userListDgv.Columns[e.ColumnIndex].Name == "Editar" ||
                                   userListDgv.Columns[e.ColumnIndex].Name == "Eliminar"))
            {
                this.Cursor = Cursors.Hand;
            }
        }

        private void UserListDgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
