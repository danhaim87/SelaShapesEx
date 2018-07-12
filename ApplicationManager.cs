using SelaShapesEx.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx
{
    public class ApplicationManager
    {
        private ShapesController ShapesController;
        public ApplicationManager()
        {
            ShapesController = new ShapesController();
        }
        public void Run()
        {
            var View = ShapesController.ViewProp;
            while (true)
            {
                View.PrintMainMenu();
                int userChoice = View.GetInputFromUser(Constants.MainMenuOptionsNum);

                if (userChoice == Constants.Exit)
                    break;
                
                ShapesController.UserInputHandler(userChoice);
            }
        }

        
    }
}
