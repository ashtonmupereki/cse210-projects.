class Scripture
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

    public void HideWords()
    {
        _isCompletelyHidden = true;
        foreach (Word word in _words)
        {
            word.HideWord();
        }
    }

    public void CreateWordList(string text)
    {
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word, false));
        }
    }

    public string GetRenderedText(string type)
    {
        if (_isCompletelyHidden)
        {
            return "This scripture is completely hidden.";
        }

        string renderedText =;
        foreach (Word word in _words)
        {
            if (word.GetRenderedText() == "****")
            {
                renderedText += "**** ";
            }
            else if (type == "HTML")
            {
                renderedText += "<span class=\"hidden-word\">" + word.GetRenderedText() + "</span> ";
            }
            else if (type == "Markdown")
            {
                renderedText += "`" + word.GetRenderedText() + "` ";
            }
            else
            {
                renderedText += word.GetRenderedText() + " ";
            }
        }

        return renderedText;
    }
}