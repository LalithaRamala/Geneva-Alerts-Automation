using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Automation.Send_Mail
{
	public partial class SearchIncident : Form
	{
		public SearchIncident()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string Incident = incident.Text;
			string url = "https://portal.microsofticm.com/imp/v3/incidents/details/" + Incident + "/home";
			ProcessStartInfo sInfo = new ProcessStartInfo(url);
			Process.Start(sInfo);
		}
	}
}
