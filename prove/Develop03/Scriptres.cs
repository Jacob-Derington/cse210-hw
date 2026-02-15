class Scriptres
{
    private string _scripure;

    // public List<string> TheScripture()
    // {
    //     _scripure = "11 And blessed are ye when men shall revile you and persecute, and shall say all manner of evil against you falsely, for my sake;\n12 For ye shall have great joy and be exceedingly glad, for great shall be your reward in heaven; for so persecuted they the prophets who were before you.";
    //     List<string> words = _scripure.Split(' ').ToList();
    //     return words;
    // }

    public void Display()
    {
        _scripure = "\n11 And blessed are ye when men shall revile you and persecute, and shall say all manner of evil against you falsely, for my sake;\n12 For ye shall have great joy and be exceedingly glad, for great shall be your reward in heaven; for so persecuted they the prophets who were before you.";
        List<string> words = _scripure.Split(' ').ToList();
        foreach (string word in words)
        {
            Console.Write(word + " ");
        };
    }

}
    