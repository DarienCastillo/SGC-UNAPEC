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
    public partial class MainPanel : Form
    {
        private bool isCollapsed = false;
        private const int EXPANDED_WIDTH = 356;
        private const int COLLAPSED_WIDTH = 100;
        private const int BUTTON_MARGIN = 12;

        public MainPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainPanel));
            Sidebar = new CuoreUI.Controls.cuiPanel();
            salirBtn = new CuoreUI.Controls.cuiButton();
            gestionBtn = new CuoreUI.Controls.cuiButton();
            ventasBtn = new CuoreUI.Controls.cuiButton();
            tableroBtn = new CuoreUI.Controls.cuiButton();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            kolaoLogoK = new CuoreUI.Controls.cuiPictureBox();
            Logo = new CuoreUI.Controls.cuiPictureBox();
            Topbar = new CuoreUI.Controls.cuiPanel();
            AlternarBtn = new CuoreUI.Controls.cuiButton();
            gestionCms = new ContextMenuStrip(components);
            gestiónDeCafeteríaToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeCampusToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeProveedoresToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeMarcasToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeArtículosToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeRolesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            ventasCms = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            FormPanel = new CuoreUI.Controls.cuiPanel();
            cuiFormAnimator1 = new CuoreUI.Components.cuiFormAnimator(components);
            Sidebar.SuspendLayout();
            cuiPanel1.SuspendLayout();
            Topbar.SuspendLayout();
            gestionCms.SuspendLayout();
            ventasCms.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.Transparent;
            Sidebar.Controls.Add(salirBtn);
            Sidebar.Controls.Add(gestionBtn);
            Sidebar.Controls.Add(ventasBtn);
            Sidebar.Controls.Add(tableroBtn);
            Sidebar.Controls.Add(cuiPanel1);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.OutlineThickness = 1F;
            Sidebar.Padding = new Padding(0, 0, 0, 20);
            Sidebar.PanelColor = Color.FromArgb(10, 35, 70);
            Sidebar.PanelOutlineColor = Color.FromArgb(10, 35, 70);
            Sidebar.Rounding = new Padding(0);
            Sidebar.Size = new Size(356, 844);
            Sidebar.TabIndex = 0;
            // 
            // salirBtn
            // 
            salirBtn.Anchor = AnchorStyles.Bottom;
            salirBtn.CheckButton = false;
            salirBtn.Checked = false;
            salirBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            salirBtn.CheckedForeColor = Color.White;
            salirBtn.CheckedImageTint = Color.White;
            salirBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            salirBtn.Content = "    Salir";
            salirBtn.DialogResult = DialogResult.None;
            salirBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salirBtn.ForeColor = Color.White;
            salirBtn.HoverBackground = Color.FromArgb(20, 55, 110);
            salirBtn.HoverForeColor = Color.White;
            salirBtn.HoverImageTint = Color.White;
            salirBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            salirBtn.Image = (Image)resources.GetObject("salirBtn.Image");
            salirBtn.ImageAutoCenter = true;
            salirBtn.ImageExpand = new Point(0, 0);
            salirBtn.ImageOffset = new Point(0, 0);
            salirBtn.Location = new Point(12, 751);
            salirBtn.Name = "salirBtn";
            salirBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            salirBtn.NormalForeColor = Color.White;
            salirBtn.NormalImageTint = Color.White;
            salirBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            salirBtn.OutlineThickness = 1F;
            salirBtn.Padding = new Padding(20, 0, 0, 0);
            salirBtn.PressedBackground = Color.FromArgb(5, 25, 50);
            salirBtn.PressedForeColor = Color.White;
            salirBtn.PressedImageTint = Color.White;
            salirBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            salirBtn.Rounding = new Padding(8);
            salirBtn.Size = new Size(333, 68);
            salirBtn.TabIndex = 12;
            salirBtn.Tag = "Salir";
            salirBtn.TextAlignment = StringAlignment.Center;
            salirBtn.TextOffset = new Point(0, 0);
            salirBtn.Click += salirBtn_Click;
            // 
            // gestionBtn
            // 
            gestionBtn.CheckButton = false;
            gestionBtn.Checked = false;
            gestionBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            gestionBtn.CheckedForeColor = Color.White;
            gestionBtn.CheckedImageTint = Color.White;
            gestionBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            gestionBtn.Content = "   Gestión";
            gestionBtn.DialogResult = DialogResult.None;
            gestionBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gestionBtn.ForeColor = Color.White;
            gestionBtn.HoverBackground = Color.FromArgb(20, 55, 110);
            gestionBtn.HoverForeColor = Color.White;
            gestionBtn.HoverImageTint = Color.White;
            gestionBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            gestionBtn.Image = (Image)resources.GetObject("gestionBtn.Image");
            gestionBtn.ImageAutoCenter = true;
            gestionBtn.ImageExpand = new Point(0, 0);
            gestionBtn.ImageOffset = new Point(0, 0);
            gestionBtn.Location = new Point(12, 338);
            gestionBtn.Name = "gestionBtn";
            gestionBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            gestionBtn.NormalForeColor = Color.White;
            gestionBtn.NormalImageTint = Color.White;
            gestionBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            gestionBtn.OutlineThickness = 1F;
            gestionBtn.Padding = new Padding(20, 0, 0, 0);
            gestionBtn.PressedBackground = Color.FromArgb(5, 25, 50);
            gestionBtn.PressedForeColor = Color.White;
            gestionBtn.PressedImageTint = Color.White;
            gestionBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            gestionBtn.Rounding = new Padding(8);
            gestionBtn.Size = new Size(333, 68);
            gestionBtn.TabIndex = 11;
            gestionBtn.Tag = "Gestión";
            gestionBtn.TextAlignment = StringAlignment.Center;
            gestionBtn.TextOffset = new Point(0, 0);
            gestionBtn.Click += gestionBtn_Click;
            // 
            // ventasBtn
            // 
            ventasBtn.CheckButton = false;
            ventasBtn.Checked = false;
            ventasBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            ventasBtn.CheckedForeColor = Color.White;
            ventasBtn.CheckedImageTint = Color.White;
            ventasBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            ventasBtn.Content = "    Ventas";
            ventasBtn.DialogResult = DialogResult.None;
            ventasBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ventasBtn.ForeColor = Color.White;
            ventasBtn.HoverBackground = Color.FromArgb(20, 55, 110);
            ventasBtn.HoverForeColor = Color.White;
            ventasBtn.HoverImageTint = Color.White;
            ventasBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            ventasBtn.Image = (Image)resources.GetObject("ventasBtn.Image");
            ventasBtn.ImageAutoCenter = true;
            ventasBtn.ImageExpand = new Point(0, 0);
            ventasBtn.ImageOffset = new Point(0, 0);
            ventasBtn.Location = new Point(12, 264);
            ventasBtn.Name = "ventasBtn";
            ventasBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            ventasBtn.NormalForeColor = Color.White;
            ventasBtn.NormalImageTint = Color.White;
            ventasBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            ventasBtn.OutlineThickness = 1F;
            ventasBtn.Padding = new Padding(20, 0, 0, 0);
            ventasBtn.PressedBackground = Color.FromArgb(5, 25, 50);
            ventasBtn.PressedForeColor = Color.White;
            ventasBtn.PressedImageTint = Color.White;
            ventasBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            ventasBtn.Rounding = new Padding(8);
            ventasBtn.Size = new Size(333, 68);
            ventasBtn.TabIndex = 10;
            ventasBtn.Tag = "Ventas";
            ventasBtn.TextAlignment = StringAlignment.Center;
            ventasBtn.TextOffset = new Point(0, 0);
            ventasBtn.Click += ventasBtn_Click;
            // 
            // tableroBtn
            // 
            tableroBtn.CheckButton = false;
            tableroBtn.Checked = false;
            tableroBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            tableroBtn.CheckedForeColor = Color.White;
            tableroBtn.CheckedImageTint = Color.White;
            tableroBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            tableroBtn.Content = "   Tablero";
            tableroBtn.DialogResult = DialogResult.None;
            tableroBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableroBtn.ForeColor = Color.White;
            tableroBtn.HoverBackground = Color.FromArgb(20, 55, 110);
            tableroBtn.HoverForeColor = Color.White;
            tableroBtn.HoverImageTint = Color.White;
            tableroBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            tableroBtn.Image = (Image)resources.GetObject("tableroBtn.Image");
            tableroBtn.ImageAutoCenter = true;
            tableroBtn.ImageExpand = new Point(0, 0);
            tableroBtn.ImageOffset = new Point(0, 0);
            tableroBtn.Location = new Point(12, 190);
            tableroBtn.Name = "tableroBtn";
            tableroBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            tableroBtn.NormalForeColor = Color.White;
            tableroBtn.NormalImageTint = Color.White;
            tableroBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            tableroBtn.OutlineThickness = 1F;
            tableroBtn.Padding = new Padding(20, 0, 0, 0);
            tableroBtn.PressedBackground = Color.FromArgb(5, 25, 50);
            tableroBtn.PressedForeColor = Color.White;
            tableroBtn.PressedImageTint = Color.White;
            tableroBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            tableroBtn.Rounding = new Padding(8);
            tableroBtn.Size = new Size(333, 68);
            tableroBtn.TabIndex = 9;
            tableroBtn.Tag = "Tablero";
            tableroBtn.TextAlignment = StringAlignment.Center;
            tableroBtn.TextOffset = new Point(0, 0);
            tableroBtn.Click += tableroBtn_Click;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(kolaoLogoK);
            cuiPanel1.Controls.Add(Logo);
            cuiPanel1.Dock = DockStyle.Top;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(10, 35, 70);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(10, 35, 70);
            cuiPanel1.Rounding = new Padding(0);
            cuiPanel1.Size = new Size(356, 167);
            cuiPanel1.TabIndex = 2;
            // 
            // kolaoLogoK
            // 
            kolaoLogoK.Content = (Image)resources.GetObject("kolaoLogoK.Content");
            kolaoLogoK.ImageTint = Color.White;
            kolaoLogoK.Location = new Point(23, 37);
            kolaoLogoK.Margin = new Padding(5, 6, 5, 6);
            kolaoLogoK.Name = "kolaoLogoK";
            kolaoLogoK.OutlineThickness = 1F;
            kolaoLogoK.PanelOutlineColor = Color.Empty;
            kolaoLogoK.Rotation = 0;
            kolaoLogoK.Rounding = new Padding(8);
            kolaoLogoK.Size = new Size(80, 80);
            kolaoLogoK.TabIndex = 2;
            kolaoLogoK.TabStop = false;
            kolaoLogoK.Visible = false;
            // 
            // Logo
            // 
            Logo.Content = (Image)resources.GetObject("Logo.Content");
            Logo.ImageTint = Color.White;
            Logo.Location = new Point(72, 37);
            Logo.Margin = new Padding(5, 6, 5, 6);
            Logo.Name = "Logo";
            Logo.OutlineThickness = 1F;
            Logo.PanelOutlineColor = Color.Empty;
            Logo.Rotation = 0;
            Logo.Rounding = new Padding(8);
            Logo.Size = new Size(213, 93);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // Topbar
            // 
            Topbar.BackColor = Color.Transparent;
            Topbar.Controls.Add(AlternarBtn);
            Topbar.Dock = DockStyle.Top;
            Topbar.Location = new Point(356, 0);
            Topbar.Name = "Topbar";
            Topbar.OutlineThickness = 1F;
            Topbar.PanelColor = SystemColors.ButtonHighlight;
            Topbar.PanelOutlineColor = SystemColors.ButtonHighlight;
            Topbar.Rounding = new Padding(0);
            Topbar.Size = new Size(1431, 72);
            Topbar.TabIndex = 2;
            // 
            // AlternarBtn
            // 
            AlternarBtn.CheckButton = false;
            AlternarBtn.Checked = false;
            AlternarBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            AlternarBtn.CheckedForeColor = Color.White;
            AlternarBtn.CheckedImageTint = Color.White;
            AlternarBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            AlternarBtn.Content = "";
            AlternarBtn.DialogResult = DialogResult.None;
            AlternarBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            AlternarBtn.ForeColor = Color.Black;
            AlternarBtn.HoverBackground = Color.White;
            AlternarBtn.HoverForeColor = Color.Black;
            AlternarBtn.HoverImageTint = Color.White;
            AlternarBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            AlternarBtn.Image = (Image)resources.GetObject("AlternarBtn.Image");
            AlternarBtn.ImageAutoCenter = true;
            AlternarBtn.ImageExpand = new Point(0, 0);
            AlternarBtn.ImageOffset = new Point(0, 0);
            AlternarBtn.Location = new Point(26, 12);
            AlternarBtn.Name = "AlternarBtn";
            AlternarBtn.NormalBackground = Color.White;
            AlternarBtn.NormalForeColor = Color.Black;
            AlternarBtn.NormalImageTint = Color.White;
            AlternarBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            AlternarBtn.OutlineThickness = 1F;
            AlternarBtn.PressedBackground = Color.WhiteSmoke;
            AlternarBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            AlternarBtn.PressedImageTint = Color.White;
            AlternarBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            AlternarBtn.Rounding = new Padding(8);
            AlternarBtn.Size = new Size(44, 44);
            AlternarBtn.TabIndex = 0;
            AlternarBtn.TextAlignment = StringAlignment.Center;
            AlternarBtn.TextOffset = new Point(0, 0);
            AlternarBtn.Click += cuiButton4_Click;
            // 
            // gestionCms
            // 
            gestionCms.BackColor = SystemColors.ButtonHighlight;
            gestionCms.ImageScalingSize = new Size(24, 24);
            gestionCms.Items.AddRange(new ToolStripItem[] { gestiónDeCafeteríaToolStripMenuItem, gestiónDeCampusToolStripMenuItem, gestiónDeProveedoresToolStripMenuItem, gestiónDeMarcasToolStripMenuItem, gestiónDeArtículosToolStripMenuItem, gestiónDeRolesToolStripMenuItem, gestionDeUsuariosToolStripMenuItem, gestiónDeEmpleadosToolStripMenuItem });
            gestionCms.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            gestionCms.Name = "gestionCms";
            gestionCms.Size = new Size(274, 293);
            gestionCms.Text = "Gestión";
            // 
            // gestiónDeCafeteríaToolStripMenuItem
            // 
            gestiónDeCafeteríaToolStripMenuItem.Name = "gestiónDeCafeteríaToolStripMenuItem";
            gestiónDeCafeteríaToolStripMenuItem.Size = new Size(273, 32);
            gestiónDeCafeteríaToolStripMenuItem.Text = "Gestión de Cafetería";
            // 
            // gestiónDeCampusToolStripMenuItem
            // 
            gestiónDeCampusToolStripMenuItem.Name = "gestiónDeCampusToolStripMenuItem";
            gestiónDeCampusToolStripMenuItem.Size = new Size(273, 32);
            gestiónDeCampusToolStripMenuItem.Text = "Gestión de Campus";
            // 
            // gestiónDeProveedoresToolStripMenuItem
            // 
            gestiónDeProveedoresToolStripMenuItem.Name = "gestiónDeProveedoresToolStripMenuItem";
            gestiónDeProveedoresToolStripMenuItem.Size = new Size(273, 32);
            gestiónDeProveedoresToolStripMenuItem.Text = "Gestión de Proveedores";
            // 
            // gestiónDeMarcasToolStripMenuItem
            // 
            gestiónDeMarcasToolStripMenuItem.Name = "gestiónDeMarcasToolStripMenuItem";
            gestiónDeMarcasToolStripMenuItem.Size = new Size(273, 32);
            gestiónDeMarcasToolStripMenuItem.Text = "Gestión de Marcas";
            // 
            // gestiónDeArtículosToolStripMenuItem
            // 
            gestiónDeArtículosToolStripMenuItem.Name = "gestiónDeArtículosToolStripMenuItem";
            gestiónDeArtículosToolStripMenuItem.Size = new Size(273, 32);
            gestiónDeArtículosToolStripMenuItem.Text = "Gestión de Artículos";
            // 
            // gestiónDeRolesToolStripMenuItem
            // 
            gestiónDeRolesToolStripMenuItem.Name = "gestiónDeRolesToolStripMenuItem";
            gestiónDeRolesToolStripMenuItem.Size = new Size(273, 32);
            gestiónDeRolesToolStripMenuItem.Text = "Gestión de Roles";
            gestiónDeRolesToolStripMenuItem.Click += gestiónDeTiposDeUsuarioToolStripMenuItem_Click;
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            gestionDeUsuariosToolStripMenuItem.Size = new Size(273, 32);
            gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            gestionDeUsuariosToolStripMenuItem.Click += gestionDeUsuariosToolStripMenuItem_Click;
            // 
            // gestiónDeEmpleadosToolStripMenuItem
            // 
            gestiónDeEmpleadosToolStripMenuItem.Name = "gestiónDeEmpleadosToolStripMenuItem";
            gestiónDeEmpleadosToolStripMenuItem.Size = new Size(273, 32);
            gestiónDeEmpleadosToolStripMenuItem.Text = "Gestión de Empleados";
            // 
            // ventasCms
            // 
            ventasCms.BackColor = SystemColors.ButtonHighlight;
            ventasCms.ImageScalingSize = new Size(24, 24);
            ventasCms.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            ventasCms.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            ventasCms.Name = "gestionCms";
            ventasCms.Size = new Size(160, 68);
            ventasCms.Text = "Gestión";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 32);
            toolStripMenuItem1.Text = "Vender";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(159, 32);
            toolStripMenuItem2.Text = "Consultar";
            // 
            // FormPanel
            // 
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(356, 72);
            FormPanel.Name = "FormPanel";
            FormPanel.OutlineThickness = 1F;
            FormPanel.PanelColor = SystemColors.Control;
            FormPanel.PanelOutlineColor = SystemColors.Control;
            FormPanel.Rounding = new Padding(8);
            FormPanel.Size = new Size(1431, 772);
            FormPanel.TabIndex = 3;
            // 
            // cuiFormAnimator1
            // 
            cuiFormAnimator1.AnimateOnStart = true;
            cuiFormAnimator1.Duration = 600;
            cuiFormAnimator1.EasingType = CuoreUI.Drawing.EasingTypes.QuadOut;
            cuiFormAnimator1.StartOpacity = 0D;
            cuiFormAnimator1.TargetForm = this;
            cuiFormAnimator1.TargetOpacity = 1D;
            // 
            // MainPanel
            // 
            ClientSize = new Size(1787, 844);
            Controls.Add(FormPanel);
            Controls.Add(Topbar);
            Controls.Add(Sidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1809, 873);
            Name = "MainPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGC - KOLAO - UNAPEC";
            FormClosing += MainPanel_FormClosing;
            Load += MainPanel_Load;
            Sidebar.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            Topbar.ResumeLayout(false);
            gestionCms.ResumeLayout(false);
            ventasCms.ResumeLayout(false);
            ResumeLayout(false);

        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            isCollapsed = !isCollapsed;

            Sidebar.Width = isCollapsed ? COLLAPSED_WIDTH : EXPANDED_WIDTH;

            // Actualizar la disposición de los botones
            UpdateButtonsLayout();
        }

        private void UpdateButtonsLayout()
        {
            bool collapsed = Sidebar.Width <= (EXPANDED_WIDTH + COLLAPSED_WIDTH) / 2;
            int currentY = 190; // Posición inicial después del logo

            var orderedButtons = Sidebar.Controls.OfType<CuoreUI.Controls.cuiButton>()
                .Where(b => b != AlternarBtn && b.Name != "cuiPanel1")
                .OrderBy(b =>
                {
                    return b.Name switch
                    {
                        "tableroBtn" => 1, // Tablero
                        "ventasBtn" => 2, // Ventas
                        "gestionBtn" => 3, // Gestión
                        "salirBtn" => 999, // Salir
                        _ => 100
                    };
                })
                .ToList();

            foreach (var button in orderedButtons)
            {
                // Configuración común para ambos estados
                button.TextAlignment = StringAlignment.Center;
                button.ImageAutoCenter = true;

                if (collapsed)
                {
                    button.Content = "";
                    button.Padding = new Padding(0);
                    button.Size = new Size(68, 68);

                    button.Location = new Point(
                        (Sidebar.Width - button.Width) / 2,
                        button.Name == "salirBtn" ? button.Parent.Height - button.Height - 12 : currentY
                    );
                }
                else
                {
                    string buttonText = button.Tag switch
                    {
                        "Tablero" => "   Tablero",
                        "Ventas" => "   Ventas",
                        "Gestión" => "   Gestión",
                        "Salir" => "   Salir",
                        _ => button.Content
                    };

                    button.Content = buttonText;
                    button.Padding = new Padding(0); // Resetear padding para centrado
                    button.Size = new Size(Sidebar.Width - (BUTTON_MARGIN * 2), 68);

                    button.Location = new Point(
                        BUTTON_MARGIN,
                        button.Name == "salirBtn" ? button.Parent.Height - button.Height - 12 : currentY
                    );
                }

                if (button.Name != "salirBtn")
                    currentY += button.Height + 8;
            }

            // Manejar visibilidad de los logos
            if (Logo != null && kolaoLogoK != null)
            {
                Logo.Visible = !collapsed;
                kolaoLogoK.Visible = collapsed;

                if (Logo.Visible)
                {
                    Logo.Location = new Point(
                        (Sidebar.Width - Logo.Width) / 2,
                        Logo.Location.Y
                    );
                }

                if (kolaoLogoK.Visible)
                {
                    kolaoLogoK.Location = new Point(
                        (Sidebar.Width - kolaoLogoK.Width) / 2,
                        kolaoLogoK.Location.Y
                    );
                }
            }
        }

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void ventasBtn_Click(object sender, EventArgs e)
        {
            var button = (CuoreUI.Controls.cuiButton)sender;
            var buttonLocation = button.PointToScreen(new Point(0, button.Height));
            ventasCms.Show(buttonLocation);
        }

        private void gestionBtn_Click(object sender, EventArgs e)
        {
            var button = (CuoreUI.Controls.cuiButton)sender;
            var buttonLocation = button.PointToScreen(new Point(0, button.Height));
            gestionCms.Show(buttonLocation);
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro/a de salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Funcion para abrir los formularios dentro del panel
        private void OpenForm(object openForm)
        {
            if (this.FormPanel.Controls.Count > 0)
                this.FormPanel.Controls.RemoveAt(0);
            Form fh = openForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.FormPanel.Controls.Add(fh);
            this.FormPanel.Tag = fh;
            fh.Show();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            OpenForm(new TableroForm());
            // Restaurar color normal de todos los botones
            tableroBtn.NormalBackground = Color.FromArgb(10, 35, 70); // Color original

            // Resaltar solo el botón activo
            if (FormPanel.Controls.OfType<TableroForm>().Any())
            {
                tableroBtn.NormalBackground = tableroBtn.HoverBackground;
            }
        }

        private void tableroBtn_Click(object sender, EventArgs e)
        {
            // Restaurar colores normales de todos los botones
            tableroBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            ventasBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            gestionBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            
            OpenForm(new TableroForm());

            // Resaltar solo el botón activo
            if (FormPanel.Controls.OfType<TableroForm>().Any())
            {
                tableroBtn.NormalBackground = tableroBtn.HoverBackground;
            }
            else
            {
                tableroBtn.NormalBackground = Color.FromArgb(10, 35, 70); // Color original
            }
        }


        private void gestiónDeTiposDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableroBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            ventasBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            gestionBtn.NormalBackground = Color.FromArgb(10, 35, 70);

            OpenForm(new RolListForm());
            if (FormPanel.Controls.OfType<RolListForm>().Any())
            {
                gestionBtn.NormalBackground = gestionBtn.HoverBackground;
            }
            else
            {
                gestionBtn.NormalBackground = Color.FromArgb(10, 35, 70); // Color original
            }
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableroBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            ventasBtn.NormalBackground = Color.FromArgb(10, 35, 70);
            gestionBtn.NormalBackground = Color.FromArgb(10, 35, 70);

            OpenForm(new UserListForm());
            if (FormPanel.Controls.OfType<UserListForm>().Any())
            {
                gestionBtn.NormalBackground = gestionBtn.HoverBackground;
            }
            else
            {
                gestionBtn.NormalBackground = Color.FromArgb(10, 35, 70); // Color original
            }

        }
    }
}