using System;

namespace ClassLibraryStandardBoth
{
    public class Employee
    {
        public int empID { get; set; }
        public string name { get; set; }
        public double salaryPerDay { get; set; }
        public double HRA { get; set; }
        public double getSal(int leavesTaken)
        {
            int curyear = DateTime.Now.Year;
            int curmonth = DateTime.Now.Month;
            int totalDays = DateTime.DaysInMonth(curyear, curmonth);
            int noOfDays = totalDays - leavesTaken;
            double basicSal = (noOfDays * salaryPerDay);
            double grossSal = (basicSal) + (basicSal * (HRA / 100));
            return grossSal;
        }
    }
}
