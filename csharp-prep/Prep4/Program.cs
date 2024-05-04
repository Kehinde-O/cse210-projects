using System;

class Program
{
    static void Main(string[] args)
    {
        int single_number = 0;
        List<int> list_of_numbers = new List<int>();
        int max = 0;
        double average = 0;
        int sum = 0;
        int smallest_positive = int.MaxValue;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter  number: ");
            single_number = int.Parse(Console.ReadLine());
            if(single_number != 0){
                sum += single_number;
                list_of_numbers.Add(single_number);
                for(int i = 0; i < list_of_numbers.Count; i++){
                    if(list_of_numbers[i] > max){
                        max = list_of_numbers[i];
                    }
                }
                if(single_number > 0 && single_number < smallest_positive){
                    smallest_positive = single_number;
                }
                average = (double)sum / list_of_numbers.Count;
            }
        }while(single_number != 0);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average.ToString("0.000")}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallest_positive}");
        list_of_numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        for(int i = 0; i < list_of_numbers.Count; i++){
            Console.WriteLine($"{list_of_numbers[i]} ");
        }
        Console.WriteLine();
    }
}