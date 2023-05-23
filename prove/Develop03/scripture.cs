public class Scripture
{
    private Reference _reference;
    private bool _isCompletelyHidden;
    private List<Word> _words;

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _isCompletelyHidden = false;
        CreateWordList(text);
    }

    public bool HideWords()
    {
        if (_isCompletelyHidden)
        {
            return false;
        }

        foreach (Word word in _words)
        {
            word.HideWords();
        }

        return true;
    }

    public void CreateWordList(string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word, _reference.GetScriptureWords());

            _words.Add(newWord);
        }
    }

    public string GetRenderedText(string type)
    {
        string renderedText = "";

        if (type == "reference")
        {
            renderedText = _reference.Display();
        }
        else if (type == "hidden")
        {
            foreach (Word word in _words)
            {
                renderedText += word.GetRenderedText() + " ";
            }
        }
        else if (type == "visible")
        {
            foreach (Word word in _words)
            {
                word.ShowWords();

                renderedText += word.GetRenderedText() + " ";
            }
        }

        return renderedText.TrimEnd();
    }
}
