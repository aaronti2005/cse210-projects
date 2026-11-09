using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
       _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompText}|{entry._entryText}|{entry._mood}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
            string mood = parts[3];

            Entry load = new Entry();
            load._date = date;
            load._prompText = prompt;
            load._entryText = text;
            load._mood = mood;

            _entries.Add(load);
        }
    }
}
