using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Data;

public class DataReciever
{
    public readonly Dictionary<string, string> Data;    
    public DataReciever()
    {
            Data = new Dictionary<string, string>();    
    }

    public void Upsert(string key , string value)
    {
        Data[key] = value;
        Console.WriteLine($"Upsert: {key} - {value}");
    }

    public void Delete(string key)
    {
        if (Data.ContainsKey(key))
        {
            Data.Remove(key);
            Console.WriteLine($"Removed: {key}");
        }
    }
}
