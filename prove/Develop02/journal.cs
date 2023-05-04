class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string fileName)
    {
        // TODO: Implement saving to a file
    }

    public void LoadFromFile(string fileName)
    {
        // TODO: Implement loading from a file
    }
}