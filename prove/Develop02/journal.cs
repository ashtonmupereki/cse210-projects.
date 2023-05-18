class Journal
{
 private List<Entry> entries;

 public Journal()
 {
 entries = new List<Entry>();
 }

 public void AddEntry(Entry entry)
 {
 entries.Add(entry);
 }

 public void DisplayEntries()
 {
 foreach (Entry entry in entries)
 {
 Console.WriteLine(entry.ToString());
 }
 }

 public void SaveToFile(string fileName)
 {
 using (StreamWriter writer = new StreamWriter(fileName))
 {
 foreach (Entry entry in entries)
 {
 writer.WriteLine(entry.ToString());
 }
 }
 }

 public void LoadFromFile(string fileName)
 {
 using (StreamReader reader = new StreamReader(fileName))
 {
 string line;
 while ((line = reader.ReadLine()) != null)
 {
 string[] parts = line.Split(',');
 string prompt = parts[0];
 string response = parts[1];
 DateTime date = DateTime.Parse(parts[2]);
 Entry entry = new Entry(prompt, response, date);
 entries.Add(entry);
 }
 }
 }
}
