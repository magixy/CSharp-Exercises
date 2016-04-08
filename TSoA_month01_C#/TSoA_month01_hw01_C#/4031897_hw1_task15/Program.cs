using System;

class Program
{
    static void Main()
    {
        DateTime bDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        int years = today.Year - bDay.Year;
        int futureYears = years + 10;

        if ( bDay.Month < today.Month )
            Console.WriteLine("{0} \n{1}", years, futureYears);
        else
            Console.WriteLine("{0} \n{1}", years-1, futureYears-1);
    }
}
