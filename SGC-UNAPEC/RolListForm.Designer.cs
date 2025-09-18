namespace SGC_UNAPEC
{
    partial class RolListForm : Form
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolListForm));
            panel1 = new Panel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            panel2 = new Panel();
            rolListDgv = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            panel3 = new Panel();
            panel4 = new Panel();
            refrescarRolListFormBtn = new CuoreUI.Controls.cuiButton();
            crearRolListFormBtn = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rolListDgv).BeginInit();
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
            panel1.Size = new Size(1681, 94);
            panel1.TabIndex = 3;
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
            cuiLabel1.Content = "Gestión\\ de\\ Roles";
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
            panel2.Controls.Add(rolListDgv);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(60);
            panel2.Size = new Size(1681, 768);
            panel2.TabIndex = 4;
            // 
            // rolListDgv
            // 
            rolListDgv.AllowUserToAddRows = false;
            rolListDgv.AllowUserToResizeColumns = false;
            rolListDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 250, 252);
            rolListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            rolListDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolListDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            rolListDgv.BackgroundColor = Color.FromArgb(248, 250, 252);
            rolListDgv.BorderStyle = BorderStyle.None;
            rolListDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            rolListDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            rolListDgv.ColumnHeadersHeight = 50;
            rolListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            rolListDgv.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle6.Padding = new Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            rolListDgv.DefaultCellStyle = dataGridViewCellStyle6;
            rolListDgv.Dock = DockStyle.Fill;
            rolListDgv.EnableHeadersVisualStyles = false;
            rolListDgv.GridColor = Color.FromArgb(226, 232, 240);
            rolListDgv.Location = new Point(60, 150);
            rolListDgv.MultiSelect = false;
            rolListDgv.Name = "rolListDgv";
            rolListDgv.RowHeadersVisible = false;
            rolListDgv.RowHeadersWidth = 62;
            rolListDgv.RowTemplate.Height = 45;
            rolListDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rolListDgv.Size = new Size(1561, 558);
            rolListDgv.TabIndex = 1;
            rolListDgv.CellClick += rolListDgv_CellClick;
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
            panel3.Size = new Size(1561, 90);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(refrescarRolListFormBtn);
            panel4.Controls.Add(crearRolListFormBtn);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1020, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 70);
            panel4.TabIndex = 0;
            // 
            // refrescarRolListFormBtn
            // 
            refrescarRolListFormBtn.CheckButton = false;
            refrescarRolListFormBtn.Checked = false;
            refrescarRolListFormBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            refrescarRolListFormBtn.CheckedForeColor = Color.White;
            refrescarRolListFormBtn.CheckedImageTint = Color.White;
            refrescarRolListFormBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            refrescarRolListFormBtn.Content = "   Refrescar";
            refrescarRolListFormBtn.DialogResult = DialogResult.None;
            refrescarRolListFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refrescarRolListFormBtn.ForeColor = Color.White;
            refrescarRolListFormBtn.HoverBackground = Color.FromArgb(128, 155, 235);
            refrescarRolListFormBtn.HoverForeColor = Color.White;
            refrescarRolListFormBtn.HoverImageTint = Color.White;
            refrescarRolListFormBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            refrescarRolListFormBtn.Image = (Image)resources.GetObject("refrescarRolListFormBtn.Image");
            refrescarRolListFormBtn.ImageAutoCenter = true;
            refrescarRolListFormBtn.ImageExpand = new Point(0, 0);
            refrescarRolListFormBtn.ImageOffset = new Point(0, 0);
            refrescarRolListFormBtn.Location = new Point(61, 8);
            refrescarRolListFormBtn.Name = "refrescarRolListFormBtn";
            refrescarRolListFormBtn.NormalBackground = Color.RoyalBlue;
            refrescarRolListFormBtn.NormalForeColor = Color.White;
            refrescarRolListFormBtn.NormalImageTint = Color.White;
            refrescarRolListFormBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            refrescarRolListFormBtn.OutlineThickness = 1F;
            refrescarRolListFormBtn.Padding = new Padding(20, 0, 0, 0);
            refrescarRolListFormBtn.PressedBackground = Color.FromArgb(43, 70, 150);
            refrescarRolListFormBtn.PressedForeColor = Color.White;
            refrescarRolListFormBtn.PressedImageTint = Color.White;
            refrescarRolListFormBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            refrescarRolListFormBtn.Rounding = new Padding(8);
            refrescarRolListFormBtn.Size = new Size(217, 55);
            refrescarRolListFormBtn.TabIndex = 11;
            refrescarRolListFormBtn.Tag = "Tablero";
            refrescarRolListFormBtn.TextAlignment = StringAlignment.Center;
            refrescarRolListFormBtn.TextOffset = new Point(0, 0);
            refrescarRolListFormBtn.Click += refrescarRolListFormBtn_Click;
            // 
            // crearRolListFormBtn
            // 
            crearRolListFormBtn.CheckButton = false;
            crearRolListFormBtn.Checked = false;
            crearRolListFormBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            crearRolListFormBtn.CheckedForeColor = Color.White;
            crearRolListFormBtn.CheckedImageTint = Color.White;
            crearRolListFormBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            crearRolListFormBtn.Content = "   Crear";
            crearRolListFormBtn.DialogResult = DialogResult.None;
            crearRolListFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crearRolListFormBtn.ForeColor = Color.White;
            crearRolListFormBtn.HoverBackground = Color.FromArgb(107, 177, 107);
            crearRolListFormBtn.HoverForeColor = Color.White;
            crearRolListFormBtn.HoverImageTint = Color.White;
            crearRolListFormBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            crearRolListFormBtn.Image = (Image)resources.GetObject("crearRolListFormBtn.Image");
            crearRolListFormBtn.ImageAutoCenter = true;
            crearRolListFormBtn.ImageExpand = new Point(0, 0);
            crearRolListFormBtn.ImageOffset = new Point(0, 0);
            crearRolListFormBtn.Location = new Point(299, 8);
            crearRolListFormBtn.Name = "crearRolListFormBtn";
            crearRolListFormBtn.NormalBackground = Color.ForestGreen;
            crearRolListFormBtn.NormalForeColor = Color.White;
            crearRolListFormBtn.NormalImageTint = Color.White;
            crearRolListFormBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            crearRolListFormBtn.OutlineThickness = 1F;
            crearRolListFormBtn.Padding = new Padding(20, 0, 0, 0);
            crearRolListFormBtn.PressedBackground = Color.FromArgb(71, 118, 71);
            crearRolListFormBtn.PressedForeColor = Color.White;
            crearRolListFormBtn.PressedImageTint = Color.White;
            crearRolListFormBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            crearRolListFormBtn.Rounding = new Padding(8);
            crearRolListFormBtn.Size = new Size(217, 55);
            crearRolListFormBtn.TabIndex = 10;
            crearRolListFormBtn.Tag = "Tablero";
            crearRolListFormBtn.TextAlignment = StringAlignment.Center;
            crearRolListFormBtn.TextOffset = new Point(0, 0);
            crearRolListFormBtn.Click += crearRolListFormBtn_Click;
            // 
            // RolListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 862);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RolListForm";
            Text = "RolFormList1";
            Load += RolFormList_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rolListDgv).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Panel panel2;
        private DataGridView rolListDgv;
        private Panel panel3;
        private Panel panel4;
        private CuoreUI.Controls.cuiButton refrescarRolListFormBtn;
        private CuoreUI.Controls.cuiButton crearRolListFormBtn;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}