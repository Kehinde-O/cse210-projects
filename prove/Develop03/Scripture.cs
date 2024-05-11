class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){
        _reference = reference;
        string[] words = text.Split(" ");
        foreach(string word in words){
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord(int numberToHide){
        ///////Get a list of _words that are not hidden
        List<Word> notHidden = new List<Word>();
        foreach(Word word in _words){
            if(!word.IsHidden()){
                notHidden.Add(word);
            }
        }
        Random random = new Random();
        for(int i = 0; i < numberToHide; i++){
            int index = random.Next(notHidden.Count);
            notHidden[index].Hide();
        }
    }

    public bool isCompletelyHidden(){
        foreach(Word word in _words){
            if(!word.IsHidden()){
                return false;
            }
        }
        return true;
    }

    public void GetDisplayText(){
        Console.Write($"{_reference.GetDisplayText()} ");
        foreach(Word word in _words){
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }
        
}