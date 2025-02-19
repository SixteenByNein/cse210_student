class ListingActivity : Activity
{


TextEffects fx = new();

List<String> prompts = [
"What are your favorite creations of God?",
"What events built your testimony of Christ?",
"What has the Holy Ghost taught you recently?",
"How have you taken Christ's name upon you this week?",
"How have you come closer to Christ this week?"
];

    public override string GetMenu()
    
    {

    return "Listing activity";

    }

    public override bool Run()
    {

        fx.Plaque("This activity will help you consider blessings you have in your life.");

        Random rand = new();

        string prompt = prompts[rand.Next(prompts.Count())];
        
        fx.Spinner($"{prompt}\nGet ready...");

        Console.WriteLine(prompt);

        DateTime deadline = DateTime.Now.AddSeconds(15);

        while(DateTime.Now < deadline)
        {

            Console.ReadLine();

        }



        return true;

    }

}