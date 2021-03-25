using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WichellHelperWeb.Models
{
    // Calculates which user will get who
    public class NameDistributer
    {
        private Random random = new Random();

        public Dictionary<String, String> GetPairsOfUsers(List<String> users)
        {

            int ammountUsers = users.Count();

            List<String> usersExist = new List<string>(users);


            Dictionary<String, String> finalPairs = new Dictionary<string, string>();

            for(int i = 0; i < ammountUsers; i++)
            {
                String startUser;
                startUser = users[i];
                String partner = GetRandomPerson(usersExist, startUser);

                usersExist.Remove(partner);


                Console.WriteLine(usersExist.Count());
                Console.WriteLine("StartUser: " + startUser);
                Console.WriteLine("Partner: " + partner);

                finalPairs.Add(startUser, partner);

            }


            return finalPairs;
           
        }

        private string GetRandomPerson(List<String> potentialPartners, String firstPartner)
        {
            int randomNumber = (int)Math.Round((double)random.Next(potentialPartners.Count));

            String potentialPartner = potentialPartners[randomNumber];

            if(firstPartner == potentialPartner)
            {
              potentialPartner = GetRandomPerson(potentialPartners, firstPartner);
            }

            return potentialPartner;
        }
    }
}
