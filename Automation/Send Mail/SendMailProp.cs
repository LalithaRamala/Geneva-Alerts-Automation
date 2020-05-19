using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Send_Mail
{
	public class SendMailProp
	{
		public string To { get; set; }
		public string CC { get; set; }
		public string EmailSubject { get; set; }
		public string Body { get; set; }
		public bool IsHTML { get; set; }
	}
}
