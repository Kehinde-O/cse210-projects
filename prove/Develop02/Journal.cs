using System.IO; 
class Journal{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry){
        _entries.Add(entry);
    }

    public void DisplayAll(){
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }

    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries){
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file){
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string promp_text = parts[1];
            string entry_text = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = promp_text;
            entry._entryText = entry_text;
            
            _entries.Add(entry);
        }
    }
}