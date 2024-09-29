using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOp_lab_5.Model;

namespace OOp_lab_5.Controller
{
    public class AgeController
    {
        private readonly AgeModel _ageModel;

        public AgeController()
        {
            _ageModel = new AgeModel();
        }

        public string GetAgeCategory(int age) => _ageModel.CheckAgeCategory(age);
    }
}
