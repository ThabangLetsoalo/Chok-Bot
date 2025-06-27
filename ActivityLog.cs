using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ActivityLog
    {
        private readonly List<string> logEntries = new List<string>();

        public void Log(string message)
        {
            string timestampedMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            logEntries.Add(timestampedMessage);
        }

        public IEnumerable<string> GetLogs()
        {
            return logEntries;
        }

        public void ClearLog()
        {
            logEntries.Clear();
        }
    }
}
