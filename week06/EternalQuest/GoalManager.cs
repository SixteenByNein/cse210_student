class GoalManager()
{

    List<Goal> _goals = [];
    int _score = 0;




    //Creativity: Dynamic text rendering effects.
    TextEffects fx = new TextEffects();


    public void Start()
    {


        fx.LinePrint([
            $"You have {_score} points.",
            "",
            "Menu:",
            " 1. Create New Goal",
            " 2. List Goals",
            " 3. Save Goals to file",
            " 4. Load Goals from file",
            " 5. Record",
            " 6. Quit",
        ]);

        Console.Write("--> ");

        string command = Console.ReadLine();



        if(command == "1")
        {

            CreateGoal();

        }else if(command == "2")
        {

            ListGoalNames(true);

        }else if(command == "3")
        {

            SaveGoals();

        }else if(command == "4")
        {

            LoadGoals();

        }else if(command == "5")
        {

            RecordEvent();

        }else if(command == "6")
        {

            Console.Clear();
            fx.Marquee("See you next time!");
            Console.WriteLine("");

        }else
        {

            Console.Clear();

            fx.Marquee("INPUT NOT RECOGNIZED");
            Console.Clear();
            Start();

        }


    }

    public void ListGoalNames(bool hold)
    {

        int index = 1;

        List<string> displayed = [];

        foreach(Goal item in _goals)
        {

            displayed.Add(item.GetTitle(index));

            index = index + 1;

        }

        fx.LinePrint(displayed);

        if(hold)
        {
        Console.ReadLine();

        Start();
        }

    }

    public void ListGoalDetails()
    {



    }

    public void CreateGoal()
    {


        fx.LinePrint([
            "What type of goal would you like to set?",
            "",
            " 1. One-time goal",
            " 2. Eternal goal",
            " 3. Multi-Part goal",
            " 4. Return"
        ]);

        Console.Write("--> ");
        
        string command = Console.ReadLine();

        if(command == "1")
        {

        SimpleGoal goalFocus = new SimpleGoal();

            Console.Clear();
            fx.Marquee("What is the name of your goal?");
            Console.WriteLine("");
            Console.Write("--> ");
            goalFocus.SetName(Console.ReadLine());


            fx.Marquee("Description?");
            Console.WriteLine("");
            Console.Write("--> ");
            goalFocus.SetDescription(Console.ReadLine());

            bool validInt = false;

            while(!validInt)
            {

            fx.Marquee("How many points is it worth?");
            Console.WriteLine("");
            Console.Write("--> ");
            string pointInput = Console.ReadLine();

            int intPoints = 0;

            if(int.TryParse(pointInput, out intPoints))
            {

                validInt = true;

            }
            else
            {

                fx.Marquee("INVALID INPUT! USE ONLY ARABIC NUMERALS");
                Console.WriteLine("");
                validInt = false;

            }

            goalFocus.SetPoints(intPoints);

            }

        _goals.Add(goalFocus);

        Console.WriteLine("");

        fx.Marquee("--Goal added--", 20 ,1000);

        Start();




        }else if(command == "2")
        {

        EternalGoal goalFocus = new EternalGoal();

            Console.Clear();
            fx.Marquee("What is the name of your goal?");
            Console.WriteLine("");
            Console.Write("--> ");
            goalFocus.SetName(Console.ReadLine());


            fx.Marquee("Description?");
            Console.WriteLine("");
            Console.Write("--> ");
            goalFocus.SetDescription(Console.ReadLine());

        _goals.Add(goalFocus);

        Console.WriteLine("");

        fx.Marquee("--Goal added--", 20 ,1000);

        Start();

        }else if(command == "3")
        {

                ChecklistGoal goalFocus = new ChecklistGoal();

            Console.Clear();
            fx.Marquee("What is the name of your goal?");
            Console.WriteLine("");
            Console.Write("--> ");
            goalFocus.SetName(Console.ReadLine());


            fx.Marquee("Description?");
            Console.WriteLine("");
            Console.Write("--> ");
            goalFocus.SetDescription(Console.ReadLine());

            bool validInt = false;

            int intDenom = 0;

            while(!validInt)
            {

            fx.Marquee("How many times until this goal is complete?");
            Console.WriteLine("");
            Console.Write("--> ");
            string denomInput = Console.ReadLine();

            if(int.TryParse(denomInput, out intDenom))
            {

                validInt = true;

            }
            else
            {

                fx.Marquee("INVALID INPUT! USE ONLY ARABIC NUMERALS");
                Console.WriteLine("");
                validInt = false;

            }
            }

            goalFocus.SetDenominator(intDenom);



            validInt = false;

            while(!validInt)
            {

            fx.Marquee("How many points is it worth?");
            Console.WriteLine("");
            Console.Write("--> ");
            string pointInput = Console.ReadLine();

            int intPoints = 0;

            if(int.TryParse(pointInput, out intPoints))
            {

                validInt = true;

            }
            else
            {

                fx.Marquee("INVALID INPUT! USE ONLY ARABIC NUMERALS");
                Console.WriteLine("");
                validInt = false;

            }

            goalFocus.SetPoints(intPoints);

            }

        _goals.Add(goalFocus);

        Console.WriteLine("");

        fx.Marquee("--Goal added--", 20 ,1000);

        Start();

        }
        
        else if(command == "4")
        {

            Start();

        }else
        {

            Console.Clear();

            fx.Marquee("INPUT NOT RECOGNIZED");
            Console.Clear();
            CreateGoal();

        }
        
    }

    public void RecordEvent()
    {

        fx.Marquee("Which goal have you completed?");
        ListGoalNames(false);
        Console.Write("--> ");

        bool validInt = false;

        string input = Console.ReadLine();

        int inputInt = 1;

        while(!validInt)
        {

            if(int.TryParse(input, out inputInt))
            {

                validInt = true;

            }else
            {

                fx.Marquee("--INVALID INPUT--");

                Console.WriteLine();

            }

        }

        if(!_goals[inputInt-1].IsCompleteBool())
        {

        _goals[inputInt-1].MarkComplete(true);

        _score = _score + _goals[inputInt-1].addPoints();

        }

        Start();

    }

    public void SaveGoals()
    {



    }

    public void LoadGoals()
    {



    }

}