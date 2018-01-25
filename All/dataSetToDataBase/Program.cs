using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using Oracle.DataAccess.Client;
using OracleHelper;
using CryptoStatic;
using System.IO;

namespace dataSetToDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.startOperation();
        }

        public void startOperation()
        {
            DataSet ds = new DataSet();

            string connectionString = ConfigurationManager.ConnectionStrings["oracleConnectionString"].ConnectionString;
            //ds = OracleHelperClass.ExecuteDataset(CryptoStaticClass.Decrypt(connectionString),
            //                                      CommandType.StoredProcedure,
            //                                      "MCS_BALLOTRETURNNOTIFIC_PKG.GETMEMBEREMAILSLIST_PRC",
            //                                      new OracleParameter("P_CurEmailList", OracleDbType.RefCursor, ParameterDirection.Output));
            //if (ds != null && ds.Tables.Count > 0)
            //{
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        dr.Delete();
            //    }
            //    ds.Tables[0].AcceptChanges();
            //}

            OracleConnection oCon = new OracleConnection(CryptoStaticClass.Decrypt(connectionString));
            OracleDataAdapter oAdapt = new OracleDataAdapter("Select * From email_notification where rownum < 10", oCon);

            //oAdapt.DeleteCommand = new OracleCommand("Delete from email_notification where send_to = @send_to and cc_1 = @cc_1 and cc_2 = @cc_2 and formatted_ballot = @formatted_ballot", oCon);

            DataTable tbl=new DataTable();
            oAdapt.Fill(tbl);
            tbl.TableName = "SentNotifications";
            StringWriter sw = new StringWriter();
            tbl.WriteXml(sw);
            string emailXML = sw.ToString();
            OracleCommand oCmd = new OracleCommand("MCS_BALLOTRETURNNOTIFIC_PKG.DELETESENTNOTIFICATIONS_PRC", oCon);
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Parameters.Add("@P_SentList", OracleDbType.Varchar2).Value = emailXML;
            if (oCon.State != ConnectionState.Open)
                oCon.Open();
            int i = oCmd.ExecuteNonQuery();

            Console.WriteLine(i.ToString());

            //if (tbl != null && tbl.Rows.Count > 0)
            //{
            //    tbl.Columns["Send_To"].Unique = true;
            //    foreach (DataRow dr in tbl.Rows)
            //    {
            //        dr.Delete();
            //    }
            //}

            //int count = oAdapt.Update(tbl);

            Console.ReadKey();
        }

    }
}
