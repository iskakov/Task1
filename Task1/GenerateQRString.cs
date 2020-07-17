using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class GenerateQRString
    {
        /// <summary>
        /// Данный метод формирует строку по данным объекта следующим образом
        /// 1) если длина наименования больше или равна 6 : 
        ///     то из намименования будет взята подстрока длиной 4 символа из центра строки 
        ///     иначе будет взята вся строка
        /// 2) записываем полностью дату регистрации в виде короткой строки
        /// 3) берем из строки лицевого счета потребителя, то колличество символов из центра строки, которое не хватает для полного заполенние строки (тоесть 18 символов)
        /// </summary>
        /// <param name="name">Наименование объекта-теплопотребления</param>
        /// <param name="dateRegistration">Дата регистрации объекта-теплопотребления</param>
        /// <param name="personalAccount">Лицевой счет потребителя объекта-теплопотребления</param>
        /// <returns></returns>
        public static string FirstGenerate(string name, DateTime dateRegistration, string personalAccount)
        {
            string generateSt = "";
            if (String.IsNullOrEmpty(name))
            {
                return "";
            }
            if (String.IsNullOrEmpty(personalAccount))
            {
                return "";
            }
            string part1 = name.Length>=6 ?  name.Substring(name.Length/2-2,4) : name;
            string part2 = dateRegistration.ToShortDateString();
            generateSt += part1 + ";" + part2 + ";";
            string part3 = personalAccount.Substring(personalAccount.Length / 2, 18 - generateSt.Length);
            generateSt += part3;
            return generateSt;
        }

        public static void FirstGetObject(string getnerateSt, out string name, out DateTime dateRegistration, out string personalAccount)
        {
            if (!String.IsNullOrEmpty(getnerateSt))
            {
                var mass = getnerateSt.Split(';');
                if (mass.Length == 1)
                {
                    name = "";
                    dateRegistration = new DateTime();
                    personalAccount = "";
                }
                else
                {
                    name = mass[0];

                    var prov = DateTime.TryParse(mass[1], out dateRegistration);

                    if (mass.Length == 3)
                        personalAccount = mass[2];
                    else
                    {
                        personalAccount = "";
                    }
                }

            }
            else
            {
                name = "";
                dateRegistration = new DateTime();
                personalAccount = "";
            }
        }

        /// <summary>
        /// Данный метод формирует строку по данным объекта следующим образом
        /// 1) если длина наименование больше 8 
        ///     то будет взята подстрока 8 символов, начиная с 0 символа
        ///     иначе будет взята вся строка наименования
        /// 2) если длина строк лицевого счета потребителя больше 8 
        ///     то будет взята подстрока 8 символов, начиная с 0 символа
        ///     иначе будет взята вся строка лицевого счета потребителя 
        /// </summary>
        /// <param name="name">Наименование объекта-теплопотребления</param>
        /// <param name="dateRegistration">Дата регистрации объекта-теплопотребления</param>
        /// <param name="personalAccount">Лицевой счет потребителя объекта-теплопотребления</param>
        /// <returns></returns>
        public static string SecondGenerate(string name, DateTime dateRegistration, string personalAccount)
        {
            if (String.IsNullOrEmpty(name))
            {
                return "";
            }
            if (String.IsNullOrEmpty(personalAccount))
            {
                return "";
            }
            string generateSt = "";
            string part1 = name.Length > 8 ? name.Substring(0, 8) : name;
            string part2 = personalAccount.Length > 8 ? personalAccount.Substring(0, 8) : personalAccount;
            generateSt += part1 + "-" + part2;
            return generateSt;
        }

        public static void SecondGetObject(string getnerateSt, out string name, out string personalAccount)
        {
            if (!String.IsNullOrEmpty(getnerateSt)) {
                var mass = getnerateSt.Split('-');
                if (mass.Length == 1)
                {
                    name = "";
                    personalAccount = "";
                }
                else
                {
                    name = mass[0];
                    personalAccount = mass[1];
                }
            }
            else
            {
                name = "";
                personalAccount = "";
            }
        }
    }
}
