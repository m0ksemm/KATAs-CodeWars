using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class GraderClass
    {
        public static char Grader(double score) => score > 1  ? 'F'
                                     : score >= 0.9 ? 'A'
                                     : score >= 0.8 ? 'B'
                                     : score >= 0.7 ? 'C'
                                     : score >= 0.6 ? 'D'
                                     : 'F';
    }
}
