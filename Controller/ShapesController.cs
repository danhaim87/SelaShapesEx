using SelaShapesEx.Model;
using SelaShapesEx.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx.Controller
{
    public class ShapesController
    {
        private VeiwMenuHandler View;
        private ShapeFactory ShapeFactory;
        private List<IShape> Shapes;
        private List<Action> UserChoiceActions;
        public ShapesController()
        {
            View = new VeiwMenuHandler();
            ShapeFactory = new ShapeFactory();
            Shapes = new List<IShape>();
            UserChoiceActions = new List<Action>();
            UserChoiceActions.Add(AddNewShapeOption);
            UserChoiceActions.Add(ListAllShapes);
            UserChoiceActions.Add(SumAllCircumferences);
            UserChoiceActions.Add(SumAllArea);
            UserChoiceActions.Add(FindTheBiggestCircumferences);
            UserChoiceActions.Add(FindTheBiggestArea);

        }

        public VeiwMenuHandler ViewProp
        {
            get { return View; }
        }

        public ShapeFactory ShapeFactoryProp
        {
            get { return ShapeFactory; }
        }

        public void UserInputHandler(int UserInput)
        {
            UserChoiceActions[UserInput - 1].Invoke();
        }

        private void FindTheBiggestCircumferences()
        {
            var shape = Shapes.First(sh => sh.Circumferences() == Shapes.Max(sh1 => sh1.Circumferences()));
            View.Print(string.Format("The Biggest Circumferences is: {0}\n{1}", shape.Circumferences(), shape.CreateMsgForList()));
        }

        private void FindTheBiggestArea()
        {
            var shape = Shapes.First(sh => sh.Area() == Shapes.Max(sh1 => sh1.Area()));
            View.Print(string.Format("The Biggest Area is: {0}\n{1}", shape.Area(), shape.CreateMsgForList()));
        }
        private void SumAllArea()
        {
            var sum = Shapes.Sum(sh => sh.Area());
            View.Print("The Area sum is: " + sum);
        }

        private void SumAllCircumferences()
        {
            var sum = Shapes.Sum(sh => sh.Circumferences());
            View.Print("The Circumferences sum is: " + sum);
        }

        private void ListAllShapes()
        {
            var Msg = CollectMessagesFromShapes();
            View.PrintListOfShapes(Msg);
        }

        private StringBuilder CollectMessagesFromShapes()
        {
            StringBuilder Msg = new StringBuilder();
            foreach (IShape shape in Shapes)
            {
                Msg.Append(shape.CreateMsgForList());
            }

            return Msg;
        }

        private void AddNewShapeOption()
        {
            View.PrintAddNewShapeMenu();
            int UserInput = View.GetInputFromUser(Constants.AddShapeMenuOptionsNum);
            var parameters = GetParametersForShape(UserInput);
            IShape NewShape = ShapeFactory.createShape(UserInput, parameters);
            Shapes.Add(NewShape);
        }

        private List<double> GetParametersForShape(int UserChoice)
        {
            if (UserChoice == (int)Constants.e_Shapes.Square)
            {
                return View.GetParametersForShape(Constants.OneParameter, Constants.WidthParameter);
            }
            else if (UserChoice == (int)Constants.e_Shapes.Rectangle)
            {
                return View.GetParametersForShape(Constants.TwoParameters, Constants.WidthAndHeightParameters);
            }
            else if (UserChoice == (int)Constants.e_Shapes.Circle)
            {
                return View.GetParametersForShape(Constants.OneParameter, Constants.RadiusParameter);
            }
            else if (UserChoice == (int)Constants.e_Shapes.RightTriangle)
            {
                return View.GetParametersForShape(Constants.TwoParameters, Constants.WidthAndHeightParameters);
            }

            return null;
        }

    }
}
