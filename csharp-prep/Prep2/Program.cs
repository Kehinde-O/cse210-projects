using System;

class Program
{
    static void Main(string[] args)
    {
        int grade_percentage;
        string grade_letter = "A";
        Console.Write("What is your grade percentage? ");
        grade_percentage = int.Parse(Console.ReadLine());

        if(grade_percentage >= 97){
            grade_letter = "A+";
        }else if(grade_percentage >= 93 && grade_percentage < 97){
            grade_letter = "A";
        }else if(grade_percentage >= 90 && grade_percentage < 93){
            grade_letter = "A-";
        }else if(grade_percentage >= 87 && grade_percentage < 90){
            grade_letter = "B+";
        }else if(grade_percentage >= 83 && grade_percentage < 87){
            grade_letter = "B";
        }else if(grade_percentage >= 80 && grade_percentage < 83){
            grade_letter = "B-";
        }else if(grade_percentage >= 77 && grade_percentage < 80){
            grade_letter = "C+";
        }else if(grade_percentage >= 73 && grade_percentage < 77){
            grade_letter = "C";
        }else if(grade_percentage >= 70 && grade_percentage < 73){
            grade_letter = "C-";
        }else if(grade_percentage >= 67 && grade_percentage < 70){
            grade_letter = "D+";
        }else if(grade_percentage >= 63 && grade_percentage < 67){
            grade_letter = "D";
        }else if(grade_percentage >= 60 && grade_percentage < 63){
            grade_letter = "D-";
        }
        Console.WriteLine();
        Console.WriteLine($"Grade Percentage is {grade_percentage} and your grade letter is {grade_letter}");
        if(grade_percentage >= 70){
            Console.WriteLine("Congratulations, you passed!");
        }
        else{
            Console.WriteLine("Better luck next time!");
        }
    }
}