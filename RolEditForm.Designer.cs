namespace SGC_UNAPEC
{
    partial class RolEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolEditForm));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            editarRolEditFormBtn = new CuoreUI.Controls.cuiButton();
            rolTxt = new CuoreUI.Controls.cuiTextBox();
            descTxt = new CuoreUI.Controls.cuiTextBox();
            estadoRoleEditFormCheck = new CuoreUI.Controls.cuiCheckbox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
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
            cuiPanel1.TabIndex = 2;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel2.Controls.Add(cuiLabel4);
            cuiPanel2.Controls.Add(cuiLabel1);
            cuiPanel2.Controls.Add(editarRolEditFormBtn);
            cuiPanel2.Controls.Add(rolTxt);
            cuiPanel2.Controls.Add(descTxt);
            cuiPanel2.Controls.Add(estadoRoleEditFormCheck);
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
            // editarRolEditFormBtn
            // 
            editarRolEditFormBtn.BackColor = Color.Transparent;
            editarRolEditFormBtn.CheckButton = false;
            editarRolEditFormBtn.Checked = false;
            editarRolEditFormBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            editarRolEditFormBtn.CheckedForeColor = Color.White;
            editarRolEditFormBtn.CheckedImageTint = Color.White;
            editarRolEditFormBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            editarRolEditFormBtn.Content = "   Editar";
            editarRolEditFormBtn.DialogResult = DialogResult.None;
            editarRolEditFormBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editarRolEditFormBtn.ForeColor = Color.White;
            editarRolEditFormBtn.HoverBackground = Color.FromArgb(230, 195, 106);
            editarRolEditFormBtn.HoverForeColor = Color.White;
            editarRolEditFormBtn.HoverImageTint = Color.White;
            editarRolEditFormBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            editarRolEditFormBtn.Image = (Image)resources.GetObject("editarRolEditFormBtn.Image");
            editarRolEditFormBtn.ImageAutoCenter = true;
            editarRolEditFormBtn.ImageExpand = new Point(0, 0);
            editarRolEditFormBtn.ImageOffset = new Point(0, 0);
            editarRolEditFormBtn.Location = new Point(147, 437);
            editarRolEditFormBtn.Name = "editarRolEditFormBtn";
            editarRolEditFormBtn.NormalBackground = Color.Goldenrod;
            editarRolEditFormBtn.NormalForeColor = Color.White;
            editarRolEditFormBtn.NormalImageTint = Color.White;
            editarRolEditFormBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            editarRolEditFormBtn.OutlineThickness = 1F;
            editarRolEditFormBtn.Padding = new Padding(20, 0, 0, 0);
            editarRolEditFormBtn.PressedBackground = Color.FromArgb(145, 110, 21);
            editarRolEditFormBtn.PressedForeColor = Color.White;
            editarRolEditFormBtn.PressedImageTint = Color.White;
            editarRolEditFormBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            editarRolEditFormBtn.Rounding = new Padding(8);
            editarRolEditFormBtn.Size = new Size(203, 62);
            editarRolEditFormBtn.TabIndex = 12;
            editarRolEditFormBtn.Tag = "";
            editarRolEditFormBtn.TextAlignment = StringAlignment.Center;
            editarRolEditFormBtn.TextOffset = new Point(0, 0);
            editarRolEditFormBtn.Click += editarRolEditFormBtn_Click;
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
            // estadoRoleEditFormCheck
            // 
            estadoRoleEditFormCheck.BackColor = Color.FromArgb(224, 224, 224);
            estadoRoleEditFormCheck.Checked = true;
            estadoRoleEditFormCheck.CheckedForeground = Color.RoyalBlue;
            estadoRoleEditFormCheck.CheckedOutlineColor = Color.RoyalBlue;
            estadoRoleEditFormCheck.CheckedSymbolColor = Color.White;
            estadoRoleEditFormCheck.Content = "Activo";
            estadoRoleEditFormCheck.Location = new Point(68, 316);
            estadoRoleEditFormCheck.MinimumSize = new Size(16, 16);
            estadoRoleEditFormCheck.Name = "estadoRoleEditFormCheck";
            estadoRoleEditFormCheck.OutlineStyle = true;
            estadoRoleEditFormCheck.OutlineThickness = 1F;
            estadoRoleEditFormCheck.Rounding = 5;
            estadoRoleEditFormCheck.ShowSymbols = true;
            estadoRoleEditFormCheck.Size = new Size(135, 24);
            estadoRoleEditFormCheck.TabIndex = 4;
            estadoRoleEditFormCheck.Text = "cuiCheckbox1";
            estadoRoleEditFormCheck.UncheckedForeground = Color.Empty;
            estadoRoleEditFormCheck.UncheckedOutlineColor = Color.Gray;
            estadoRoleEditFormCheck.UncheckedSymbolColor = Color.Empty;
            estadoRoleEditFormCheck.CheckedChanged += estadoRoleEditFormCheck_CheckedChanged;
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
            cuiLabel3.Content = "Editar\\ Rol";
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
            // RolEditForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(731, 794);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RolEditForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton editarRolEditFormBtn;
        private CuoreUI.Controls.cuiTextBox rolTxt;
        private CuoreUI.Controls.cuiTextBox descTxt;
        private CuoreUI.Controls.cuiCheckbox estadoRoleEditFormCheck;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
    }
}