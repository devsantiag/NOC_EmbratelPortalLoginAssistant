﻿/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 22/09/2024
 * Time: 14:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_EmbratelPortalLoginAssistant
{
	partial class PortalWeb
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// PortalWeb
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1164, 738);
			this.Name = "PortalWeb";
			this.Text = "PortalWeb";
			this.ResumeLayout(false);

		}
	}
}
