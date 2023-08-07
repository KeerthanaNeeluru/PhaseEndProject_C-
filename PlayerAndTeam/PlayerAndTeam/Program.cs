using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
           t. AddPlayer(new Players(7, "MS Dhoni", 42));
            t.AddPlayer(new Players(18, "Virat Kohli", 34));
            t.AddPlayer(new Players(45, "Rohit Sharma", 36));
            t.AddPlayer(new Players(8, "R Jadeja", 34));
            t.AddPlayer(new Players(33, "Hardik Pandya", 29));
            char ch;
            do
            {
                Console.WriteLine("Select \n1.Add Player to team\n2.Remove a player from team\n3.Get player details by passing player id\n4.Get details by passing player name\n5.View all players ");
                int select=int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Enter player Id");
                        int id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter player name");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter Player Age");
                        int age=int.Parse(Console.ReadLine());
                        Players p=new Players(id,name,age);
                        Console.WriteLine("---------------------------------------------------------------------");
                        t.AddPlayer(p);
                        t.ViewPlayers();
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Enter player id");
                        int pid=int.Parse(Console.ReadLine());
                        Console.WriteLine("---------------------------------------------------------------------");
                        t.RemovePlayer(pid);
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Enter player id");
                        int playerid=int.Parse(Console.ReadLine());
                        Players PWithId = t.GetDetailById(playerid);
                        Console.WriteLine("---------------------------------------------------------------------");
                        if (PWithId != null)
                        {
                            Console.WriteLine($"Player details with id :{PWithId}\nName : {PWithId.Name}\tAge : {PWithId.Age}");
                        }
                        else
                        {
                            Console.WriteLine($"There is no player in team with id {PWithId}");
                        }
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Enter player name");
                        string pname=Console.ReadLine();
                        List<Players> PWithName= t.GetDetailByName(pname);
                        Console.WriteLine("---------------------------------------------------------------------");
                        if (PWithName.Count > 0)
                        {
                            Console.WriteLine($"Players With name  {pname} details : ");
                            foreach(Players player in PWithName)
                            {
                                Console.WriteLine($"Player Id : {player.Id}\nPlayer Age : {player.Age}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"There is no player in team with Named {pname}");
                        }
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Player details");
                        Console.WriteLine("---------------------------------------------------------------------");
                        t.ViewPlayers();
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;
                    default:
                        break;

                }
                Console.WriteLine("IF you want to continue press y");
                ch = char.Parse(Console.ReadLine().ToLower());
            } while (ch == 'y');
        }
    }
}
