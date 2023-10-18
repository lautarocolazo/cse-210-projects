public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        random = new Random();

        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideWords(int count)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            Word wordToHide = visibleWords[index];
            wordToHide.Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetRenderedText()
    {
        List<string> renderedWords = new List<string>();

        foreach (Word word in _words)
        {
            renderedWords.Add(word.GetRenderedText());
        }

        return string.Join(" ", renderedWords);
    }

    public string GetRenderedReference()
    {
        return _reference.GetRenderedText();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }

        return true;
    }
}

