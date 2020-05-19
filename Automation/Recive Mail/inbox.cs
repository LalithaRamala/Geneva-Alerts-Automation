using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;

namespace Automation.Recive_Mail
{
	public class Inbox
	{

		public List<InboxProp> ReadMailItem()
		{
			Application outlookApplication = null;
			NameSpace outlookNameSpace = null;
			MAPIFolder inbox = null;
			Items mailItems = null;

			List<InboxProp> listOutlookEmails = new List<InboxProp>();
			InboxProp emailDetails;

			try
			{
				outlookApplication = new Application();
				outlookNameSpace = outlookApplication.GetNamespace("MAPI");
				inbox = outlookNameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
				
				var filterDate = DateTime.UtcNow.Date;
				string name = "IcM Incident Management";
				string filter = "[ReceivedTime] > '" + string.Format("{0:ddddd h:nn AMPM}", filterDate.ToShortDateString()) + "'";
				mailItems = inbox.Items.Restrict(filter);
				string filter1 = "[SenderName]= '" + name + "'";
				var Mails = mailItems.Restrict(filter1);
				mailItems.Sort("[ReceivedTime]", OlSortOrder.olAscending);
				


				foreach (dynamic item in Mails)
				{

					emailDetails = new InboxProp();
					emailDetails.EmailFrom = item.SenderEmailAddress;
					emailDetails.Name = item.SenderName;
					emailDetails.EmailSubject = item.Subject;
					emailDetails.EmailBody = item.Body;
					emailDetails.ConversationID = item.ConversationID;
					emailDetails.EntryID = item.EntryID;
					emailDetails.DateTime = item.CreationTime;
					listOutlookEmails.Add(emailDetails);
					ReleaseComObject(item);
				}

			}
			catch (System.Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				ReleaseComObject(mailItems);
				ReleaseComObject(inbox);
				ReleaseComObject(outlookNameSpace);
				ReleaseComObject(outlookApplication);
			}
			return listOutlookEmails;
		}
		private static void ReleaseComObject(object obj)
		{
			if (obj != null)
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
				obj = null;
			}
		}
	}
}
