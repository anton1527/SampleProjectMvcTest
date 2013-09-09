using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectName.Interfaces.Common;

namespace ProjectName.Common.Logger
{
    public class DatabaseLogger : ILogger
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
            //
        }

        public void Error(string message, Exception x)
        {
            //
        }

        public void Error(Exception x)
        {
            //
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

        #region ILogger Members


        public void LogError(Exception ex, string source)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
