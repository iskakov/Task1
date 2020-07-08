using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class GenerateQRString
    {
        /**
         * Строка состоит из части названия объекта, из полной даты регистрации, и если осталось места то часть лицевого счета клиента
         */
        public static string FirstGenerate(string name, DateTime dateRegistration, string personalAccount)
        {
            string generateSt = "";
            string part1 = name.Length>=6 ?  name.Substring(name.Length/2-2,4) : name;
            string part2 = dateRegistration.ToShortDateString();
            generateSt += part1 + ";" + part2 + ";";
            string part3 = generateSt.Length < 18 ? personalAccount.Substring(personalAccount.Length / 2, 17 - generateSt.Length) : "";
            generateSt += part3;
            return generateSt;
        }

        public static void FirstGetObject(string getnerateSt, out string name, out DateTime dateRegistration, out string personalAccount)
        {
            var mass = getnerateSt.Split(';');
            if(mass.Length == 1)
            {
                name = "";
                dateRegistration = new DateTime();
                personalAccount = "";
            }
            else
            {
                name = mass[0];
                dateRegistration = DateTime.Parse(mass[1]);
                if (mass.Length == 3)
                    personalAccount = mass[2];
                else
                {
                    personalAccount = "";
                }
            }
            
        }

        /**
         * Строка состоит либо из 8 символов имени объекта либо полностью из имени и либо 8 символов персонального счета либо полностью из персонального счета
         */
        public static string SecondGenerate(string name, DateTime dateRegistration, string personalAccount)
        {
            string generateSt = "";
            string part1 = name.Length > 8 ? name.Substring(0, 8) : name;
            string part2 = personalAccount.Length > 8 ? personalAccount.Substring(0, 8) : personalAccount;
            generateSt += part1 + "-" + part2;
            return generateSt;
        }

        public static void SecondGetObject(string getnerateSt, out string name, out string personalAccount)
        {
            var mass = getnerateSt.Split('-') ;
            if (mass.Length == 1)
            {
                name = "";
                personalAccount ="";
            }
            else
            {
                name = mass[0];
                personalAccount = mass[1];
            }
        }
    }
}
