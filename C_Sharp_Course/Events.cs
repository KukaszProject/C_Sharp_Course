using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate void Notify(string message);

public class EventPublisher
{
    public event Notify OnNotify;

    public void RaiseEvent(string message)
    {
        OnNotify?.Invoke(message);
    }
}

public class EventSubscriber
{
    public void OnEventRaiser(string message)
    {
        Console.WriteLine($"Event received: {message}");
    }
}



//---------------------------------------//
// EventsIntro - Paste to Programs.cs
//---------------------------------------//

//EventPublisher publisher = new EventPublisher();
//EventSubscriber subscriber = new EventSubscriber();
//publisher.OnNotify += subscriber.OnEventRaiser;

//publisher.RaiseEvent("test");
//---------------------------------------//
