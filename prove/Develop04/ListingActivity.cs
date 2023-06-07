class ListingActivity
{
    private int _seconds;
    private List<ListedItem> _items = new List<ListedItem>();

    public void startListing(int seconds)
    {
        _seconds = seconds;
        Console.WriteLine($"Starting listing activity for {_seconds} seconds...");
        listedItemCount();
    }

    private void listedItemCount()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed < TimeSpan.FromSeconds(_seconds))
        {
            Console.WriteLine($"You have {_items.Count} items listed.");
            Thread.Sleep(2000);
        }

        stopwatch.Stop();
        Console.WriteLine($"Listing activity complete! You listed items for {_seconds} seconds.");
    }

    public void AddItem(string name, string description)
    {
        _items.Add(new ListedItem(name, description));
    }
}

class ListedItem
{
    public string Name { get; set; }
    public string Description { get; set; }

    public ListedItem(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
