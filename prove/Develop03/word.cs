class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }
public string GetRenderedText()
    {
        if (_isHidden)
        {
            return "****";
        }
        else
        {
            return _word;
        }
    }
}