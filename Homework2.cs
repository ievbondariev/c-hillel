namespace Homework2;
class Homework2
{
    static void Main(string[] args)
    {
        DateTime birthday = new DateTime(1981, 10, 12);       
                
        TimeSpan age = DateTime.Now.Subtract(birthday);
        double ageInSeconds = age.TotalSeconds;
        Console.WriteLine("Date of bithday: " + birthday);
        Console.WriteLine("Age in seconds: " + ageInSeconds);

        ageOnEarth(ageInSeconds);
        ageOnMercury(ageInSeconds);
        ageOnVenus(ageInSeconds);
        ageOnMars(ageInSeconds);        
        ageOnJupiter(ageInSeconds);
        ageOnSaturn(ageInSeconds);
        ageOnUranus(ageInSeconds);
        ageOnNeptune(ageInSeconds);


    }
    static double ageOnEarth(double age)
    {
        double result = age / 31557600;
        Console.WriteLine("Age on Earth: " + result);
        return result;
        
    }

    static double ageOnMercury(double age)
    {
        double result = age / 31557600 / 0.2408467;
        Console.WriteLine("Age on Mercury: " + result);
        return result;

    }

    static double ageOnVenus(double age)
    {
        double result = age / 31557600 / 0.61519726;
        Console.WriteLine("Age on Venus: " + result);
        return result;

    }

    static double ageOnMars(double age)
    {
        double result = age / 31557600 / 1.8808158;
        Console.WriteLine("Age on Mars: " + result);
        return result;

    }

    static double ageOnJupiter(double age)
    {
        double result = age / 31557600 / 11.862615;
        Console.WriteLine("Age on Jupiter: " + result);
        return result;

    }

    static double ageOnSaturn(double age)
    {
        double result = age / 31557600 / 29.447498;
        Console.WriteLine("Age on Saturn: " + result);
        return result;

    }

    static double ageOnUranus(double age)
    {
        double result = age / 31557600 / 84.016846;
        Console.WriteLine("Age on Uranus: " + result);
        return result;

    }

    static double ageOnNeptune(double age)
    {
        double result = age / 31557600 / 164.79132;
        Console.WriteLine("Age on Neptune: " + result);
        return result;

    }
}

