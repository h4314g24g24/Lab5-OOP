using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_lab_5.Model
{
    public class AgeModel
    {
        public string CheckAgeCategory(int age)
        {
            if (age < 13) return "Дитина";
            if (age < 18) return "Підліток";
            return "Дорослий";
        }
    }
}

