//EVENTS
using System;

namespace Alisha03_CSIT_6th
{
    // Delegate declaration (optional with built-in EventHandler)
    public delegate void Notify();

    public class Process
    {
        // Event declaration using the delegate
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("\tProcess started!");
            Console.WriteLine("\tProcessing...");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }

    class EventDemo
    {
        public static void Main()
        {
            Process p1 = new Process();
            // Subscribe to the event
            p1.ProcessCompleted += p1_ProcessCompleted;
            p1.StartProcess();
        }

        public static void p1_ProcessCompleted()
        {
            Console.WriteLine("\tProcess Completed!");
        }
    }
}




