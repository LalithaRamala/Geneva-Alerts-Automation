using System;

namespace Automation.Recive_Mail
{
	public class InboxProp
	{

		public string Name { get; set; }
		public string EmailTo { get; set; }
		public string EmailFrom { get; set; }
		public string EmailSubject { get; set; }
		public string EmailBody { get; set; }
		public string CC { get; set; }
		public string ConversationID { get; set; }
		public DateTime DateTime { get; set; }
		public string EntryID { get; set; }
	}
}
