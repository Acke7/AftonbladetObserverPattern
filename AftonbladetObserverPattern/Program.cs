using AftonbladetObserverPattern.Observers;
using AftonbladetObserverPattern.Subject;

namespace AftonbladetObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var publisher = new Publisher();
            var observerA = new Client("Ahmad"); 
            publisher.Attach(observerA);

            var observerB = new Client("alice");
            publisher.Attach(observerB);

            var observerC = new Client("adsad");
            publisher.Attach(observerC);

            // Övning 1
            publisher.ReleaseNewMaterial();

            // Övning 2
            publisher.Detach(observerC);

            // Övning 3
         

            // Övning 4
            publisher.ReleaseNewMaterial();
        }
    }
}