using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //setup
                int userchoice = 0;
                double inputvalue = 0;
                double outputvalue = 0;
                double cuptoquart = 0.25;
                double cuptogallon = .0625;
                double gallontoquart = 4.0;
                double gallontocup = 16.0;
                string outputmeasue = string.Empty;
                string tempnum = string.Empty;
                bool isNumeric = false;
                bool isInt = false;
                string strContinue = string.Empty;


                do
                {

                
                    //input

                    // get input value that is a positive number (not letter)
                    do
                    {
                        Console.WriteLine("What value do you want to convert?");
                        tempnum = Console.ReadLine();
                        isNumeric = double.TryParse(tempnum, out double n);
                        if (isNumeric == false || double.Parse(tempnum) <= 0)
                        {
                            Console.WriteLine("Please enter a positive number");
                            isNumeric = false;
                        }

                    } while (isNumeric == false);
                    inputvalue = double.Parse(tempnum);

                    // get input choice (number between 1 and 4)
                    do
                    {
                        Console.WriteLine("How do you want to convert your value?" + "\r\n" +
                            "1) cups to quarts" + "\r\n" + "2) cups to gallons" + "\r\n" +
                            "3) gallons to quarts" + "\r\n" + "4) gallons to cups");
                        tempnum = Console.ReadLine();
                        isInt = int.TryParse(tempnum, out int n);
                        if (isInt == false || double.Parse(tempnum) > 4.0 || double.Parse(tempnum) < 1.0)
                        {
                            Console.WriteLine("Please enter a number from 1 to 4");
                            isInt = false;
                        }

                    } while (isInt == false);
                    userchoice = int.Parse(tempnum);

                    //processing
                    switch (userchoice)
                    {
                        case 1:
                            outputvalue = inputvalue * cuptoquart;
                            outputmeasue = " Quart(s)";
                            break;
                        case 2:
                            outputvalue = inputvalue * cuptogallon;
                            outputmeasue = " Gallon(s)";
                            break;
                        case 3:
                            outputvalue = inputvalue * gallontoquart;
                            outputmeasue = " Quart(s)";
                            break;
                        default:
                            outputvalue = inputvalue * gallontocup;
                            outputmeasue = " Cup(s)";
                            break;
                    }

                    Console.WriteLine("The answer is " + outputvalue + outputmeasue);
                    Console.WriteLine("");

                    Console.WriteLine("Do you want to calculate another value? (Y,N)");
                    strContinue = Console.ReadLine();

                } while (strContinue.ToUpper() == "Y");
            }
        }

    }
}
