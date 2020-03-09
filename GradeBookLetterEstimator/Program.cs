using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GradeBookLetterEstimator
{
    class Program
    {
        // Author: Jesse Gober 
        // Date: 3/09/20 
        // My first program that I have written in code to add to my portfolio
        // GradeBookLetterEstimator: A program that takes a student's percentage grade and gives a letter grade 

        static void Main(string[] args)
        {
            
            string[] results = {
                @"   /`-.   )\.---.     /`-.  )`-.--.  )\.---.     )\.-.  .-,.-.,-.    .-./(  .`(  
 ,' _  \ (   ,-._(  ,' _  \ ) ,-._( (   ,-._(  ,' ,-,_) ) ,, ,. (  ,'     ) \_ ) 
(  '-' (  \  '-,   (  '-' ( \ `-._   \  '-,   (  .   _  \( |(  )/ (  .-, (    )\ 
 ) ,._.'   ) ,-`    ) ,_ .'  ) ,_(    ) ,-`    ) '..' )    ) \     ) '._\ )   \( 
(  '      (  ``-.  (  ' ) \ (  \     (  ``-.  (  ,   (     \ (    (  ,   (     _ 
 )/        )..-.(   )/   )/  ).'      )..-.(   )/'._.'      )/     )/ ._.'    `.(" ,
            @"
   )\.-.   /`-. )\.---.   /`-..-,.-.,-.`(      /`-.    /(,-.   .-./(     .-. )\.---.     /`-.      .-. )\.---.   /`-.   /`-.    )\.-. )\.---. 
 ,' ,-,_),' _  (   ,-._(,' _  ) ,, ,. (_ )   ,' _  \ ,' _   ),'     ),'  /  |   ,-._(  ,' _  \ ,'  /  |   ,-._(,' _  \,' _  \ ,' ,-,_|   ,-._(
(  .   _(  '-' (\  '-, (  '-' (( |(  )/ )\  (  '-' ((  '-' ((  .-, ((  ) | ( \  '-,   (  '-' ((  ) | ( \  '-, (  '-' (  '-' ((  .   __\  '-,  
 ) '._\ _) ,_ .' ) ,-`  )   _  ) ) \    \(   )   _  ))  _   )) '._\ )) './ /  ) ,-`    )   _  )) './ /  ) ,-`  ) ,_ .')   _  )) '._\ _)) ,-`  
(  ,   ((  ' ) \(  ``-.(  ,' ) \ \ (     _  (  ,' ) (  '-' /(  ,   ((  ,  (  (  ``-.  (  ,' ) (  ,  (  (  ``-.(  ' ) (  ,' ) (  ,   ( (  ``-. 
 )/'._.' )/   )/ )..-.( )/    )/  )/    `.(  )/    )/)/._.'  )/ ._.' )/..'    )..-.(   )/    )/)/..'    )..-.( )/   )/)/    )/)/'._.'  )..-.( ",
            @"   .-./(    .'(                       /`-.      .-. )\.---.   /`-.   /`-.    )\.-. )\.---..`(  
 ,'     ),')\  )                    ,' _  \ ,'  /  |   ,-._(,' _  \,' _  \ ,' ,-,_|   ,-._(_ ) 
(  .-, ((  '/ /                    (  '-' ((  ) | ( \  '-, (  '-' (  '-' ((  .   __\  '-,   )\ 
 ) '._\ ))   ( ,_ ,_ ,_ ,_ ,_ ,_ ,_ )   _  )) './ /  ) ,-`  ) ,_ .')   _  )) '._\ _)) ,-`   \( 
(  ,   ((  .\ (  (  (  (  (  (  (  (  ,' ) (  ,  (  (  ``-.(  ' ) (  ,' ) (  ,   ( (  ``-.   _ 
 )/ ._.' )/  )/).').').').').').').')/    )/)/..'    )..-.( )/   )/)/    )/)/'._.'  )..-.(  `.(",
            @"

   )\.-.   /`-.      .-..-,.-.,-.'(   .-./( )\  )\                  /(,-. )\.---. .')       .-./(     .'(     /`-.      .-. )\.---.   /`-.   /`-.    )\.-. )\.---..`(.`(  
 ,' ,-,_),' _  \ ,'  /  ) ,, ,. (  ),'     |  \, /                ,' _   |   ,-._( /      ,'     ),') \  )  ,' _  \ ,'  /  |   ,-._(,' _  \,' _  \ ,' ,-,_|   ,-._(_ )_ ) 
(  .   _(  '-' ((  ) | (\( |(  )) ((  .-, ( ) \ (                (  '-' ( \  '-,  ))     (  .-, ((  /(/ /  (  '-' ((  ) | ( \  '-, (  '-' (  '-' ((  .   __\  '-,   )\ )\ 
 ) '..' ))   _  )) '._\ )  ) \  \  )) '._\ | ( \ \ ,_ ,_ ,_ ,_ ,_ )  _   ) ) ,-`  )'._.-. ) '._\ ))    (    )   _  )) './ /  ) ,-`  ) ,_ .')   _  )) '._\ _)) ,-`   \( \( 
(  ,   ((  ,' ) (  ,   (   \ (   ) (  ,   ( `.)/  |  (  (  (  (  (  '-' / (  ``-.(       |  ,   ((  .'\ \  (  ,' ) (  ,  (  (  ``-.(  ' ) (  ,' ) (  ,   ( (  ``-.   _  _ 
 )/'._.' )/    )/)/ ._.'    )/    )/)/ ._.'    '.( ).').').').').')/._.'   )..-.( )/,__.' )/ ._.' )/   )/   )/    )/)/..'    )..-.( )/   )/)/    )/)/'._.'  )..-.(  `.(`.(
                                                                                                                                                                          
",
            @")\    /(    .-./(       .-.    )`-.--.    /`-.   .'(   .')       )\.---.     )\.-.  .`(  
\ (_.' /  ,'     )  ,'  /  )   ) ,-._(  ,' _  \  \  ) ( /       (   ,-._(  ,'     ) \_ ) 
 )  _.'  (  .-, (  (  ) | (    \ `-._  (  '-' (  ) (   ))        \  '-,   (  .-, (    )\ 
 / /      ) '._\ )  ) '._\ )    ) ,_(   )   _  ) \  )  )'._.-.    ) ,-`    ) '._\ )   \( 
(  \     (  ,   (  (  ,   (    (  \    (  ,' ) \  ) \ (       )  (  ``-.  (  ,   (     _ 
 ).'      )/ ._.'   )/ ._.'     ).'     )/    )/   )/  )/,__.'    )..-.(   )/ ._.'    `.(
                                                                                         
                                                                                         
                                                                                                                                                                               "};

            //Enter the student name
            Console.WriteLine("Please input the students' name:");
            Console.WriteLine("*************************");
            string name = Console.ReadLine();
           

            Console.WriteLine();
            //Enter the grade
            Console.WriteLine("*************************");
            Console.WriteLine("Please input to the percentage grade:");
            Console.WriteLine("*************************");

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("Percentage grade for student {0}: ", name);
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine("*************************");

            Console.WriteLine();

           
            // converting percentage
            string letterGrade = "";
            if (grade > 89.5 && grade <= 100)
            {
                letterGrade = "A";
            }
            else if (grade > 79.5 && grade <= 89.4)
            {
                letterGrade = "B";
            }
            else if (grade > 69.5 && grade <= 79.4)
            {
                letterGrade = "C";
            }
            else if (grade > 59.5 && grade <= 69.4)
            {
                letterGrade = "D";
            }
            else if (grade >= 0 && grade <= 59.4)
            {
                letterGrade = "F";
            }
            else
            {
                Console.WriteLine("INVALID INPUT!!!");
            }
            //the results
            switch (letterGrade)
            {
                case "A":
                    Console.WriteLine("{0}'s letter grade is: {1}", name, letterGrade); Console.WriteLine("*************************"); Console.WriteLine(results[0]); Console.WriteLine("*************************"); break;
                    
                case "B":
                    Console.WriteLine("{0}'s letter grade is: {1}", name, letterGrade); Console.WriteLine("*************************"); Console.WriteLine(results[1]); Console.WriteLine("*************************"); break;
                case "C":
                    Console.WriteLine("{0}'s letter grade is: {1}", name, letterGrade); Console.WriteLine("*************************"); Console.WriteLine(results[2]); Console.WriteLine("*************************"); break;
                case "D":
                    Console.WriteLine("{0}'s letter grade is: {1}", name, letterGrade); Console.WriteLine("*************************"); Console.WriteLine(results[3]); Console.WriteLine("*************************"); break;
                case "F":
                    Console.WriteLine("{0}'s letter grade is: {1}", name, letterGrade); Console.WriteLine("*************************"); Console.WriteLine(results[4]); Console.WriteLine("*************************"); break;
                default:
                    break;
            }
            System.Threading.Thread.Sleep(3000);
        }

    }













}

