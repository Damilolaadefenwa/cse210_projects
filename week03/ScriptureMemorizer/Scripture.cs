using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _entries;

    public Scripture(string referenceText, string scriptureText)
    {
        _reference = new Reference(referenceText, 1, 1, 1); // Replace 1, 1, 1 with appropriate chapter, startVerse, and endVerse values
        _entries = scriptureText.Split(' ').Select(word => new Word(word, false)).ToList();
    }

    public void GetDisplayText()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine(string.Join(" ", _entries.Select(Word => Word.GetDisplayText())));
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _entries.Count / 3 + 1); //Hide 1 to 1/3 of the remaining words

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_entries.Count);
            _entries[index].Hide();
        }

    }

    public bool IsCompletelyHidden()
    {
        return _entries.All(word => word.isHidden());
    }


}