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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label title;
		
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
			this.title = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// jsl
			// 
			this.jsl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jsl.Location = new System.Drawing.Point(2, 29);
			this.jsl.Name = "jsl";
			this.jsl.Size = new System.Drawing.Size(90, 32);
			this.jsl.TabIndex = 0;
			this.jsl.Text = "JSL";
			this.jsl.UseVisualStyleBackColor = true;
			this.jsl.Click += new System.EventHandler(this.JslClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(96, 29);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 32);
			this.button2.TabIndex = 1;
			this.button2.Text = "INTERMÉDICA";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(190, 29);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 32);
			this.button3.TabIndex = 2;
			this.button3.Text = "MOVIDA";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(284, 29);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 32);
			this.button4.TabIndex = 3;
			this.button4.Text = "CENTAURO";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.White;
			this.title.Location = new System.Drawing.Point(0, 4);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(143, 19);
			this.title.TabIndex = 0;
			this.title.Text = "NOC_EmbratelLogin";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SlateGray;
			this.panel1.Controls.Add(this.title);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(384, 27);
			this.panel1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(375, 65);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.jsl);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "NOC_EmbratelPortalLoginAssistant";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}