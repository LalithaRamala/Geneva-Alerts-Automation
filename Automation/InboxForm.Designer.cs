﻿namespace Automation
{
	partial class InboxForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Inbox = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(1, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1473, 546);
			this.dataGridView1.TabIndex = 0;
			// 
			// Inbox
			// 
			this.Inbox.Location = new System.Drawing.Point(12, 3);
			this.Inbox.Name = "Inbox";
			this.Inbox.Size = new System.Drawing.Size(140, 45);
			this.Inbox.TabIndex = 1;
			this.Inbox.Text = "Inbox";
			this.Inbox.UseVisualStyleBackColor = true;
			this.Inbox.Click += new System.EventHandler(this.Inbox_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(158, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "Click";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// InboxForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1521, 612);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Inbox);
			this.Controls.Add(this.dataGridView1);
			this.Name = "InboxForm";
			this.Text = "InboxForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Inbox;
		private System.Windows.Forms.Button button1;
	}
}