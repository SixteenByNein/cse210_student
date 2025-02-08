class Word()
{

    string _text;
    bool _isHidden;




    public void SetText(String input)
    {

        _text = input;

    }

    public void SetHidden(bool input)
    {

        _isHidden = input;

    }



    public void Hide()
    {



    }

    public void Show()
    {



    }

    public bool GetHidden()
    {

        return _isHidden;

    }

    public String Underscore()
    {

        String result = "";

        foreach (char i in _text)
        {

            result = $"{result}{i}";

        }

        return result;


    }

    public string GetDisplay()
    {

        return _text;

    }

}