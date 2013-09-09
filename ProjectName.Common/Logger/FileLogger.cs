using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectName.Interfaces.Common;
using System.Web;

namespace ProjectName.Common.Logger
{
    public class FileLogger: ILogger
    {
        #region ILogger Members

        public void Info(string message)
        {
            
        }

        public void Warn(string message)
        {
            
        }

        public void Debug(string message)
        {
            
        }

        public void Error(string message)
        {
            
        }

        public void Error(string message, Exception x)
        {
            
        }

        public void Error(Exception x)
        {
            
        }

        public void Fatal(string message)
        {
            
        }

        public void Fatal(Exception x)
        {
            
        }

   
        public void LogError(Exception ex, string source)
        {
            try
            {
                String LogFile = HttpContext.Current.Request.MapPath("/Errorlog.txt");
                if (LogFile != "")
                {
                    String Message = String.Format("{0}{0}=== {1} ==={0}{2}{0}{3}{0}{4}{0}{5}"
                             , Environment.NewLine
                             , DateTime.Now
                             , ex.Message
                             , source
                             , ex.InnerException
                             , ex.StackTrace);
                    byte[] binLogString = Encoding.Default.GetBytes(Message);

                    System.IO.FileStream loFile = new System.IO.FileStream(LogFile
                              , System.IO.FileMode.OpenOrCreate
                              , System.IO.FileAccess.Write, System.IO.FileShare.Write);
                    loFile.Seek(0, System.IO.SeekOrigin.End);
                    loFile.Write(binLogString, 0, binLogString.Length);
                    loFile.Close();
                }
            }
            catch { /*No need to catch the error here. */}
        }

        #endregion
    }
}
