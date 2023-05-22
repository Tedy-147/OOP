using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Team
    {
        private static Coach c1, c2, c3, c4, c5;
        private static Goalkeeper g1, g2, g3, g4;
        private static Defender d1, d2, d3, d4, d5, d6, d7, d8;
        private static Midfield m1, m2, m3, m4, m5, m6, m7, m8, m9, m10;
        private static Striker s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;
        private Coach[] coaches = 
        {
            c1 = new Coach("Georgi Mladenov", 42),
            c2 = new Coach("Petar Stavrev", 56),
            c3 = new Coach("Stoqn Kovachev", 38),
            c4 = new Coach("Marin Bozhinov", 60),
            c5 = new Coach("Teodor Parvanov", 45)
        };

        private Goalkeeper[] goalkeepers =
        {
            g1 = new Goalkeeper("Bozhidar Bozhinov", 22, 15, 178),
            g2 = new Goalkeeper("Viktor Enchev", 23, 10, 182),
            g3 = new Goalkeeper("Gabriel Agreste", 24, 2, 175),
            g4 = new Goalkeeper("Ivan Darazhanov", 20, 19, 172),
        };

        private Defender[] defenders =
        {
            d1 = new Defender("Yordan Tachev", 26, 3, 164),
            d2 = new Defender("Viktor Uzunov", 27, 11, 187),
            d3 = new Defender("Yordan Tachev", 25, 5, 167),
            d4 = new Defender("Yordan Tachev", 23, 4, 169),
            d5 = new Defender("Yordan Tachev", 24, 6, 174),
            d6 = new Defender("Yordan Tachev", 30, 13, 184),
            d7 = new Defender("Yordan Tachev", 28, 14, 160),
            d8 = new Defender("Yordan Tachev", 29, 17, 171),
        };

        private Midfield[] mids =
        {
            m1 = new Midfield("Aleksei Donev", 31, 18, 184),
            m2 = new Midfield("Aleksandar Todorov", 24, 1, 180),
            m3 = new Midfield("Dimitar Kovachev", 26, 7, 162),
            m4 = new Midfield("Petar Petkov", 33, 9, 167),
            m5 = new Midfield("Ivan Ivanov", 35, 12, 187),
            m6 = new Midfield("Petko Pehlivanov", 21, 18, 183),
            m7 = new Midfield("Emir Darakchiev", 26, 8, 175),
            m8 = new Midfield("Kaloqn Marinov", 23, 16, 174),
            m9 = new Midfield("Todor Evgeniev", 27, 20, 168),
            m10 = new Midfield("Nikolay Chochev", 29, 28, 167),
        };

        private Striker[] strikers =
        {
            s1 = new Striker("Gordon Ramsay", 42, 22, 185),
            s2 = new Striker("Valeri Bozhinov", 35, 27, 185),
            s3 = new Striker("Kaloqn Kaloqnov", 26, 24, 168),
            s4 = new Striker("Georgi Georgiev", 31, 26, 157),
            s5 = new Striker("Aleksandar Aleksandrov", 23, 23, 182),
            s6 = new Striker("Boris Borisov", 21, 21, 194),
            s7 = new Striker("Nikolay Nikolaev", 20, 25, 182),
            s8 = new Striker("Dimitar Dimitrov", 19, 30, 170),
            s9 = new Striker("Yordan Yordanov", 28, 29, 169),
            s10 = new Striker("Kostadin Kostadinov", 27, 31, 179),
        };
        internal List<Football_player> Players = new List<Football_player>();
        public int AverageAge;

        public void AddPlayersIntoTeam()
        {
            Players.Clear();
            Random indexDef = new Random();
            Random indexGoalk = new Random();
            Random indexMid = new Random();
            Random indexStriker = new Random();
            int d, m, s;
            int g = indexGoalk.Next(0, 3);
            Players.Add(goalkeepers[g]);
            for (int i = 0; i < 3; i++)
            {
                d = indexDef.Next(0, 7);
                Players.Add(defenders[d]);
            }
            for (int i = 0; i < 4; i++)
            {
                m = indexMid.Next(0, 9);
                Players.Add(mids[m]);
            }
            for (int i = 0; i < 3; i++)
            {
                s = indexStriker.Next(0, 9);
                Players.Add(strikers[s]);
            }
            
        }
        
        public void AverageAgeCalculate()
        {
            int age = 0;
            foreach (var player in Players)
            {
                age += player.age;
            }
            AverageAge = age / 11;
        }
        

    }
}
