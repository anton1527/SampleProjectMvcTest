using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectName.Common.Logger;
using ProjectName.Interfaces.Common;

namespace ProjectName.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger mylogger = new TextLogger();

            int i = 15;
            int d = 0;

            try
            {
                int rs = i / d;
            }
            catch (Exception ex)
            {
                mylogger.Error(ex);              
            }

        }
    }
}
