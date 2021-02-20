using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef7
{
    public abstract class Human:IComparable<Human>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Human(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public int CompareTo(Human obj)
        {
            int output = LastName.CompareTo(obj.LastName);
            if (output == 0)
            {
                output = BirthDate.CompareTo(obj.BirthDate);
            }
            return output;
        }
        public static Human operator +(Human human1, Human human2)
        {
            Console.WriteLine($"Creating child for {human1.FirstName} {human1.LastName} & {human2.FirstName} {human2.LastName}");
            Random rnd = new Random();
            int sex = rnd.Next(1);
            Human output = null;
            if (human1.GetType() != human2.GetType())
            {
                if (sex == 0)
                {
                    string lastName;
                    if (human1 is Man)
                    {
                        lastName = human1.LastName;
                    }
                    else
                    {
                        lastName = human2.LastName;
                    }
                    output = new Man("Adam", lastName, DateTime.Now);
                }
                else if (sex == 1)
                {
                    string lastName;
                    if (human1 is Woman)
                    {
                        lastName = human1.LastName;
                    }
                    else
                    {
                        lastName = human2.LastName;
                    }
                    output = new Woman("Eva", lastName, DateTime.Now);
                }
            }
            if (output == null)
            {
                Console.WriteLine("Can't make child with same sex couple!");
            }
            else
            {
                Console.WriteLine($"{human1.FirstName} {human1.LastName} & {human2.FirstName} {human2.LastName} have a new child {output.FirstName} {output.LastName}");

            }
            return output;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {(DateTime.Now.Year-BirthDate.Year)}";
        }
    }
}
