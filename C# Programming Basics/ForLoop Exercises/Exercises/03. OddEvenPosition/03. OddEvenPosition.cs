using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {
            //            Напишете програма, която чете n-на брой числа, въведени от потребителя, и пресмята сумата, минимума и максимума на числата на четни и нечетни позиции(броим от 1).Когато няма минимален / максимален елемент, отпечатайте "No".
            //Изходът да се форматира в следния вид:
            //            "OddSum=" + { сума на числата на нечетни позиции},
            //"OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            //"OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            //"EvenSum=" + { сума на числата на четни позиции },
            //"EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}
            //            Всяко число трябва да е форматирано до втория знак след десетичната запетая.
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    OddSum += num;
                    if (num > OddMax)
                    {
                        OddMax = num;

                    }
                    if (num < OddMin)
                    {
                        OddMin = num;
                    }

                }
                else if (i % 2 == 0)
                {
                    EvenSum += num;
                    if (num > EvenMax)
                    {
                        EvenMax = num;
                    }
                    if (num < EvenMin)

                    {
                        EvenMin = num;
                    }

                }




            }
            Console.WriteLine($"OddSum={OddSum:f2},");
            if (OddSum == 0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");


            }
            else
            {
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
            }
            Console.WriteLine($"EvenSum={EvenSum:f2},");
            if (EvenSum == 0)
            {

                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }











        }

    }


}
