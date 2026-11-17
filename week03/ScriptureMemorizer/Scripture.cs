using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture (Reference Reference, string text)
    {
        _reference = Reference;
        string[] w = text.Split(' ');
        foreach(string wordText in w)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word>visibleWords = new List<Word>();
        Random randomGenerator = new Random();

        foreach(Word visible in _words)
        {
             if (visible.IsHidden() == false)
            {
                visibleWords.Add(visible);
            }

        }

        int wordsToHide = numberToHide;
        if (visibleWords.Count < numberToHide)
        {
            wordsToHide = visibleWords.Count;
        }

        for (int h = 0; h < wordsToHide; h++ )
        {
            int number = randomGenerator.Next(0, visibleWords.Count);

            visibleWords[number].Hide();
            visibleWords.RemoveAt(number);
        }
        
    }

    public string GetDisplayText()
    {
        string DisplayText = _reference.GetDisplayText() + " ";
        foreach(Word word in _words)
        {
           DisplayText += word.GetDisplayText() + " ";
        }

        return DisplayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
           if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
        
    }
}