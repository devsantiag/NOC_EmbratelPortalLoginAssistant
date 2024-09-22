/*
 * Date: 20/09/2024
 * Time: 11:38
 */
namespace NOC_EmbratelPortalLoginAssistant
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button jsl;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		
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
			this.jsl = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// jsl
			// 
			this.jsl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jsl.Location = new System.Drawing.Point(2, 6);
			this.jsl.Name = "jsl";
			this.jsl.Size = new System.Drawing.Size(90, 37);
			this.jsl.TabIndex = 0;
			this.jsl.Text = "JSL";
			this.jsl.UseVisualStyleBackColor = true;
			this.jsl.Click += new System.EventHandler(this.JslClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(96, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 37);
			this.button2.TabIndex = 1;
			this.button2.Text = "INTERMÉDICA";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(190, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 37);
			this.button3.TabIndex = 2;
			this.button3.Text = "MOVIDA";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(284, 6);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 37);
			this.button4.TabIndex = 3;
			this.button4.Text = "CENTAURO";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(376, 47);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.jsl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "NOC_EmbratelPortalLoginAssistant";
			this.ResumeLayout(false);

		}
	}
}