using Automation.Send_Mail;
using System;
using System.Windows.Forms;

namespace Automation
{
	public partial class NavForm : Form
	{
		public NavForm()
		{
			InitializeComponent();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
		
		}
	
		private void button1_Click(object sender, EventArgs e)
		{
			InboxForm form2 = new InboxForm();
			form2.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SearchIncident form2 = new SearchIncident();
			form2.ShowDialog();
		}
	}
}
