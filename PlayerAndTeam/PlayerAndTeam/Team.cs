using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    public class Team
    {
        private List<Players> players;
        public Team() 
        {
            players= new List<Players>();
            
        }
        public void AddPlayer(Players player)
        {
            

            if (players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine("Player added into the team");
            }
            else
            {
                Console.WriteLine("Team is already full with 11 players,cannot add anymore players");
            }
        }
        public void RemovePlayer(int id)
        {
            Players remove=players.Find(p=>p.Id==id);
            if(remove != null)
            {
                players.Remove(remove);
                Console.WriteLine("Player removed from team successfully");
            }
            else
            {
                Console.WriteLine($"Cannot find player in the team with id : {id}");
            }
        }
        public Players GetDetailById(int id)
        {
             return players.Find(p=>p.Id==id);
            
        }
        public List<Players> GetDetailByName(string name)
        {
            return players.FindAll(p=>p.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
           
        } 
        public void ViewPlayers()
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Name : {player.Name}\nId : {player.Id}\nAge : {player.Age}");
            }
        }

    }
}
