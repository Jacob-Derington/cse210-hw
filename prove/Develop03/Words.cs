class Words
{
    private string _text;
    private bool _isHidden;

    public Words(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        if (!ISNum())
        {
            _isHidden = true;
        }
        
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public bool ISNum()
    {
        return int.TryParse(_text, out _);
    }

    public string Display()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
   
}