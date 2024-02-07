using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentCounter
{
    public class Recentcount
    {
        Queue<int> queue;

        public Recentcount()
        {
            this.queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);

            while (queue.Peek() < t - 3000)
            {
                queue.Dequeue();
            }

            return queue.Count;
        }
    }

}
