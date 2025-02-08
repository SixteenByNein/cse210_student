class Scripture()
{



    Reference _reference;

    List<Word> _words;



    public void HideRandomWords(int numberToHide)
    {

        Console.Clear();




    }


    String Text(List<Word> words)
    {

        String result = "";

        foreach (Word item in words)
        {

            if (item.GetHidden())
            {

                result = $"{result} {item.Underscore()}";

            } else
            {

                result = $"{result} {item.GetDisplay()}";

            }

        }

        return result;

    }





    public string GetDisplayText()
    {

        return $"{_reference.GetDisplayText()} {Text(_words)}";

    }

    public bool IsCompletelyHidden()
    {

        return false;

    }


    public void SetRef(Reference r)
    {

        _reference = r;

    }


        public void SetWords(string Text)
    {

        List<Word> parsed = [];

        List<String> separated = Text.Split(' ').ToList();

        foreach (String item in separated)
        {

            Word entry = new Word();

            entry.SetText(item);
            entry.SetHidden(true);

            parsed.Add(entry);

        }


        _words = parsed;


    }













}