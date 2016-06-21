using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
    public class ThrowAwayGradeBook : GradeBook {

        public override GradeStatistics ComputeStatistics() {

            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");

            float lowest = float.MaxValue;
            foreach (float grades in grades) {

                lowest = Math.Min(grades, lowest);
            }

            grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
