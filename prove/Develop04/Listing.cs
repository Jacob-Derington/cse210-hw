class Listing
{
    private List<string> _listThis;
    private Random _random = new Random();

    public Listing()
    {
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

        _listThis.Add("Who are people that you appreciate?");
        _listThis.Add("What are personal strengths of yours?");
        _listThis.Add("Who are people that you have helped this week?");
        _listThis.Add("When have you felt the Holy Ghost this month?");
        _listThis.Add("Who are some of your personal heroes?");
        _listThis.Add("");

        
    }
}