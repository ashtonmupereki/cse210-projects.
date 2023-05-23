public class Word
{
    private string _word;
    private bool _isHidden;
    private string[] _scripture;

    public Word(string word, string[] scripture)
    {
        _word = word;
        _isHidden = false;
        _scripture = scripture;
    }

    public void HideWords()
    {
        _isHidden = true;
    }

    public void ShowWords()
    {
        _isHidden = false;
    }

    public string GetRenderedText()
    {
        string renderedText = "";

        if (_isHidden)
        {
            // Replace scripture words with dashes
            string[] words = _word.Split(' ');

            foreach (string word in words)
            {
                if (_scripture.Contains(word.ToLower()))
                {
                    string hiddenWord = new string('-', word.Length);
                    renderedText += hiddenWord + " ";
                }
                else
                {
                    renderedText += word + " ";
                }
            }
        }
        else
        {
            renderedText = _word;
        }

        // Add formatting
        renderedText = "<b>" + renderedText.TrimEnd() + "</b>";

        return renderedText;
    }
}
