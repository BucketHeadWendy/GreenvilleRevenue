//Program written by Dan Plummer and Derek West
//1/.20.17
//CIS 2620 | Chapter 2 | Case Study #1

//2/15/17
//CIS 2620 | Chapter 4 | Case Study #1

using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        int lastYearNum, thisYearNum;
        string lastYear, thisYear;
        double admission = 25.00, revenue;
        Write("Enter the number of contestants in last year's competition: ");
        lastYear = ReadLine();
        lastYearNum = Int32.Parse(lastYear);
        Write("Enter the number of contestants in this year's competition: ");
        thisYear = ReadLine();
        thisYearNum = Int32.Parse(thisYear);
        bool moreThisYear = thisYearNum > lastYearNum;
        revenue = thisYearNum * admission;

        WriteLine();
        if (thisYearNum > (lastYearNum * 2))
            WriteLine("The Competition is more than twice as big this year!");
        else
            if (thisYearNum > lastYearNum)
            WriteLine("The competition is bigger than ever!");
       // WriteLine("There were {0} contestants last year, and {1} contestants this year.", lastYearNum, thisYearNum);
        WriteLine("To say that there were more contestants this year than last would be {0}", moreThisYear);
        WriteLine();
        WriteLine("Expected revenue for this year's competition is: ${0}", revenue.ToString("F2"));
    }
}