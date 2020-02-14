using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzUI
{
    public static class ThreadSafeRoom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisTreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + System.Threading.Thread.CurrentThread.ManagedThreadId)));  }
        }
    }
}
