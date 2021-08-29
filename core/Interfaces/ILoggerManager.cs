using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta.Core.Interfaces
{
   public interface ILoggerManager
    {
        void Info(string message);
        void Error(string message);
        void Warn(string message);

        void Debug(string message);
    }
}
