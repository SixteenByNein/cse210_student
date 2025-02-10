class Scripture()
{



    Reference _reference;

    List<Word> _words;

    int remaining;



    public bool HideRandomWords(int numberToHide)
    {

        Random rnd = new Random();

        Console.Clear();

        if(remaining > numberToHide)
        {
        remaining = remaining - numberToHide;
        } else
        {

            remaining = 0;

        }

        Console.WriteLine($"{remaining} words remaining");


        if(remaining > 0)
        {

        for(int i = 0; i < numberToHide; i++)
        {

        int target = rnd.Next(1, _words.Count());

        //prevents the program from trying to hide the same word twice

        while(_words[target].GetHidden())
        {

            target = rnd.Next(1, _words.Count());

        }


        _words[target].SetHidden(true);

        }

        return false;

        } else
        {

            foreach(Word item in _words)
            {

                item.SetHidden(true);

            }

            return true;

        }


    }


    String Text(List<Word> words, bool mode)
    {

        String result = "";

        foreach (Word item in words)
        {

            if (item.GetHidden())
            {

                result = $"{result} {item.Underscore(mode)}";

            } else
            {

                result = $"{result} {item.GetDisplay()}";

            }

        }

        return result;

    }





    public string GetDisplayText(bool mode)
    {

        return $"{_reference.GetDisplayText()} {Text(_words, mode)}";

        

    }



    public void SetRef(Reference r)
    {

        _reference = r;

    }


    //Instead of manually creating each instance of Word, I wrote this method to convert each word in a string to an unhidden Word instance.
    public void SetWords(string Text)
    {

        List<Word> parsed = [];

        List<String> separated = Text.Split(' ').ToList();

        foreach (String item in separated)
        {

            Word entry = new Word();

            entry.SetText(item);
            entry.SetHidden(false);

            parsed.Add(entry);

        }


        _words = parsed;
        remaining = _words.Count();


    }













}