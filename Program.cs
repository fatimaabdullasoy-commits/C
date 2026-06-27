using System;
using System.Diagnostics.Metrics;
using System.Linq;
using _1.Linq.Models;
namespace HelloWorldApp

{
    class Program
    {
        static void Main(string[] args)
        {
            var debts = Debtor.debtors;
            //2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
            var result1 = debts.Where(x =>
                x.Email.EndsWith("rhyta.com") ||
                x.Email.EndsWith("dayrep.com"));
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            //3) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag
            var result3 = debts.Where(x =>
            {
                int age = DateTime.Now.Year - x.BirthDay.Year;
                if (x.BirthDay > DateTime.Now.AddYears(-age))
                    age--;
                return age >= 26 && age <= 36;
            });

            foreach(var item in result3)
            {
                Console.WriteLine(item);
            }

            //4) Borcu 5000 - den cox olmayan borclularic cixartmag


            //5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq


            //7) Qishda anadan olan borclulari cixardmaq


            //8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek


            //9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq


            //11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek


            //13)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq


            //14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq


            //15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq


            //16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq


            //18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq


            //19)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq


            //20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq
            //}
        }
    }
}