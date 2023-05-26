class Scripture
{
    private Reference _reference;
    private bool _isCompletelyHidden;
    private List<string> _words;

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _isCompletelyHidden = false;
        CreateWordList(text);
    }

    public void HideWords()
    {
        _isCompletelyHidden = true;
    }

    public void CreateWordList(string text)
    {
        _words = text.Split(' ').ToList();
    }

    public string GetRenderedText(string type)
    {
        if (_isCompletelyHidden)
        {
            return;
        }

        string renderedText =;
        foreach (string word in _words)
        {
            if (type == "HTML")
            {
                renderedText += "<span class=\"hidden-word\">" + word + "</span> ";
            }
            else if (type == "Markdown")
            {
                renderedText += "`" + word + "` ";
            }
            else
            {
                renderedText += word + " ";
            }
        }

        return renderedText;
    }
}