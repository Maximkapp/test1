class Program
{
    static void Main()
    {
        string[] results = { "3:1", "2:2", "0:1", "4:2", "3:a", "3-12"};
        int team1Points = 0;
        int team2Points = 0;

        foreach (var result in results)
        {
            string[] parts = result.Split(':');

            if (parts.Length == 2)
            {
                if (int.TryParse(parts[0], out int team1Goals) && int.TryParse(parts[1], out int team2Goals))
                {
                    if (team1Goals > team2Goals)
                    {
                        team1Points += 3;
                    }
                    else if (team1Goals < team2Goals)
                    {
                        team2Points += 3;
                    }
                    else
                    {
                        team1Points++;
                        team2Points++;
                    }
                }
            }
        }

        Console.WriteLine("Количество очков для команды №1: " + team1Points);
        Console.WriteLine("Количество очков для команды №2: " + team2Points);
    }
}