using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectName.Interfaces.Common;
using System.IO;

namespace ProjectName.Common.Logger
{
    public class TextLogger: ILogger
    {

        #region ILogger Members

        public void Info(string message)
        {
            //
        }

        public void Warn(string message)
        {
            //
        }

        public void Debug(string message)
        {
            //
        }

        public void Error(string message)
        {
            {
                FileStream fileStream = null;
                StreamWriter streamWriter = null;
                try
                {
                    string logFilePath = "c:\\LogError\\";

                    logFilePath = logFilePath + "ProgramLog" + "-" + DateTime.Today.ToString("yyyyMMdd") + "." + "txt";

                    if (logFilePath.Equals("")) return;
                    #region Create the Log file directory if it does not exists
                    DirectoryInfo logDirInfo = null;
                    FileInfo logFileInfo = new FileInfo(logFilePath);
                    logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
                    if (!logDirInfo.Exists) logDirInfo.Create();
                    #endregion Create the Log file directory if it does not exists

                    if (!logFileInfo.Exists)
                    {
                        fileStream = logFileInfo.Create();
                    }
                    else
                    {
                        fileStream = new FileStream(logFilePath, FileMode.Append);
                    }
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.WriteLine(message);
                }
                finally
                {
                    if (streamWriter != null) streamWriter.Close();
                    if (fileStream != null) fileStream.Close();
                }

            }
        }

        public void Error(string message, Exception x)
        {
            //
        }

        public void Error(Exception x)
        {
            Error(CreateErrorMessage(x));
        }

        public void Fatal(string message)
        {
            //
        }

        public void Fatal(Exception x)
        {
            //
        }

        #endregion

        private static string CreateErrorMessage(Exception serviceException)
        {
            StringBuilder messageBuilder = new StringBuilder();
            try
            {
                messageBuilder.Append("The Exception is:-");

                messageBuilder.Append("Exception :: " + serviceException.ToString());
                if (serviceException.InnerException != null)
                {

                    messageBuilder.Append("InnerException :: " + serviceException.InnerException.ToString());
                }
                return messageBuilder.ToString();
            }
            catch
            {
                messageBuilder.Append("Exception:: Unknown Exception.");
                return messageBuilder.ToString();
            }

        }

        #region ILogger Members


        public void LogError(Exception ex, string source)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
