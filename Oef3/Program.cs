using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef3
{
    public class UserEqualComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            if
                (
                x.FirstName == y.FirstName
                && x.LastName == y.LastName
                && x.BirthDate == y.BirthDate
                && x.Sex == y.Sex
                && x.EyeColor == y.EyeColor
                && x.HairColor == y.HairColor
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetHashCode(User obj)
        {
            return obj.FirstName.GetHashCode();
        }
    }
    class Program
    {
        public static List<User> Users = new List<User>();
        static void Main(string[] args)
        {
            Users.Add(new User("Charles","New","06/25/1958",EnumSex.Male,EnumEyeColor.Green,EnumHairColor.Blonde));
            Users.Add(new User("Charles","New","06/25/1958",EnumSex.Male,EnumEyeColor.Green,EnumHairColor.Blonde));
            Users.Add(new User("Marie","New","08/15/1988",EnumSex.Male,EnumEyeColor.Green,EnumHairColor.Blonde));
            Users.Add(new User("Lucy","Novak","04/25/1978",EnumSex.Male,EnumEyeColor.Green,EnumHairColor.Blonde));
            Console.WriteLine("Unfiltered list:");
            for (int i = 0; i < Users.Count; i++)
            {
                bool unique = true;
                for (int j = 0; j < Users.Count; j++)
                {
                    if (Users[i].Equals(Users[j])&&i>j)
                    {
                        unique = false;
                    }
                }
                if (unique)
                {
                    Console.WriteLine(Users[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Users[i]+" => Duplicate");
                    Console.ResetColor();
                }
                
            }
            Console.WriteLine("\nFiltered list:");
            foreach (var item in Users.Distinct(new UserEqualComparer()))
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
