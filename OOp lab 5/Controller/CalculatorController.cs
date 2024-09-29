
using OOp_lab_5.Model;

namespace OOp_lab_5.Controller
{
    public class CalculatorController
    {
        private readonly CalculatorModel _model;

        public CalculatorController()
        {
            _model = new CalculatorModel();
        }

        public double PerformAddition(double a, double b) => _model.Add(a, b);
        public double PerformSubtraction(double a, double b) => _model.Subtract(a, b);
        public double PerformMultiplication(double a, double b) => _model.Multiply(a, b);
        public double PerformDivision(double a, double b) => _model.Divide(a, b);
    }
}
