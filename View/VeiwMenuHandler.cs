using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx.View
{
    public class VeiwMenuHandler
    {
        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine(@"
1. Add new shape
2. List all shapes
3. Sum all circumferences
4. Sum all areas
5. Find biggest circumference
6. Find biggest area
7. Exit
");

        }

        public void PrintAddNewShapeMenu()
        {
            Console.Clear();
            Console.WriteLine(@"
1. Square
2. Rectangle
3. Circle
4. Right triangle
");
        }

        public int GetInputFromUser(int NumOfOptions)
        {
            int userInput;
            string userInputStr = Console.ReadLine();
            while(!int.TryParse(userInputStr, out userInput) || !CheckInputRange(userInput, NumOfOptions))
            {
                Console.WriteLine("Your input is invalid... please try again =)");
                userInputStr = Console.ReadLine();
            }

            return userInput;
        }

        private bool CheckInputRange(int userInput, int NumOfOptions)
        {
            return (1 <= userInput && userInput <= NumOfOptions);
        }

        public List<double> GetParametersForShape(int NumOfParameters, string RequestMsgFromUser)
        {
            Console.Clear();
            Console.WriteLine(RequestMsgFromUser);
            List<double> parametersList = new List<double>();
            for (int i = 0; i < NumOfParameters; i++)
            {
                parametersList.Add(ReadParameter());
            }
            return parametersList;
        }
        private double ReadParameter()
        {
            double parameter;
            string parameterStr = Console.ReadLine();
            while(!double.TryParse(parameterStr, out parameter))
            {
                Console.WriteLine("Your input is invalid... please try again =)");
                parameterStr = Console.ReadLine();
            }

            return parameter;
        }

        public void PrintListOfShapes(StringBuilder Msg)
        {
            Console.Clear();
            Console.WriteLine(Msg);
            Console.WriteLine("Press Enter to continue... =)");
            Console.ReadLine();
        }

        public void Print(string Msg)
        {
            Console.Clear();
            Console.WriteLine(Msg);
            Console.WriteLine("Press Enter to continue... =)");
            Console.ReadLine();
        }
    }
}
