using AftonbladetObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AftonbladetObserverPattern.Observers
{
    internal class Client: IObserver
    {
        public string Name { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public void Update(Publisher pub)
        {
            Console.WriteLine("Linda: Thanks for the story.");
        }
    }
}
