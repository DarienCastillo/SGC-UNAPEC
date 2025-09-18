using CuoreUI.Controls;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SGC_UNAPEC
{
    public partial class SGC : Form
    {
        public SGC()
        {
            InitializeComponent();
        }
        private void SGC_Load(object sender, EventArgs e)
        {
        }

        private void cuiCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            cuiTextBox2.PasswordChar = !cuiCheckbox1.Checked;
            cuiCheckbox1.Content = cuiCheckbox1.Checked ? "Ocultar" : "Mostrar";
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            if (DBConnection.con.State == ConnectionState.Closed)
            {
                DBConnection.con.Open();
            }

            string query = "SELECT * FROM usuarios WHERE nombre = @nombre AND clave = @clave";
            using (SqlCommand command = new SqlCommand(query, DBConnection.con))
            {
                command.Parameters.AddWithValue("@nombre", cuiTextBox1.Content);
                command.Parameters.AddWithValue("@clave", cuiTextBox2.Content);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        this.Hide();
                        MainPanel MP = new MainPanel();
                        MP.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrecta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cuiTextBox2.Content = "";
                        cuiTextBox2.Focus();
                    }
                }

            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                cuiButton1_Click(cuiButton1, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}   
