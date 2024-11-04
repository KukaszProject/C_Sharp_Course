using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//public delegate void TemperatureChangeHandler(string message);

public class TemperatureChangedEventArgs : EventArgs
{
    public int Temperature { get; }
    public TemperatureChangedEventArgs(int temperature)
    {
        Temperature = temperature;
    }
}


public class TemperatureMonitor
{
    public EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

   // public event TemperatureChangeHandler OnTemperatureChanged;

    private int _temperature;
    public int Temperature 
    { 
        get 
        { 
            return _temperature;  
        } 
        set
        {
            if(_temperature != value)
            {
                _temperature = value;   
                // RAISE THE EVENT
                OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
            }
        }
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        // Letting every subscriber know!
        TemperatureChanged?.Invoke(this, e);
    }
}

// Subscriber

public class TemperatureAlert
{
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Alert: temperature is {e.Temperature}, sender is {sender}");
    }
}

public class CoolingAlert
{
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Cooling Alert: temperature is {e.Temperature}, sender is {sender}");
    }
}



//----------------------------------//
// TempEvent - Paste to Program.cs
//----------------------------------//

//TemperatureMonitor monitor = new TemperatureMonitor();
//TemperatureAlert alert = new TemperatureAlert();
//monitor.TemperatureChanged += alert.OnTemperatureChanged;
//CoolingAlert alert2 = new CoolingAlert();
//monitor.TemperatureChanged += alert2.OnTemperatureChanged;
//monitor.Temperature = 20;
//Console.WriteLine("Please enter the temperature: ");
//monitor.Temperature = int.Parse(Console.ReadLine());

