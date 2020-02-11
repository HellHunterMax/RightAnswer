using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connection { get; private set; }

        public static void InitializeConnection()
        {
            SqlConnector connector = new SqlConnector();
            Connection.Add(connector);
        }
    }
}
