using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Game
    {
        private List<Football_player> team1 = new List<Football_player>();
        private List<Football_player> team2 = new List<Football_player>();
        private Referee referee = new Referee("Georgi Bozhinov", 42);
        private Referee firstAssistantRef = new Referee("Ivan Georgiev", 52);
        private Referee secondAssistantRef = new Referee("Kaloqn Dobrinov", 34);
        private List<string> Goals = new List<string>();
        public string GameResult { get; set; }
        public string Winner { get; set; }

        public void AddBothTeamsPlayers()
        {
            Team team = new Team();
            team.AddPlayersIntoTeam();
            team1.AddRange(team.Players);
            team.AddPlayersIntoTeam();
            team2.AddRange(team.Players);
        }

        public void Match()
        {
            int t1counter = 0, t2counter = 0;
            Random goals = new Random();
            Random player = new Random();
            Random team = new Random();
            Random minute = new Random();
            int pindex, t, g, m;
            g = goals.Next(0, 30);
            for (int i = 0; i < g; i++)
            {
                t = team.Next(1, 80);
                if (t%2 != 0)
                {
                    m = minute.Next(1, 90);
                    pindex = player.Next(1, 10);
                    Goals.Add($"Minute {m} - {team1[pindex].name} from Team 1");
                    t1counter++;
                }
                else if (t%2 == 0)
                {
                    m = minute.Next(1, 90);
                    pindex = player.Next(1, 10);
                    Goals.Add($"Minute {m} - {team2[pindex].name} from Team 2");
                    t2counter++;
                }
            }

            if (t1counter > t2counter)
            {
                Winner = "TEAM 1 IS THE WINNER!";
                GameResult = $"{t1counter} - {t2counter}";
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"--------- {Winner} --------");
                Console.WriteLine();
                Console.WriteLine($"-------------- {GameResult} ------------------");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----------------------------------------");
            }
            else if (t2counter > t1counter)
            {
                Winner = "TEAM 2 IS THE WINNER!";
                GameResult = $"{t1counter} - {t2counter}";
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"--------- {Winner} --------");
                Console.WriteLine();
                Console.WriteLine($"-------------- {GameResult} ------------------");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----------------------------------------");
            }
            else if (t1counter == t2counter)
            {
                Winner = "There is no winner! The teams are EVEN!";
                GameResult = $"{t1counter} - {t2counter}";
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();
                Console.WriteLine($" {Winner}");
                Console.WriteLine();
                Console.WriteLine($"-------------- {GameResult} ------------------");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----------------------------------------");
            }
        }

    }
}
