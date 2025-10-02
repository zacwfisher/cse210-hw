// Scripture class

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture() =>
        Console.WriteLine(GetRenderedText());

    public void HideWords()
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        int wordsToHideThisTurn = Math.Min(3, visibleWords.Count);

        for (int i = 0; i < wordsToHideThisTurn; i++)
        {
            if (visibleWords.Count == 0) break;
            int indexToHide = _random.Next(0, visibleWords.Count);
            visibleWords[indexToHide].Hide();
            visibleWords.RemoveAt(indexToHide);
        }
    }

    public string GetRenderedText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
            displayText += " " + word.GetDisplayText();
        return displayText;
    }

    public bool IsCompletelyHidden() => _words.All(word => word.IsHidden());
}
