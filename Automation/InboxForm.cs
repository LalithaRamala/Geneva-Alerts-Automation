using Automation.Recive_Mail;
using Automation.Send_Mail;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Automation
{
	public partial class InboxForm : Form
	{
		public InboxForm()
		{
			InitializeComponent();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void Inbox_Click(object sender, System.EventArgs e)
		{
			Inbox inbox = new Inbox();
			var result = inbox.ReadMailItem();
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("EmailSubject", typeof(string));
			dataTable.Columns.Add("Date", typeof(string));
			dataTable.Columns.Add("BODY", typeof(string));
			foreach (var item in result)
			{
				dataTable.Rows.Add(item.Name, item.EmailSubject,item.DateTime,item.EmailBody);
				dataGridView1.DataSource = dataTable;
			}	
			
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			EmailForm emailForm = new EmailForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
			   emailForm.ShowDialog();


		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			SearchIncident form2 = new SearchIncident();
			form2.ShowDialog();
		}
	}
}
