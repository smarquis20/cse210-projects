public class Word
{
    private string _text;
    private bool _isHidden;

    // Will create the Word object
    public Word(string text)
    {
        _text = text;
    }

    // Method to mark a word as hidden
    public void Hide()
    {
       _isHidden = true;
    }

    // Method to mark a word as visable
    public void Show()
    {
       _isHidden = false;
    }

    // Method to find out if a word is hidden or not
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method will return underscores if hidden and the word if it is not marked as hidden.
    public string GetDisplayText()
    {
        if(_isHidden)
        {
            return "____";
        }
        else
        {
            return _text;
        }
    }
}