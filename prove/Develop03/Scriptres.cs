using System;
using System.Collections.Generic;
using System.Linq;

class Scriptres
{
    private List<Words> _words;
    private Random _random = new Random();

    public Scriptres()
    {
        string text = "And blessed are ye when men shall revile you and persecute, and shall say all manner of evil against you falsely, for my sake; \nFor ye shall have great joy and be exceedingly glad, for great shall be your reward in heaven; for so persecuted they the prophets who were before you.";
        
        _words = new List<Words>();

        string[] splitWords = text.Split(' ');

        for (int i = 0; i < splitWords.Length; i++)
        {
            _words.Add(new Words(splitWords[i]));
        }
    }

    public void Display()
    {        
        Console.Write("3 Nephi 12:11-12 ");
        foreach (Words word in _words)
        {
            Console.Write(word.Display() + " ");
        };
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        int hiddenCount = 0;

        while (hiddenCount < count && !_words.All(w => w.IsHidden()))
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
    