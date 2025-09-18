namespace SGC_UNAPEC
{
    partial class UserListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            panel1 = new Panel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            panel2 = new Panel();
            userListDgv = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            panel3 = new Panel();
            panel4 = new Panel();
            refrescarUserListFormBtn = new CuoreUI.Controls.cuiButton();
            crearUserListFormBtn = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userListDgv).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cuiSeparator1);
            panel1.Controls.Add(cuiLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1659, 94);
            panel1.TabIndex = 4;
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(85, 67);
            cuiSeparator1.Margin = new Padding(5, 6, 5, 6);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(1532, 20);
            cuiSeparator1.TabIndex = 0;
            cuiSeparator1.Thickness = 1F;
            cuiSeparator1.Vertical = false;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiLabel1.Content = "Gestión\\ de\\ Usuarios";
            cuiLabel1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = SystemColors.ControlDarkDark;
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(85, 27);
            cuiLabel1.Margin = new Padding(5, 6, 5, 6);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(1532, 43);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // panel2
            // 
            panel2.Controls.Add(userListDgv);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(60);
            panel2.Size = new Size(1659, 712);
            panel2.TabIndex = 5;
            // 
            // userListDgv
            // 
            userListDgv.AllowUserToAddRows = false;
            userListDgv.AllowUserToResizeColumns = false;
            userListDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            userListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            userListDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userListDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            userListDgv.BackgroundColor = Color.FromArgb(248, 250, 252);
            userListDgv.BorderStyle = BorderStyle.None;
            userListDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            userListDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            userListDgv.ColumnHeadersHeight = 50;
            userListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            userListDgv.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Padding = new Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userListDgv.DefaultCellStyle = dataGridViewCellStyle3;
            userListDgv.Dock = DockStyle.Fill;
            userListDgv.EnableHeadersVisualStyles = false;
            userListDgv.GridColor = Color.FromArgb(226, 232, 240);
            userListDgv.Location = new Point(60, 150);
            userListDgv.MultiSelect = false;
            userListDgv.Name = "userListDgv";
            userListDgv.RowHeadersVisible = false;
            userListDgv.RowHeadersWidth = 62;
            userListDgv.RowTemplate.Height = 45;
            userListDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userListDgv.Size = new Size(1539, 502);
            userListDgv.TabIndex = 1;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(60, 60);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1539, 90);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(refrescarUserListFormBtn);
            panel4.Controls.Add(crearUserListFormBtn);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(998, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 70);
            panel4.TabIndex = 0;
            // 
            // refrescarUserListFormBtn
            // 
            refrescarUserListFormBtn.CheckButton = false;
            refrescarUserListFormBtn.Checked = false;
            refrescarUserListFormBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            refrescarUserListFormBtn.CheckedForeColor = Color.White;
            refrescarUserListFormBtn.CheckedImageTint = Color.White;
            refrescarUserListFormBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            refrescarUserListFormBtn.Content = "   Refrescar";
            refrescarUserListFormBtn.DialogResult = DialogResult.None;
            refrescarUserListFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refrescarUserListFormBtn.ForeColor = Color.White;
            refrescarUserListFormBtn.HoverBackground = Color.FromArgb(128, 155, 235);
            refrescarUserListFormBtn.HoverForeColor = Color.White;
            refrescarUserListFormBtn.HoverImageTint = Color.White;
            refrescarUserListFormBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            refrescarUserListFormBtn.Image = (Image)resources.GetObject("refrescarUserListFormBtn.Image");
            refrescarUserListFormBtn.ImageAutoCenter = true;
            refrescarUserListFormBtn.ImageExpand = new Point(0, 0);
            refrescarUserListFormBtn.ImageOffset = new Point(0, 0);
            refrescarUserListFormBtn.Location = new Point(61, 8);
            refrescarUserListFormBtn.Name = "refrescarUserListFormBtn";
            refrescarUserListFormBtn.NormalBackground = Color.RoyalBlue;
            refrescarUserListFormBtn.NormalForeColor = Color.White;
            refrescarUserListFormBtn.NormalImageTint = Color.White;
            refrescarUserListFormBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            refrescarUserListFormBtn.OutlineThickness = 1F;
            refrescarUserListFormBtn.Padding = new Padding(20, 0, 0, 0);
            refrescarUserListFormBtn.PressedBackground = Color.FromArgb(43, 70, 150);
            refrescarUserListFormBtn.PressedForeColor = Color.White;
            refrescarUserListFormBtn.PressedImageTint = Color.White;
            refrescarUserListFormBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            refrescarUserListFormBtn.Rounding = new Padding(8);
            refrescarUserListFormBtn.Size = new Size(217, 55);
            refrescarUserListFormBtn.TabIndex = 11;
            refrescarUserListFormBtn.Tag = "Tablero";
            refrescarUserListFormBtn.TextAlignment = StringAlignment.Center;
            refrescarUserListFormBtn.TextOffset = new Point(0, 0);
            refrescarUserListFormBtn.Click += refrescarUserListFormBtn_Click;
            // 
            // crearUserListFormBtn
            // 
            crearUserListFormBtn.CheckButton = false;
            crearUserListFormBtn.Checked = false;
            crearUserListFormBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            crearUserListFormBtn.CheckedForeColor = Color.White;
            crearUserListFormBtn.CheckedImageTint = Color.White;
            crearUserListFormBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            crearUserListFormBtn.Content = "   Crear";
            crearUserListFormBtn.DialogResult = DialogResult.None;
            crearUserListFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crearUserListFormBtn.ForeColor = Color.White;
            crearUserListFormBtn.HoverBackground = Color.FromArgb(107, 177, 107);
            crearUserListFormBtn.HoverForeColor = Color.White;
            crearUserListFormBtn.HoverImageTint = Color.White;
            crearUserListFormBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            crearUserListFormBtn.Image = (Image)resources.GetObject("crearUserListFormBtn.Image");
            crearUserListFormBtn.ImageAutoCenter = true;
            crearUserListFormBtn.ImageExpand = new Point(0, 0);
            crearUserListFormBtn.ImageOffset = new Point(0, 0);
            crearUserListFormBtn.Location = new Point(299, 8);
            crearUserListFormBtn.Name = "crearUserListFormBtn";
            crearUserListFormBtn.NormalBackground = Color.ForestGreen;
            crearUserListFormBtn.NormalForeColor = Color.White;
            crearUserListFormBtn.NormalImageTint = Color.White;
            crearUserListFormBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            crearUserListFormBtn.OutlineThickness = 1F;
            crearUserListFormBtn.Padding = new Padding(20, 0, 0, 0);
            crearUserListFormBtn.PressedBackground = Color.FromArgb(71, 118, 71);
            crearUserListFormBtn.PressedForeColor = Color.White;
            crearUserListFormBtn.PressedImageTint = Color.White;
            crearUserListFormBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            crearUserListFormBtn.Rounding = new Padding(8);
            crearUserListFormBtn.Size = new Size(217, 55);
            crearUserListFormBtn.TabIndex = 10;
            crearUserListFormBtn.Tag = "Tablero";
            crearUserListFormBtn.TextAlignment = StringAlignment.Center;
            crearUserListFormBtn.TextOffset = new Point(0, 0);
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1659, 806);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserListForm";
            Text = "UserListForm";
            Load += UserListForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userListDgv).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Panel panel2;
        private DataGridView userListDgv;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private Panel panel3;
        private Panel panel4;
        private CuoreUI.Controls.cuiButton refrescarUserListFormBtn;
        private CuoreUI.Controls.cuiButton crearUserListFormBtn;
    }
}