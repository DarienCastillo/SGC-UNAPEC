using CuoreUI.Controls;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

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

        // Método para hashear la contraseña igual que en UserEditForm
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            if (DBConnection.con.State == ConnectionState.Closed)
            {
                DBConnection.con.Open();
            }

            // Hashear la contraseña ingresada antes de comparar
            string hashedPassword = HashPassword(cuiTextBox2.Content);

            string query = "SELECT * FROM usuarios WHERE nombre = @nombre AND clave = @clave";
            using (SqlCommand command = new SqlCommand(query, DBConnection.con))
            {
                command.Parameters.AddWithValue("@nombre", cuiTextBox1.Content);
                command.Parameters.AddWithValue("@clave", hashedPassword);

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
