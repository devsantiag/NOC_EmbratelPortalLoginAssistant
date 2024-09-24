/*
 * Date: 20/09/2024
 * Time: 11:38
 */
namespace NOC_EmbratelPortalLoginAssistant
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStripMenuItem tripJsl;
        private System.Windows.Forms.ToolStripMenuItem tripMovida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tripCentauro;
        private System.Windows.Forms.ToolStripMenuItem tripIntermedica;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.tripJsl = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.tripMovida = new System.Windows.Forms.ToolStripMenuItem();
        	this.tripCentauro = new System.Windows.Forms.ToolStripMenuItem();
        	this.tripIntermedica = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// tripJsl
        	// 
        	this.tripJsl.Name = "tripJsl";
        	this.tripJsl.Size = new System.Drawing.Size(35, 20);
        	this.tripJsl.Text = "JSL";
        	this.tripJsl.Click += new System.EventHandler(this.TripJslClick);
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
        	this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
        	this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tripJsl,
			this.tripMovida,
			this.tripCentauro,
			this.tripIntermedica});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
        	this.menuStrip1.Size = new System.Drawing.Size(1409, 24);
        	this.menuStrip1.TabIndex = 4;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// tripMovida
        	// 
        	this.tripMovida.Name = "tripMovida";
        	this.tripMovida.Size = new System.Drawing.Size(59, 20);
        	this.tripMovida.Text = "Movida";
        	this.tripMovida.Click += new System.EventHandler(this.TripMovidaClick);
        	// 
        	// tripCentauro
        	// 
        	this.tripCentauro.Name = "tripCentauro";
        	this.tripCentauro.Size = new System.Drawing.Size(68, 20);
        	this.tripCentauro.Text = "Centauro";
        	this.tripCentauro.Click += new System.EventHandler(this.TripCentauroClick);
        	// 
        	// tripIntermedica
        	// 
        	this.tripIntermedica.Name = "tripIntermedica";
        	this.tripIntermedica.Size = new System.Drawing.Size(82, 20);
        	this.tripIntermedica.Text = "Intermédica";
        	this.tripIntermedica.Click += new System.EventHandler(this.TripIntermedicaClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.Menu;
        	this.ClientSize = new System.Drawing.Size(1409, 751);
        	this.Controls.Add(this.menuStrip1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MainMenuStrip = this.menuStrip1;
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.Text = "NOC_EmbratelPortalLoginAssistant";
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
    }
}
