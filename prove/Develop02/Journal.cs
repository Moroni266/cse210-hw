using System.ComponentModel.Design;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(file, json);
        Console.WriteLine($"Data stored in {file}");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string json = File.ReadAllText(file);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
            Console.WriteLine("The data was successfully loaded!");
        }
        else
        {
            Console.WriteLine($"The file {file} was not found!!");
        }
    }
}