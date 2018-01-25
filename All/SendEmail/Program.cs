using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using aspNetEmail;
using System.Configuration;
using OracleHelper;
using Oracle.DataAccess.Client;

namespace SendEmail
{
    class Program
    {
        int SuccessCount = 0;
        int FailureCount = 0;        

        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            DataTable emailList = new DataTable();

            OracleParameter[] oracleParameter = new OracleParameter[1];
            //oracleParameter[0] = new OracleParameter("P_Date", OracleDbType.Varchar2, ParameterDirection.Input) 
            //                                        { Value = DateTime.Now.Date.ToString("yyyyMMdd") };
            //oracleParameter[1] = new OracleParameter("P_CurLogFile", OracleDbType.RefCursor, ParameterDirection.Output);
            //oracleParameter[2] = new OracleParameter("P_CurReport", OracleDbType.RefCursor, ParameterDirection.Output);

            oracleParameter[0] = new OracleParameter("P_CurEmailList", OracleDbType.RefCursor, ParameterDirection.Output);

            string connectionString = ConfigurationManager.ConnectionStrings["AppConnectionString"].ConnectionString;
            ds = OracleHelperClass.ExecuteDataset(connectionString, 
                                                  CommandType.StoredProcedure,
                                                  "MCS_BALLOTRETURNNOTIFIC_PKG.GETMEMBEREMAILSLIST_PRC", 
                                                  oracleParameter);

            if (ds != null && ds.Tables.Count > 0)
                emailList = ds.Tables[0];

            EmailMessage msg = new EmailMessage();
            bool SuccessfulSend;

            msg.MergedRowSent += new MergedRowSentEventHandler(msg_MergedRowSent);

            msg.Server = ConfigurationManager.AppSettings["host"].ToString();
            msg.ValidateAddress = false;

            msg.FromAddress = ConfigurationManager.AppSettings["from"].ToString();
            msg.FromName = ConfigurationManager.AppSettings["fromName"].ToString();
            msg.Subject = "sample appended with required string  " + "##Formatted_Ballot##";

            //make sure body is cleared, so we don't keep appending
            msg.ClearBody();
            msg.AppendBodyFromFile(@"E:\Manik\Practice\SendEmail\EmailTemplate.html");
            msg.BodyFormat = aspNetEmail.MailFormat.Html;

            msg.IgnoreRecipientErrors = true;

            msg.To = "##Send_To##";
            msg.AddCc("##CC_1##");
            msg.AddCc("##CC_2##");
            //msg.AddCc("##CC_3##");

            //!!***FOR TESTING
            msg.To = "mmurukutla@allianceglobalservices.com";

            SuccessfulSend = msg.SendMailMerge(emailList, 2, 250);
            Console.ReadKey();
        }

        static void msg_MergedRowSent(object sender, MergedRowSentEventArgs e)
        {         
            Program prog = new Program();
            EmailMessage msg = (EmailMessage)sender;
            DataRow dr = e.Row;
            string emailAddress = dr["Send_To"].ToString();

            if (e.Success)
            {
                prog.SuccessCount += 1;

                //Write to TEMP table to keep track of sent items in case a recovery becomes necessary
                //this also deletes the current table once items are definitely sent

                //success = PublicCode.RecordSentItem(EmailLetterNumber, dr("EMAIL"), _
                //    dr("CC_1"), dr("CC_2"), dr("CC_3"), _
                //    dr("FORMATTED_BALLOT"), dr("FORMATTED_COMMITTEE"), dr("SALUTATION"), _
                //    dr("FORMATTED_CLOSE_DT"), dr("PERCENT_RETURNED"), dr("RETURNS_NEEDED"))
                Console.WriteLine("Success: " + prog.SuccessCount);
            }
            else
            {
                prog.FailureCount += 1;
                Console.WriteLine("Success: " + prog.FailureCount);
            }            
        }
    }
}
