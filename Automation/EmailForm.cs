using System;
using System.Data;
using System.Windows.Forms;

namespace Automation
{
	public partial class EmailForm : Form
	{
		public EmailForm(string name,string subject,string body)
		{
			InitializeComponent();
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("EmailSubject", typeof(string));
			dataTable.Columns.Add("Body", typeof(string));
			dataTable.Rows.Add(name, subject, body);
			dataGridView1.DataSource = dataTable;

		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
		
		}
	}
}
