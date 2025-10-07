using System.Windows.Forms;

namespace SGC_UNAPEC
{
    partial class MainPanel : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private CuoreUI.Controls.cuiPanel Sidebar;
        private CuoreUI.Controls.cuiPictureBox Logo;
        private CuoreUI.Controls.cuiPanel Topbar;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton tableroBtn;
        private CuoreUI.Controls.cuiButton salirBtn;
        private CuoreUI.Controls.cuiButton gestionBtn;
        private CuoreUI.Controls.cuiButton ventasBtn;
        private CuoreUI.Controls.cuiButton AlternarBtn;
        private CuoreUI.Controls.cuiPictureBox kolaoLogoK;
        private ContextMenuStrip gestionCms;
        private ToolStripMenuItem gestiónDeCafeteríaToolStripMenuItem;
        private ToolStripMenuItem gestiónDeCampusToolStripMenuItem;
        private ToolStripMenuItem gestiónDeProveedoresToolStripMenuItem;
        private ToolStripMenuItem gestiónDeMarcasToolStripMenuItem;
        private ToolStripMenuItem gestiónDeArtículosToolStripMenuItem;
        private ToolStripMenuItem gestiónDeRolesToolStripMenuItem;
        private ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem gestiónDeEmpleadosToolStripMenuItem;
        private ContextMenuStrip ventasCms;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator1;
        public CuoreUI.Controls.cuiPanel FormPanel;
    }
}
