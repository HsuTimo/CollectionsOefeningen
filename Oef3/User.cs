using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef3
{
    public enum EnumSex
    {
        Male,
        Female
    }
    public enum EnumEyeColor
    {
        NotSpecified,
        Blue,
        Green,
        Brown,
        Black,
        BrownGreen
    }
    public enum EnumHairColor
    {
        NotSpecified,
        Blonde,
        Brown,
        Black,
        White,
        RedHead
    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public EnumSex Sex { get; set; }
        public EnumEyeColor EyeColor { get; set; }
        public EnumHairColor HairColor { get; set; }
        public User(string firstName, string lastName, string birthDate, EnumSex sex, EnumEyeColor eyeColor,EnumHairColor hairColor)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Sex = sex;
            EyeColor = eyeColor;
            HairColor = hairColor;
        }
        public override bool Equals(object obj)
        {
            if 
                (
                FirstName==((User)obj).FirstName
                && LastName == ((User)obj).LastName
                && BirthDate == ((User)obj).BirthDate
                && Sex == ((User)obj).Sex
                && EyeColor == ((User)obj).EyeColor
                && HairColor == ((User)obj).HairColor
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"User: {FirstName} {LastName} Born on: {BirthDate} Sex: {Sex} Eye color: {EyeColor} Haircolor: {HairColor}";
        }
    }
}
