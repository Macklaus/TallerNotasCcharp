using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegationWorkshopApp
{
    class ClassPercentage
    {

        private double partial1;
        private double partial2;
        private double partial3;
        private double workshop1;
        private double workshop2;
        private double workshop3;

        public ClassPercentage()
        {
            this.partial1 = 0.0;
            this.partial2 = 0.0;
            this.partial3 = 0.0;
            this.workshop1 = 0.0;
            this.workshop2 = 0.0;
            this.workshop3 = 0.0;
        }

        public double Partial1 { get => partial1; set => partial1 = value; }
        public double Partial2 { get => partial2; set => partial2 = value; }
        public double Partial3 { get => partial3; set => partial3 = value; }
        public double Workshop1 { get => workshop1; set => workshop1 = value; }
        public double Workshop2 { get => workshop2; set => workshop2 = value; }
        public double Workshop3 { get => workshop3; set => workshop3 = value; }
    }
}
