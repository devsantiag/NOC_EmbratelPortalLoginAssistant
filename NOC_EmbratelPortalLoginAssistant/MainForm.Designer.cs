/*
 * Date: 20/09/2024
 * Time: 11:38
 */
namespace NOC_EmbratelPortalLoginAssistant
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonIntermedica;
		private System.Windows.Forms.Button buttonMovida;
		private System.Windows.Forms.Button buttonCentauro;
		private System.Windows.Forms.Button buttonJSL;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.buttonIntermedica = new System.Windows.Forms.Button();
			this.buttonMovida = new System.Windows.Forms.Button();
			this.buttonCentauro = new System.Windows.Forms.Button();
			this.buttonJSL = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonIntermedica
			// 
			this.buttonIntermedica.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIntermedica.Location = new System.Drawing.Point(195, 6);
			this.buttonIntermedica.Name = "buttonIntermedica";
			this.buttonIntermedica.Size = new System.Drawing.Size(90, 37);
			this.buttonIntermedica.TabIndex = 2;
			this.buttonIntermedica.Text = "INTERMÉDICA";
			this.buttonIntermedica.UseVisualStyleBackColor = true;
			this.buttonIntermedica.Click += new System.EventHandler(this.ButtonIntermedicaClick);
			// 
			// buttonMovida
			// 
			this.buttonMovida.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMovida.Location = new System.Drawing.Point(99, 6);
			this.buttonMovida.Name = "buttonMovida";
			this.buttonMovida.Size = new System.Drawing.Size(90, 37);
			this.buttonMovida.TabIndex = 3;
			this.buttonMovida.Text = "MOVIDA";
			this.buttonMovida.UseVisualStyleBackColor = true;
			this.buttonMovida.Click += new System.EventHandler(this.ButtonMovidaClick);
			// 
			// buttonCentauro
			// 
			this.buttonCentauro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCentauro.Location = new System.Drawing.Point(291, 6);
			this.buttonCentauro.Name = "buttonCentauro";
			this.buttonCentauro.Size = new System.Drawing.Size(90, 37);
			this.buttonCentauro.TabIndex = 0;
			this.buttonCentauro.Text = "CENTAURO";
			this.buttonCentauro.UseVisualStyleBackColor = true;
			this.buttonCentauro.Click += new System.EventHandler(this.ButtonCentauroClick);
			// 
			// buttonJSL
			// 
			this.buttonJSL.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonJSL.Location = new System.Drawing.Point(3, 6);
			this.buttonJSL.Name = "buttonJSL";
			this.buttonJSL.Size = new System.Drawing.Size(90, 37);
			this.buttonJSL.TabIndex = 1;
			this.buttonJSL.Text = "JSL";
			this.buttonJSL.UseVisualStyleBackColor = true;
			this.buttonJSL.Click += new System.EventHandler(this.ButtonJSLClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(384, 47);
			this.Controls.Add(this.buttonJSL);
			this.Controls.Add(this.buttonCentauro);
			this.Controls.Add(this.buttonMovida);
			this.Controls.Add(this.buttonIntermedica);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "NOC_EmbratelPortalLoginAssistant";
			this.ResumeLayout(false);

		}
	}
}