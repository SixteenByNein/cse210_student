class Reference()
{

string _book;
int _chapter;
int _verse;
int _endVerse;



public void InitializeRef(string book = "Alma", int chapter = 48, int verse = 17, int endVerse = 0)
{

    _book = book;

    _chapter = chapter;

    _verse = verse;

    _endVerse = endVerse;

}


public string GetDisplayText()
{


    //There's probably a more elegant way to do this but it works so I'll take it.

    string endVerseHidden = "";

    if (_endVerse != 0)
    {

        endVerseHidden = $"-{_endVerse}";

    }

    return $"{_book} {_chapter}:{_verse}{endVerseHidden}";

}


}