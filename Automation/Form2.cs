using Automation.Send_Mail;
using System;
using System.Windows.Forms;

namespace Automation
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void submitBtn_Click(object sender, EventArgs e)
		{
			string To = toEmail.Text;
			string CC = ccEmail.Text;
			string EmailSubject = subjectEmail.Text;
			string Body = bodyEmail.Text;

			string bodyMessage = "Hi Team," + " " + "<br><br>" + Body + " " + "<br><br> Thanks and Regards," + " " + "<br> Mohit Kothiyal.";

			SendMail sendMail = new SendMail();
			sendMail.Send(To, CC, EmailSubject, bodyMessage, true);



		}
	}
}
