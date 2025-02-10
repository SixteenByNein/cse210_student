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

    public String Underscore(bool mode)
    {

        String result = "";

        int reps = 0;

        foreach (char i in _text)
        {

            

            //replaces only letters, leaving punctuation.

            if (char.IsLetter(i))
            {

                if (mode && reps == 0)
            {

                result = $"{result}{i}";

            } else{

                result = $"{result}{"_"}";

                }
            }
            else
            {

                result = $"{result}{i}";

            }

            reps = reps + 1;

        }

        return result;


    }

    public string GetDisplay()
    {

        return _text;

    }

}