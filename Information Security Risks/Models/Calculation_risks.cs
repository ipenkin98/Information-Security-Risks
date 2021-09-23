using System;
using System.Collections.Generic;
using System.Text;

namespace Information_Security_Risks.Models
{
    class Calculation_risks
    {
        public static int Risks(int Pt, int Pv, int S) => (Pt * Pv *S)/4 ;

        public static double SLE(int EF, double Cost) => EF * Cost;

        public static int ALE(int SLE, int ARO) => SLE * ARO;
    }
}
