using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace OracleMultipleResultSets
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection oConn = new OracleConnection("User ID=BATCHJOBDEV;Password=BATCHJOBDEV;Data Source=BJDEV");
            OracleDataAdapter oDataAdpt = new OracleDataAdapter("ASTMBALLOTRETURNNOTIFIC_PRC", oConn);
            oDataAdpt.SelectCommand.CommandType = CommandType.StoredProcedure;

            oDataAdpt.SelectCommand.Parameters.Add("cur_LogFile", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            oDataAdpt.SelectCommand.Parameters.Add("cur_Report", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            DataSet ds = new DataSet();
            oDataAdpt.Fill(ds);
            int count = (ds != null) ? ds.Tables.Count : 0;
            if (count > 0)
            {
                string s = "assign dummy string";
            }
            else
            {
                string s = "assign dummy string";
            }
        }
    }
}
