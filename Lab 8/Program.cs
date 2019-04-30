using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        public static string[] homeTowns = new string[100];
        public static string[] favoriteFoods = new string[100];
        public static string[] names = new string[100];

        static void Main(string[] args)
        {
            AddStudent("Tommy", "Raleigh", "Chicken Curry", 0);
            string studentInfo = GetStudent(0);
            AddStudent("Callista", "Traverse City", "Crab Rangoon", 1);

            //Console.WriteLine(studentInfo);
            GetInput();
          
            Console.Read();
        }

        public static void AddStudent(string name,string town,string food,int index)
        {
            names[index] = name;
            favoriteFoods[index] = food;
            homeTowns[index] = town;
        }

        public static string GetStudent(int index)
        {
            try
            {
                string output = $"{names[index]} {favoriteFoods[index]} {homeTowns[index]}";
               

                if (index < 10 || index > 10)
                {
                    throw new IndexOutOfRangeException("Enter an index corresponding to one of the students");
                    throw new Exception("Invalid Input");
                }
                return output;
            }
            catch (IndexOutOfRangeException e)
            {
                
                Console.WriteLine(e.Message);
                

            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
            }

        }

        public static void PrintMenu()
        {
            for(int i =0; i < names.Length; i++)
            {
                string name = names[i];
              
                if (name != null)
                {
                    Console.WriteLine(i + ") " + names[i]);
                }
            }
        }

        public static void GetInput()
        {
                PrintMenu();
                Console.WriteLine("Please select index of student you want to know more about");
     
            try
            {
                String input = Console.ReadLine();
                int index = int.Parse(input);
                Console.WriteLine(GetStudent(index));

                if (input.Contains("a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z"))
                {
                    throw new FormatException("Enter valid number");
                }

                LearnMore(index);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //if int.Parse works pass to getstudent method

            //if it does not work, throw an exception, catch it, and tell the user to try again

        }
        public static void LearnMore(int index)
        {
            Console.WriteLine($"What would you like to learn more about {names[index]}? (Enter hometown or favorite food)");
            string input = Console.ReadLine();

            if (input == "hometown")
            {
                Console.WriteLine(homeTowns[index]);
            }
            else if (input == "favorite food")
            {
                Console.WriteLine(favoriteFoods[index]);
            }

        }
    }
}
