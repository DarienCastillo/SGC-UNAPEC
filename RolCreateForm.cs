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
    public partial class RolCreateForm : Form
    {

        private RolListForm _rolListForm;

        public RolCreateForm(RolListForm rolListForm)
        {
            InitializeComponent();
            _rolListForm = rolListForm;
        }
        private CuoreUI.Controls.cuiTextBox rolTxt;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton limpiarRolCreateFormBtn;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiPanel cuiPanel1;

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(RolCreateForm));
            rolTxt = new CuoreUI.Controls.cuiTextBox();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            limpiarRolCreateFormBtn = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            crearRolCreateFormBtn = new CuoreUI.Controls.cuiButton();
            descTxt = new CuoreUI.Controls.cuiTextBox();
            estadoCreateFormCheck = new CuoreUI.Controls.cuiCheckbox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // rolTxt
            // 
            rolTxt.BackColor = Color.FromArgb(224, 224, 224);
            rolTxt.BackgroundColor = Color.White;
            rolTxt.Content = "";
            rolTxt.FocusBackgroundColor = Color.White;
            rolTxt.FocusImageTint = Color.White;
            rolTxt.FocusOutlineColor = SystemColors.Highlight;
            rolTxt.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolTxt.ForeColor = Color.Gray;
            rolTxt.Image = null;
            rolTxt.ImageExpand = new Point(0, 0);
            rolTxt.ImageOffset = new Point(0, 0);
            rolTxt.Location = new Point(68, 91);
            rolTxt.Margin = new Padding(4);
            rolTxt.Multiline = false;
            rolTxt.Name = "rolTxt";
            rolTxt.NormalImageTint = Color.White;
            rolTxt.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            rolTxt.Padding = new Padding(22, 15, 22, 0);
            rolTxt.PasswordChar = false;
            rolTxt.PlaceholderColor = SystemColors.WindowText;
            rolTxt.PlaceholderText = "";
            rolTxt.Rounding = new Padding(8);
            rolTxt.Size = new Size(360, 53);
            rolTxt.TabIndex = 0;
            rolTxt.TextOffset = new Size(0, 0);
            rolTxt.UnderlinedStyle = true;
            rolTxt.ContentChanged += cuiTextBox1_ContentChanged;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Controls.Add(cuiSeparator1);
            cuiPanel1.Controls.Add(cuiLabel3);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = SystemColors.Control;
            cuiPanel1.PanelOutlineColor = SystemColors.Control;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(731, 794);
            cuiPanel1.TabIndex = 1;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel2.Controls.Add(cuiLabel4);
            cuiPanel2.Controls.Add(limpiarRolCreateFormBtn);
            cuiPanel2.Controls.Add(cuiLabel1);
            cuiPanel2.Controls.Add(crearRolCreateFormBtn);
            cuiPanel2.Controls.Add(rolTxt);
            cuiPanel2.Controls.Add(descTxt);
            cuiPanel2.Controls.Add(estadoCreateFormCheck);
            cuiPanel2.Controls.Add(cuiLabel2);
            cuiPanel2.Location = new Point(117, 145);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(224, 224, 224);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel2.Rounding = new Padding(20);
            cuiPanel2.Size = new Size(497, 566);
            cuiPanel2.TabIndex = 8;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.FromArgb(224, 224, 224);
            cuiLabel4.Content = "Estado";
            cuiLabel4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cuiLabel4.ForeColor = SystemColors.ControlDarkDark;
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(68, 278);
            cuiLabel4.Margin = new Padding(5, 6, 5, 6);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(360, 33);
            cuiLabel4.TabIndex = 15;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // limpiarRolCreateFormBtn
            // 
            limpiarRolCreateFormBtn.BackColor = Color.Transparent;
            limpiarRolCreateFormBtn.CheckButton = false;
            limpiarRolCreateFormBtn.Checked = false;
            limpiarRolCreateFormBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            limpiarRolCreateFormBtn.CheckedForeColor = Color.White;
            limpiarRolCreateFormBtn.CheckedImageTint = Color.White;
            limpiarRolCreateFormBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            limpiarRolCreateFormBtn.Content = "   Limpiar";
            limpiarRolCreateFormBtn.DialogResult = DialogResult.None;
            limpiarRolCreateFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limpiarRolCreateFormBtn.ForeColor = Color.White;
            limpiarRolCreateFormBtn.HoverBackground = Color.FromArgb(128, 155, 235);
            limpiarRolCreateFormBtn.HoverForeColor = Color.White;
            limpiarRolCreateFormBtn.HoverImageTint = Color.White;
            limpiarRolCreateFormBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            limpiarRolCreateFormBtn.Image = (Image)resources.GetObject("limpiarRolCreateFormBtn.Image");
            limpiarRolCreateFormBtn.ImageAutoCenter = true;
            limpiarRolCreateFormBtn.ImageExpand = new Point(0, 0);
            limpiarRolCreateFormBtn.ImageOffset = new Point(0, 0);
            limpiarRolCreateFormBtn.Location = new Point(147, 451);
            limpiarRolCreateFormBtn.Name = "limpiarRolCreateFormBtn";
            limpiarRolCreateFormBtn.NormalBackground = Color.RoyalBlue;
            limpiarRolCreateFormBtn.NormalForeColor = Color.White;
            limpiarRolCreateFormBtn.NormalImageTint = Color.White;
            limpiarRolCreateFormBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            limpiarRolCreateFormBtn.OutlineThickness = 1F;
            limpiarRolCreateFormBtn.Padding = new Padding(20, 0, 0, 0);
            limpiarRolCreateFormBtn.PressedBackground = Color.FromArgb(43, 70, 150);
            limpiarRolCreateFormBtn.PressedForeColor = Color.White;
            limpiarRolCreateFormBtn.PressedImageTint = Color.White;
            limpiarRolCreateFormBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            limpiarRolCreateFormBtn.Rounding = new Padding(8);
            limpiarRolCreateFormBtn.Size = new Size(203, 62);
            limpiarRolCreateFormBtn.TabIndex = 14;
            limpiarRolCreateFormBtn.Tag = "";
            limpiarRolCreateFormBtn.TextAlignment = StringAlignment.Center;
            limpiarRolCreateFormBtn.TextOffset = new Point(0, 0);
            limpiarRolCreateFormBtn.Click += recargarButtonTipoUsuario_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.FromArgb(224, 224, 224);
            cuiLabel1.Content = "Rol";
            cuiLabel1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cuiLabel1.ForeColor = SystemColors.ControlDarkDark;
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(68, 58);
            cuiLabel1.Margin = new Padding(5, 6, 5, 6);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(360, 33);
            cuiLabel1.TabIndex = 13;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // crearRolCreateFormBtn
            // 
            crearRolCreateFormBtn.BackColor = Color.Transparent;
            crearRolCreateFormBtn.CheckButton = false;
            crearRolCreateFormBtn.Checked = false;
            crearRolCreateFormBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            crearRolCreateFormBtn.CheckedForeColor = Color.White;
            crearRolCreateFormBtn.CheckedImageTint = Color.White;
            crearRolCreateFormBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            crearRolCreateFormBtn.Content = "   Crear";
            crearRolCreateFormBtn.DialogResult = DialogResult.None;
            crearRolCreateFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crearRolCreateFormBtn.ForeColor = Color.White;
            crearRolCreateFormBtn.HoverBackground = Color.FromArgb(107, 177, 107);
            crearRolCreateFormBtn.HoverForeColor = Color.White;
            crearRolCreateFormBtn.HoverImageTint = Color.White;
            crearRolCreateFormBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            crearRolCreateFormBtn.Image = (Image)resources.GetObject("crearRolCreateFormBtn.Image");
            crearRolCreateFormBtn.ImageAutoCenter = true;
            crearRolCreateFormBtn.ImageExpand = new Point(0, 0);
            crearRolCreateFormBtn.ImageOffset = new Point(0, 0);
            crearRolCreateFormBtn.Location = new Point(147, 368);
            crearRolCreateFormBtn.Name = "crearRolCreateFormBtn";
            crearRolCreateFormBtn.NormalBackground = Color.ForestGreen;
            crearRolCreateFormBtn.NormalForeColor = Color.White;
            crearRolCreateFormBtn.NormalImageTint = Color.White;
            crearRolCreateFormBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            crearRolCreateFormBtn.OutlineThickness = 1F;
            crearRolCreateFormBtn.Padding = new Padding(20, 0, 0, 0);
            crearRolCreateFormBtn.PressedBackground = Color.FromArgb(71, 118, 71);
            crearRolCreateFormBtn.PressedForeColor = Color.White;
            crearRolCreateFormBtn.PressedImageTint = Color.White;
            crearRolCreateFormBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            crearRolCreateFormBtn.Rounding = new Padding(8);
            crearRolCreateFormBtn.Size = new Size(203, 62);
            crearRolCreateFormBtn.TabIndex = 12;
            crearRolCreateFormBtn.Tag = "Tablero";
            crearRolCreateFormBtn.TextAlignment = StringAlignment.Center;
            crearRolCreateFormBtn.TextOffset = new Point(0, 0);
            crearRolCreateFormBtn.Click += crearRolBtn_Click;
            // 
            // descTxt
            // 
            descTxt.BackColor = Color.FromArgb(224, 224, 224);
            descTxt.BackgroundColor = Color.White;
            descTxt.Content = "";
            descTxt.FocusBackgroundColor = Color.White;
            descTxt.FocusImageTint = Color.White;
            descTxt.FocusOutlineColor = SystemColors.Highlight;
            descTxt.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descTxt.ForeColor = Color.Gray;
            descTxt.Image = null;
            descTxt.ImageExpand = new Point(0, 0);
            descTxt.ImageOffset = new Point(0, 0);
            descTxt.Location = new Point(68, 208);
            descTxt.Margin = new Padding(4);
            descTxt.Multiline = false;
            descTxt.Name = "descTxt";
            descTxt.NormalImageTint = Color.White;
            descTxt.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            descTxt.Padding = new Padding(22, 15, 22, 0);
            descTxt.PasswordChar = false;
            descTxt.PlaceholderColor = SystemColors.WindowText;
            descTxt.PlaceholderText = "";
            descTxt.Rounding = new Padding(8);
            descTxt.Size = new Size(360, 53);
            descTxt.TabIndex = 2;
            descTxt.TextOffset = new Size(0, 0);
            descTxt.UnderlinedStyle = true;
            // 
            // estadoCreateFormCheck
            // 
            estadoCreateFormCheck.BackColor = Color.FromArgb(224, 224, 224);
            estadoCreateFormCheck.Checked = true;
            estadoCreateFormCheck.CheckedForeground = Color.RoyalBlue;
            estadoCreateFormCheck.CheckedOutlineColor = Color.RoyalBlue;
            estadoCreateFormCheck.CheckedSymbolColor = Color.White;
            estadoCreateFormCheck.Content = "Activo";
            estadoCreateFormCheck.Location = new Point(68, 316);
            estadoCreateFormCheck.MinimumSize = new Size(16, 16);
            estadoCreateFormCheck.Name = "estadoCreateFormCheck";
            estadoCreateFormCheck.OutlineStyle = true;
            estadoCreateFormCheck.OutlineThickness = 1F;
            estadoCreateFormCheck.Rounding = 5;
            estadoCreateFormCheck.ShowSymbols = true;
            estadoCreateFormCheck.Size = new Size(135, 24);
            estadoCreateFormCheck.TabIndex = 4;
            estadoCreateFormCheck.Text = "cuiCheckbox1";
            estadoCreateFormCheck.UncheckedForeground = Color.Empty;
            estadoCreateFormCheck.UncheckedOutlineColor = Color.Gray;
            estadoCreateFormCheck.UncheckedSymbolColor = Color.Empty;
            estadoCreateFormCheck.CheckedChanged += cuiCheckbox1_CheckedChanged;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.FromArgb(224, 224, 224);
            cuiLabel2.Content = "Descripción";
            cuiLabel2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cuiLabel2.ForeColor = SystemColors.ControlDarkDark;
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(68, 174);
            cuiLabel2.Margin = new Padding(5, 6, 5, 6);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(360, 33);
            cuiLabel2.TabIndex = 3;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(54, 72);
            cuiSeparator1.Margin = new Padding(5, 6, 5, 6);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(623, 20);
            cuiSeparator1.TabIndex = 6;
            cuiSeparator1.Thickness = 1F;
            cuiSeparator1.Vertical = false;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiLabel3.Content = "Crear\\ Nuevo\\ Rol";
            cuiLabel3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = SystemColors.ControlDarkDark;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(54, 32);
            cuiLabel3.Margin = new Padding(5, 6, 5, 6);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(623, 43);
            cuiLabel3.TabIndex = 7;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // RolCreateForm
            // 
            ClientSize = new Size(731, 794);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RolCreateForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);

        }
        private CuoreUI.Controls.cuiCheckbox estadoCreateFormCheck;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox descTxt;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton crearRolCreateFormBtn;
        

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {

        }

        private void cuiCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (estadoCreateFormCheck.Checked)
            {
                estadoCreateFormCheck.Content = "Activo";
            }
            else
            {
                estadoCreateFormCheck.Content = "Inactivo";
            }
        }

        private void recargarButtonTipoUsuario_Click(object sender, EventArgs e)
        {
            rolTxt.Content = "";
            descTxt.Content = "";
            estadoCreateFormCheck.Checked = true;
        }

        private void crearRolBtn_Click(object sender, EventArgs e)
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

                InsertarRol();
        }

        private void InsertarRol()
        {
            rolTxt.Content = rolTxt.Content.Trim();
            descTxt.Content = descTxt.Content.Trim();
            int estado = estadoCreateFormCheck.Checked ? 1 : 0;
            try
            {
                using (var command = new Microsoft.Data.SqlClient.SqlCommand())
                {
                    command.Connection = DBConnection.con;
                    command.CommandText = @"
                    INSERT INTO tipo_usuarios (tipo_usuario, descripcion, estado)
                    VALUES (@tipo_usuario, @descripcion, @estado)";
                    command.Parameters.AddWithValue("@tipo_usuario", rolTxt.Content);
                    command.Parameters.AddWithValue("@descripcion", descTxt.Content);
                    command.Parameters.AddWithValue("@estado", estado);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rol creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        _rolListForm.CargarRoles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el rol. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
