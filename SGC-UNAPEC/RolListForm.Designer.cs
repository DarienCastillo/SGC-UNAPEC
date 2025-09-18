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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolListForm));
            panel1 = new Panel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            panel2 = new Panel();
            rolListDgv = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            tableroBtn = new CuoreUI.Controls.cuiButton();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            rolListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            rolListDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolListDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            rolListDgv.BackgroundColor = Color.FromArgb(248, 250, 252);
            rolListDgv.BorderStyle = BorderStyle.None;
            rolListDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            rolListDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            rolListDgv.ColumnHeadersHeight = 50;
            rolListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            rolListDgv.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Padding = new Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            rolListDgv.DefaultCellStyle = dataGridViewCellStyle3;
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
            panel4.Controls.Add(cuiButton1);
            panel4.Controls.Add(tableroBtn);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1020, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 70);
            panel4.TabIndex = 0;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "   Refrescar";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.FromArgb(128, 155, 235);
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = (Image)resources.GetObject("cuiButton1.Image");
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(61, 8);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.RoyalBlue;
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(20, 0, 0, 0);
            cuiButton1.PressedBackground = Color.FromArgb(43, 70, 150);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(217, 55);
            cuiButton1.TabIndex = 11;
            cuiButton1.Tag = "Tablero";
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // tableroBtn
            // 
            tableroBtn.CheckButton = false;
            tableroBtn.Checked = false;
            tableroBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            tableroBtn.CheckedForeColor = Color.White;
            tableroBtn.CheckedImageTint = Color.White;
            tableroBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            tableroBtn.Content = "   Crear";
            tableroBtn.DialogResult = DialogResult.None;
            tableroBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableroBtn.ForeColor = Color.White;
            tableroBtn.HoverBackground = Color.FromArgb(107, 177, 107);
            tableroBtn.HoverForeColor = Color.White;
            tableroBtn.HoverImageTint = Color.White;
            tableroBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            tableroBtn.Image = (Image)resources.GetObject("tableroBtn.Image");
            tableroBtn.ImageAutoCenter = true;
            tableroBtn.ImageExpand = new Point(0, 0);
            tableroBtn.ImageOffset = new Point(0, 0);
            tableroBtn.Location = new Point(299, 8);
            tableroBtn.Name = "tableroBtn";
            tableroBtn.NormalBackground = Color.ForestGreen;
            tableroBtn.NormalForeColor = Color.White;
            tableroBtn.NormalImageTint = Color.White;
            tableroBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            tableroBtn.OutlineThickness = 1F;
            tableroBtn.Padding = new Padding(20, 0, 0, 0);
            tableroBtn.PressedBackground = Color.FromArgb(71, 118, 71);
            tableroBtn.PressedForeColor = Color.White;
            tableroBtn.PressedImageTint = Color.White;
            tableroBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            tableroBtn.Rounding = new Padding(8);
            tableroBtn.Size = new Size(217, 55);
            tableroBtn.TabIndex = 10;
            tableroBtn.Tag = "Tablero";
            tableroBtn.TextAlignment = StringAlignment.Center;
            tableroBtn.TextOffset = new Point(0, 0);
            tableroBtn.Click += tableroBtn_Click;
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
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton tableroBtn;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}