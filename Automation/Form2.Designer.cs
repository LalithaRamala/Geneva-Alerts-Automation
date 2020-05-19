namespace Automation
{
	partial class Form2
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
			this.submitBtn = new System.Windows.Forms.Button();
			this.bodyEmail = new System.Windows.Forms.TextBox();
			this.emailBody = new System.Windows.Forms.Label();
			this.subjectEmail = new System.Windows.Forms.TextBox();
			this.EmailSubject = new System.Windows.Forms.Label();
			this.ccEmail = new System.Windows.Forms.TextBox();
			this.emailCc = new System.Windows.Forms.Label();
			this.toEmail = new System.Windows.Forms.TextBox();
			this.emailTo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// submitBtn
			// 
			this.submitBtn.Location = new System.Drawing.Point(152, 530);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.Size = new System.Drawing.Size(117, 48);
			this.submitBtn.TabIndex = 19;
			this.submitBtn.Text = "Send";
			this.submitBtn.UseVisualStyleBackColor = true;
			this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
			// 
			// bodyEmail
			// 
			this.bodyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bodyEmail.Location = new System.Drawing.Point(152, 169);
			this.bodyEmail.Multiline = true;
			this.bodyEmail.Name = "bodyEmail";
			this.bodyEmail.Size = new System.Drawing.Size(1138, 338);
			this.bodyEmail.TabIndex = 18;
			this.bodyEmail.Text = "\r\n\r\n\r\n\r\n\r\n";
			// 
			// emailBody
			// 
			this.emailBody.AutoSize = true;
			this.emailBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailBody.Location = new System.Drawing.Point(7, 172);
			this.emailBody.Name = "emailBody";
			this.emailBody.Size = new System.Drawing.Size(150, 26);
			this.emailBody.TabIndex = 17;
			this.emailBody.Text = "Body           :";
			// 
			// subjectEmail
			// 
			this.subjectEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subjectEmail.Location = new System.Drawing.Point(152, 118);
			this.subjectEmail.Name = "subjectEmail";
			this.subjectEmail.Size = new System.Drawing.Size(692, 32);
			this.subjectEmail.TabIndex = 16;
			// 
			// EmailSubject
			// 
			this.EmailSubject.AutoSize = true;
			this.EmailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailSubject.Location = new System.Drawing.Point(7, 121);
			this.EmailSubject.Name = "EmailSubject";
			this.EmailSubject.Size = new System.Drawing.Size(148, 26);
			this.EmailSubject.TabIndex = 15;
			this.EmailSubject.Text = "Subject       :";
			// 
			// ccEmail
			// 
			this.ccEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ccEmail.Location = new System.Drawing.Point(152, 69);
			this.ccEmail.Name = "ccEmail";
			this.ccEmail.Size = new System.Drawing.Size(692, 32);
			this.ccEmail.TabIndex = 14;
			// 
			// emailCc
			// 
			this.emailCc.AutoSize = true;
			this.emailCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailCc.Location = new System.Drawing.Point(7, 72);
			this.emailCc.Name = "emailCc";
			this.emailCc.Size = new System.Drawing.Size(144, 26);
			this.emailCc.TabIndex = 13;
			this.emailCc.Text = "Email (CC) :";
			// 
			// toEmail
			// 
			this.toEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toEmail.Location = new System.Drawing.Point(152, 20);
			this.toEmail.Name = "toEmail";
			this.toEmail.Size = new System.Drawing.Size(692, 32);
			this.toEmail.TabIndex = 12;
			// 
			// emailTo
			// 
			this.emailTo.AutoSize = true;
			this.emailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTo.Location = new System.Drawing.Point(7, 23);
			this.emailTo.Name = "emailTo";
			this.emailTo.Size = new System.Drawing.Size(143, 26);
			this.emailTo.TabIndex = 11;
			this.emailTo.Text = "Email (To)  :";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1330, 596);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.bodyEmail);
			this.Controls.Add(this.emailBody);
			this.Controls.Add(this.subjectEmail);
			this.Controls.Add(this.EmailSubject);
			this.Controls.Add(this.ccEmail);
			this.Controls.Add(this.emailCc);
			this.Controls.Add(this.toEmail);
			this.Controls.Add(this.emailTo);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button submitBtn;
		private System.Windows.Forms.Label emailBody;
		private System.Windows.Forms.Label EmailSubject;
		private System.Windows.Forms.Label emailCc;
		private System.Windows.Forms.Label emailTo;
		public System.Windows.Forms.TextBox bodyEmail;
		public System.Windows.Forms.TextBox subjectEmail;
		public System.Windows.Forms.TextBox ccEmail;
		public System.Windows.Forms.TextBox toEmail;
	}
}