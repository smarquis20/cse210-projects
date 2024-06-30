// Class will create a scripture provided by the reference and text
public class Scripture
{
    // Will hold a list of each word as a Word object
    private List<Word> _words = new List<Word>{};

    // Reference hold the scripture locations BOOK,CHAPTER,VERSE
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        // Holds book,chapter,verse
        _reference = reference;
        // List that will split the text string by spaces and insert into a list
        string[] wordList = text.Split(' ');

        // Foreach loop will create a new Word object for each word in the text string and add each word to the list
        foreach (string word in wordList)
        {
            Word splitWord = new Word(word);
            _words.Add(splitWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Initialize lists for words that are visable and list to hold the index numbers of each word
        List<Word> visible = new List<Word>();
        List<int> index = new List<int>();
        // Creates a new random object to help randomize the word indexes
        Random random = new Random();

        // Foreach loop will add each word that is still visable to a list
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visible.Add(word);
            }
        }

        // if the number of words is less than the numberToHide it will set numberToHide to the correct number
        numberToHide = Math.Min(numberToHide, visible.Count);

        // Foreach loop will add the index number for each visable word to a list to be randomized
        for(int i = 0; i < visible.Count(); i++)
        {
            index.Add(i);
        }
        
        // Website that helped with shuffling the indexes randomly
        // https://exceptionnotfound.net/understanding-the-fisher-yates-card-shuffling-algorithm/
        for (int i = index.Count() - 1; i > 0; i--)
        {
            int ranIndex = random.Next(i + 1);

            int temp = index[i];
            index[i] = index[ranIndex];
            index[ranIndex] = temp;
        }

        // Will hide numberToHide words randomly 
        for (int i = 0; i < numberToHide; i++)
        {
            visible[index[i]].Hide();
        }
    }
    
    // Method to put the Reference to all the individual words or underscores together
    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();
        string verse = "";

        foreach (Word word in _words)
        {
            string displayWord = word.GetDisplayText();
            verse += displayWord + " ";
        }

        string completeVerse = refText + " " + verse;

        return completeVerse;
    }

    // Method to track whether all words have been hidden or not.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }
}