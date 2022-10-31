// See https://aka.ms/new-console-template for more information
using EmpolyeWage;
using HelloWorld;
using System.Data.Common;
int IS_FULL_TIME = 1;
Random random = new Random();
int empcheck = random.Next(0, 2);
if (empcheck == IS_FULL_TIME)
{
Console.WriteLine("Empolye is Present");
}
else
{
Console.WriteLine("Empolye is Absent");
}
//Uc2 obj = new Uc2();
//Uc2.EmpolyeeWage();
//UC3 obj = new UC3();
//UC3.ParttimeEmpolyewage();
//Uc4 obj = new Uc4();
//Uc4.EmpolyeeWageUsingSwitch();
//Uc5 obj = new Uc5();
//Uc5.WagesForMonth();
//Uc6 obj = new Uc6();
//Uc6.WagesTillACondtionOfTotalWorkingHoursOf100();
//Uc7.computeEmpWage();
//DailyEmpolyeeWage obj = new DailyEmpolyeeWage();
//DailyEmpolyeeWage.dailyEmpolyeeWage();
//Uc8 obj = new Uc8();
//Uc8.Computewage("Dmart", 10, 4, 20);
EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
dmart.computeEmpWage();
Console.WriteLine(dmart.tostring());