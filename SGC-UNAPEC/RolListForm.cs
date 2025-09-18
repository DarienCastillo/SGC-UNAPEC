using System.Data;
using Microsoft.Data.SqlClient;

namespace SGC_UNAPEC
{
    public partial class RolListForm : Form
    {
        public RolListForm()
        {
            InitializeComponent();
            rolListDgv.CellMouseEnter += RolListDgv_CellMouseEnter;
            rolListDgv.CellMouseLeave += RolListDgv_CellMouseLeave;

        }

        private void RolFormList_Load(object sender, EventArgs e)
        {
            if (DBConnection.con.State == ConnectionState.Closed)
            {
                DBConnection.con.Open();
            }


            CargarRoles();
        }

        public void CargarRoles()
        {
            string query = @"
    SELECT 
        id AS 'ID', 
        tipo_usuario AS 'Rol', 
        descripcion AS 'Descripción', 
        CASE 
            WHEN estado = 1 THEN 'Activo'
            WHEN estado = 0 THEN 'Inactivo'
            ELSE 'Desconocido'
        END AS 'Estado'
    FROM tipo_usuarios";

            using (SqlCommand command = new SqlCommand(query, DBConnection.con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    rolListDgv.DataSource = dt;
                    rolListDgv.Columns["ID"].Visible = false;
                    rolListDgv.Columns["Rol"].DisplayIndex = 0;
                    rolListDgv.Columns["Descripción"].DisplayIndex = 1;
                    rolListDgv.Columns["Estado"].DisplayIndex = 2;
                    rolListDgv.Columns["Editar"].DisplayIndex = 3;
                    rolListDgv.Columns["Eliminar"].DisplayIndex = 4;
                }
            }
        }

        private void tableroBtn_Click(object sender, EventArgs e)
        {
            using (RolCreateForm createForm = new RolCreateForm(this))
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    CargarRoles();
                }
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void rolListDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rolListDgv.Columns[e.ColumnIndex].Name == "Editar")
            {
                // Obtener el índice de la fila
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    // Capturar los datos de la fila seleccionada
                    int id = Convert.ToInt32(rolListDgv.Rows[rowIndex].Cells["ID"].Value);
                    string rol = rolListDgv.Rows[rowIndex].Cells["Rol"].Value.ToString();
                    string descripcion = rolListDgv.Rows[rowIndex].Cells["Descripción"].Value.ToString();
                    string estado = rolListDgv.Rows[rowIndex].Cells["Estado"].Value.ToString();
                    bool estadoBoolean = estado == "Activo";

                    // Abrir formulario de edición con los datos
                    using (RolEditForm editForm = new RolEditForm(id, rol, descripcion, estadoBoolean, this))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            // Recargar la lista después de la edición
                            CargarRoles();
                        }
                    }
                }
            }
            else if (rolListDgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    int id = Convert.ToInt32(rolListDgv.Rows[rowIndex].Cells["ID"].Value);
                    string rol = rolListDgv.Rows[rowIndex].Cells["Rol"].Value.ToString();

                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro que desea eliminar el rol '{rol}'?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string query = "DELETE FROM tipo_usuarios WHERE id = @Id";
                            using (SqlCommand cmd = new SqlCommand(query, DBConnection.con))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Rol eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarRoles();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void RolListDgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (rolListDgv.Columns[e.ColumnIndex].Name == "Editar" ||
                                   rolListDgv.Columns[e.ColumnIndex].Name == "Eliminar"))
            {
                this.Cursor = Cursors.Hand;
            }
        }

        private void RolListDgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
