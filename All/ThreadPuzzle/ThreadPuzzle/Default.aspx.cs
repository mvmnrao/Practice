using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.IO;

namespace ThreadPuzzle
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStartThreads_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            int noOfThreads = Convert.ToInt16(txtBoxNoOfThreads.Text.Trim());

            for (int i = 1; i <= noOfThreads; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(callBackMethod));
            }
            
        }

        private void callBackMethod(object obj)
        {
            //lblMsg.Text = lblMsg.Text + Thread.CurrentThread.ManagedThreadId.ToString() + " Time: " + DateTime.Now.ToString() + "<br/>";

            //string str = "alert('" + Thread.CurrentThread.ManagedThreadId.ToString() + " Time: " + DateTime.Now.ToString() + "');";
            lock()
            {
            StreamWriter sw = new StreamWriter(@"D:\Manik\Practice\ThreadPuzzle\msg.txt", true);
            sw.Write("\r\n" + Thread.CurrentThread.ManagedThreadId.ToString() + " Time: " + DateTime.Now.ToString());

            sw.Flush();
            sw.Close();
            }

            Thread.Sleep(5000);
        }
    }
}
