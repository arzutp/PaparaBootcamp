using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.Conditions;

public class ConditionCode
{
    //1. bool işlemleri tekrar if içinde true false olarak fontrol etmeye gerek yoktur
    public void BoolControl()
    {
        //bool bir değişkeni tekrar if içerisinde true ya da false olarak kontrol etmeye gerek yoktur.
        bool isTrue = true;
        if (isTrue == true)
            Console.WriteLine("true");
        else if (isTrue == false)
            Console.WriteLine("false");

        //bu şekilde yazmak daha doğru ve okunabilirdir
        if (isTrue)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }

    //2. bool kontrol işlemlerini uzun uzun yazmaya gerek yoktur
    public void AgeControlBadCode(int age)
    {
        //karışık bir kod
        //bu şekilde uzun uzun kontrol yapmak kodun okunabilirliğini düşürür.
        bool isAdult = false;

        if (age >= 18)
        {
            isAdult = true;
        }
        else
        {
            isAdult = false;
        }

        Console.WriteLine($"Kişi yetişkin mi? {isAdult}");
    }

    public void AgeControlCleanCode(int age)
    {
        //bu şekilde okunabilirlik daha da artar
        bool adult = (age >= 18);

        Console.WriteLine($"Kişi yetişkin mi? {adult}");
    }

    //3. bool değişkenleri kullanırken kesinlikle pozitif anlamlı olarak kullanmalıyız
    public void IsFailed(int score)
    {
        //bu şekilde tersten kontrol kafa karışıklığına sebep olabilir.
        if (!(score < 50))
        {
            Console.WriteLine("Başarılı.");
        }
        else
        {
            Console.WriteLine("Başarısız.");
        }
    }
    public void IsPassed(int score)
    {
        //bu şekilde kullanmak daha anlamlıdır
        if (score > 50)
        {
            Console.WriteLine("Başarılı.");
        }
        else
        {
            Console.WriteLine("Başarısız.");
        }
    }

    //4. seçenekler arasından seçim yapılacaksa bu değerleri ortak enum içinde tanımlayıp kullanmak daha uygun olur.
    public void ColorSelectBadCode(string color)
    {
        switch (color)
        {
            case "Yellow":
                Console.WriteLine("sarı seçildi");
                break;
            case "Red":
                Console.WriteLine("kırmızı seçildi");
                break;
            case "Blue":
                Console.WriteLine("mavi seçildi");
                break;
            case "Green":
                Console.WriteLine("yeşil seçildi");
                break;
        }
    }

    public void ColorSelectCleanCode(Color color)
    {
        switch (color)
        {
            case Color.Yellow:
                Console.WriteLine("sarı seçildi");
                break;
            case Color.Red:
                Console.WriteLine("kırmızı seçildi");
                break;
            case Color.Blue:
                Console.WriteLine("mavi seçildi");
                break;
            case Color.Green:
                Console.WriteLine("yeşil seçildi");
                break;
        }
    }

    //5. hiç bir anlam ifade etmeyen sayı, string gibi staticleri de direkt olarak kullanmamamız gerekir. 
    public void AdultControlBadCode(int age)
    {
        //bu şekilde kullanmak doğru olmaz genel düşünürsek her yerde yetişkin olma yaşı aynı değildir 
        //ve bu şekilde kullanım anlamlı değildir.
        if(age > 18)
            Console.WriteLine($"{age}, yetişkin");
    }

    public void AdultControlCleanCode(int age, int adultAge)
    {
        if(age > adultAge)
            Console.WriteLine($"{age}, yetişkin");
    }

    //6. kompleks koşullar kafa karışıklığı yaratır
    public void CanDriveCarBadCode()
    {
        //ve değerler dinamik olarak alınmamıştır.
        int age = 25;
        bool drivingLicence = true;
        bool trafficPenalty = false;

        //if içi çok karmaşık olmuştur
        if ((age >= 18 && drivingLicence) || (drivingLicence && !trafficPenalty && age >= 18))
        {
            Console.WriteLine("Sürücü olabilirsiniz.");
        }
        else
        {
            Console.WriteLine("Sürücü olamazsınız.");
        }
    }

    public void CadDriveCarCleanCode(int age, int minDrivingLicenceAge, bool drivingLicence, bool trafficPenalty)
    {
        bool canDriveLicence = (age >= minDrivingLicenceAge && drivingLicence) || (drivingLicence && !trafficPenalty && age >= minDrivingLicenceAge);

        if (canDriveLicence)
            Console.WriteLine("Sürücü olabilirsiniz.");
        else
            Console.WriteLine("Sürücü olamazsınız.");
    }

    //7. iç içe olan ifleri azaltarak kod yazmak daha doğru bir yaklaşımdır.
    public void CheckMilitaryBadCode(int age, Gender gender, bool isCompleteMilitary)
    {
        if (!isCompleteMilitary)
        {
            if (gender == Gender.Man)
            {
                if (age >= 20)
                {
                    Console.WriteLine("Askerlik zamanınız gelmiştir");
                }
            }
        }
    }

    public void CheckMilitaryCleanCode(int age, Gender gender, bool isCompleteMilitary)
    {
        if (isCompleteMilitary)
            return;
        if (gender == Gender.Women)
            return;
        if (age < 20)
            return;

        Console.WriteLine("Askerlik zamanınız gelmiştir. ");
    }


}