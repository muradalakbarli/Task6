using System;
using System.Text.RegularExpressions;

class Task6
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task66();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
    }

    //1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?
    static void Task1()
    {
        string input = "1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?";
        char symbolA = 'a';
        char symbolB = 'b';

        int a = SimvolunSayi(input, symbolA);
        int b = SimvolunSayi(input, symbolB);

        int cavab = a / b;

        Console.WriteLine("1. cavab: " + cavab);
        Console.ReadKey();
    }

    static int SimvolunSayi(string text, char symbol)
    {
        int say = 0;
        foreach (char c in text)
        {
            if (c == symbol)
            {
                say++;
            }
        }
        return say;
    }

    //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?
    static void Task2()
    {
        string input = "abababa";
        bool SimvollarinHamisiAdir = SimvollarinAOldugunuYoxla(input);

        if(SimvollarinHamisiAdir)
        {
            Console.WriteLine("2. Hamisi {a} simvoludur");
        }

        else
        {
            Console.WriteLine("2. Hamisi {a} simvolu deyil");
        }
        Console.ReadKey();
    }

    static bool SimvollarinAOldugunuYoxla(string text)
    {
       for(int i = 0; i < text.Length; i+=2)
        {
            if (text[i]!='a')
            {
                return false;
            }
        }

        return true;
    }

    //3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.
    static void Task3()
    {
        string input = "babab";
        int BninSayi = ByeBeraberOlanSimvollar(input);

        Console.WriteLine("3. B lerin sayi: " + BninSayi);
        Console.ReadKey();
    }

    static int ByeBeraberOlanSimvollar(string input)
    {
        int a = 0;
        for (int i = 0; i < input.Length; i += 2)
        {
            if (input[i] == 'b')
            {
                a++ ;
            }
        }
        return a;
    }

    //4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?
    static void Task4()
    {
        string input = "Salam";
        bool CutEdeddir = CutEdeddirYoxsaTek(input);
        if(CutEdeddir = true)
        {
            Console.WriteLine("4. Cut yerdedir");
        }
        else
        {
            Console.WriteLine("4. Tek yerdedir");
        }
        Console.ReadKey();
    }

    static bool CutEdeddirYoxsaTek(string input)
    {

        for(int i = 0; i < input.Length; i+=1)
        {
            if (i % 2 == 0) 
            {
                if(input[i] == 'a')
                {
                    return true;
                }
            }
            else
            {
                if (input[i] == 'a')
                {
                    return false;
                }
            }
        }
        return false;
    }

    /*5) Verilmish metnde sol terefden saydiqda {a},{ b},{ c}
    simollarindan hansi birinci gelir?*/
    static void Task5()
    {
        string input = "Salam";
        char BirinciSimvol = BirinciSimvoluTap(input);

        if (BirinciSimvol != '\0')
        {
            Console.WriteLine($"5. Birinci rast gelinen: {BirinciSimvol}");
        }
        else
        {
            Console.WriteLine("5. 'a' 'b' 'c' simvollarindan hec biri yoxdur");
        }
        Console.ReadKey();
    }

    static char BirinciSimvoluTap(string input)
    {
        char[] simvollar = { 'a', 'b', 'c' };

        foreach (char simvol in simvollar)
        {
            int index = input.IndexOf(simvol);
            if (index != -1)
            {
                return simvol;
            }
        }

        return '\0';
    }

    /*6) Verilmish metnde { a }
    simvolunun sol terefden ve sag terefden indexleri eydidirmi?*/
    static void Task66()
    {
        string input = "abcSalamcba";
        bool IndexEynidir = IndexSagdanSoldanEynidir(input, 'a');

        if (IndexEynidir)
        {
            Console.WriteLine("6. Eynidir");
        }
        else
        {
            Console.WriteLine("6. Eyni deyil");
        }
    }
    static bool IndexSagdanSoldanEynidir(string input, char simvol)
    {
        int solIndex = input.IndexOf(simvol);
        int sagIndex = input.LastIndexOf(simvol);

        return solIndex == sagIndex;
    }

    /*7) Verilmish metnde {a} simvolu {b} simvolundan qabaq 
      ve oda {c} simvolundan qabaq gelirmi?*/
    static void Task7()
    {
        string input = "abcSalam";
        bool aBdenEvvel = SimvolEvveldirmi(input, 'a', 'b');
        bool bCdenEvvel = SimvolEvveldirmi(input, 'b', 'c');

        if (aBdenEvvel && bCdenEvvel)
        {
            Console.WriteLine("a b den evvel b c den evvel gelir");
        }
        else
        {
            Console.WriteLine("abc herfleri metne yoxdur");
        }
    }

    static bool SimvolEvveldirmi(string input, char EvvelkiSimvol, char SonrakiSimvol)
    {
        int indexBefore = input.IndexOf(EvvelkiSimvol);
        int indexAfter = input.IndexOf(SonrakiSimvol);

        return indexBefore != -1 && indexAfter != -1 && indexBefore < indexAfter;
    }

    /*8) Verilmish metnde ilk qabagima cixan {a} simvolundan sonra 
       gelen simvolu 10 defe dalbadal cap et.*/
    static void Task8()
    {
        string input = "abcSalam";
        AdanSonrakiSimvoluCapEt(input);
    }

    static void AdanSonrakiSimvoluCapEt(string input)
    {
        int aIndex = input.IndexOf('a');

        if (aIndex != -1 && aIndex < input.Length - 1)
        {
            Console.WriteLine($"Birinci 'a'-dan sonra gələn simvol: {input[aIndex + 1]}");

            for (int i = 0; i < 9; i++)
            {
                aIndex++;
                if (aIndex < input.Length - 1)
                {
                    Console.WriteLine($"'a'-dan sonra gələn simvol: {input[aIndex + 1]}");
                }
                else
                {
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("'a' tapılmadı və ya 'a' metnin son simvoludur.");
        }
    }

    /*9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.? */
    static void Task9()
    {
        string input = "abcSalamcba";
        bool Beraberdir = Ilk3VeSon3Beraberdir(input);

        if (Beraberdir)
        {
            Console.WriteLine("beraberdi");
        }
        else
        {
            Console.WriteLine("beraber deyil");
        }
    }
    static bool Ilk3VeSon3Beraberdir(string input)
    {
        if (input.Length >= 6)
        {
            string ilk3 = input.Substring(0, 3);
            string son3tersine = StringTers(input.Substring(input.Length - 3));

            return ilk3 == son3tersine;
        }

        return false;
    }

    static string StringTers(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /*10) Verilmish metinde butun reqemleri legv et.*/
    static void Task10()
    {
        string input = "abc123Salam456";
        string result = ReqemleriSil(input);

        Console.WriteLine(result);
    }

    static string ReqemleriSil(string input)
    {
        string result = Regex.Replace(input, @"\d", "");
        return result;
    }

    /*11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve
    eyni zamandan butun {b} simvollarinin qabagina {a} simvolunu yaz. */
    static void Task11()
    {
        string input = "Salam";
        string result = AveBelaveEt(input);

        Console.WriteLine(result);
    }

    static string AveBelaveEt(string input)
    {
        string result = input.Replace("a", "ba").Replace("b", "ab");
        return result;
    }

    /*12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et.*/
    static void Task12()
    {
        string input = "aSalamaaa";
        string result = AlariSil(input);

        Console.WriteLine(result);
    }

    static string AlariSil(string input)
    {
        if (input.Contains("a"))
        {
            int firstAIndex = input.IndexOf('a');
            int lastAIndex = input.LastIndexOf('a');

            string result = input.Remove(firstAIndex + 1, lastAIndex - firstAIndex - 1);
            return result;
        }

        return input;
    }
}






