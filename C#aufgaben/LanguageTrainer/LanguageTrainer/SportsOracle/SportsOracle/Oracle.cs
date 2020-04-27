using System;

namespace SportsOracle
{
    static class Oracle
    {
        //For random numbers:
        private static readonly Random OracleRandom = new Random();

        private static bool TryParseTeams(string teams, out string team1, out string team2)
        {
            //Take a teams string (i. e. "Germany - Italy") and split it into two parts.
            //Assign them to "team1" and "team2" (i. e. "team1 = Germany, team2 = Italy").
            //Return true on success and false on parse errors.
            //Hint: Use Split(...) method on string.

            string[] parts = teams.Split('-');

            if (parts.Length != 2)
            {
                team1 = null;
                team2 = null;

                return false;
            }

            team1 = parts[0].Trim(); //Remove whitespaces from front and back ...
            team2 = parts[1].Trim();

            if ((team1.Length < 1) || (team2.Length < 1))
            {
                return false;
            }

            return true;
        }

        public static void PredictResult(string teams)
        {
            string team1, team2;

            if (!TryParseTeams(teams, out team1, out team2))
            {
                Console.WriteLine("Bad team format for result prediction.");
                return;
            }

            int team1Result = OracleRandom.Next(0, 11);
            int team2Result = OracleRandom.Next(0, 11);

            Console.WriteLine("========== Result Oracle ==========");
            Console.WriteLine("{0} vs. {1}:   {2} : {3}", team1, team2, team1Result, team2Result);

            if (team1Result != team2Result)
            {
                Console.WriteLine("{0} will win!", (team1Result > team2Result) ? team1 : team2);
            }
            else
            {
                Console.WriteLine("It will be a tie!");
            }

            Console.WriteLine("===================================\n");
        }

        public static void PredictExtraTime(string teams)
        {
            string team1, team2;

            if (!TryParseTeams(teams, out team1, out team2))
            {
                Console.WriteLine("Bad team format for extra time prediction.");
                return;
            }

            Console.WriteLine("========== Extra Time Oracle ==========");

            switch (OracleRandom.Next(3))
            {
            case 0: Console.WriteLine("The match terminates after 90 minutes."); break;
            case 1: Console.WriteLine("There are 2x15 minutes of extra time."); break;
            default: Console.WriteLine("There are 2x15 minutes of extra time and penalty shoot-outs."); break;
            }

            Console.WriteLine("=======================================\n");
        }

        public static void PredictRedCards(string teams)
        {
            string team1, team2;

            if (!TryParseTeams(teams, out team1, out team2))
            {
                Console.WriteLine("Bad team format for red cards prediction.");
                return;
            }

            int team1Cards = OracleRandom.Next(0, 3);
            int team2Cards = OracleRandom.Next(0, 3);

            Console.WriteLine("========== Cards Oracle ==========");
            Console.WriteLine("{0} red cards for {1}, {2} red cards for {3}", team1Cards, team1, team2Cards, team2);
            Console.WriteLine("==================================\n");
        }
    }
}
