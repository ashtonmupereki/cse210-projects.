class DataAccess
{
    public List<Scripture> LoadFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        // read the file
        string lines = File.ReadAllLines(filename);

        // loop through each line and create a scripture object
        foreach (string line in lines)
        {
            // split the line into reference and text
            string parts = line.Split('|');
            string referenceString = parts[0];
            string text = parts[1];

            // create the reference object
            string referenceParts = referenceString.Split(':');
            string book = referenceParts[0];
            int chapter = int.Parse(referenceParts[1]);
            int verse = int.Parse(referenceParts[2]);
            Reference reference = new Reference(book, chapter, verse);

            // create the scripture object and add it to the list
            Scripture scripture = new Scripture(text, reference);
            scriptures.Add(scripture);
        }

        return scriptures;
    }
}