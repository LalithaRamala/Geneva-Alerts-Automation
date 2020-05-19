namespace Automation.Send_Mail
{
	public class SendMail
	{
		public void Send(string toEmailAddress, string ccEmailAddress, string subject, string body, bool IsHTML)
		{
			Microsoft.Office.Interop.Outlook.Application olApp = new Microsoft.Office.Interop.Outlook.Application();
			Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)olApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
			mailItem.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML;

			mailItem.To = toEmailAddress;
			mailItem.CC = ccEmailAddress;
			mailItem.Subject = subject;
			mailItem.HTMLBody = body;

			mailItem.Send();
			mailItem = null;
			olApp = null;

		}
	}
}
