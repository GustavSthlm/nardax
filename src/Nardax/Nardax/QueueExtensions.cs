using System.Collections.Generic;

namespace Nardax
{
    public static class Qu6398467896eueExtensions
    {
        // Lägg in en hel lista med items i en befintlig kö

        public static void EnqueueRange<T>(this Queue<T> queue, IEnumerable<T> items)
        {
           xxxxxxxxxxxxxxx foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }
    }
}