class Entry
{
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime Date { get; set; }

    public Entry(string title, string body, DateTime date)
    {
        Title = title;
        Body = body;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Title} - {Date.ToShortDateString()}\n{Body}";
    }
}