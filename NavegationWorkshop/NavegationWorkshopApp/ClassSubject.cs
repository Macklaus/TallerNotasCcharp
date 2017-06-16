using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegationWorkshopApp
{
    class ClassSubject
    {

        private String code;
        private String name;
        private double workshop1;
        private double workshop2;
        private double workshop3;
        private double partial1;
        private double partial2;
        private double partial3;

        public ClassSubject(string code, string name, double workshop1, 
            double workshop2, double workshop3, double partial1, 
            double partial2, double partial3)
        {
            this.code = code;
            this.name = name;
            this.workshop1 = workshop1;
            this.workshop2 = workshop2;
            this.workshop3 = workshop3;
            this.partial1 = partial1;
            this.partial2 = partial2;
            this.partial3 = partial3;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public double Workshop1 { get => workshop1; set => workshop1 = value; }
        public double Workshop2 { get => workshop2; set => workshop2 = value; }
        public double Workshop3 { get => workshop3; set => workshop3 = value; }
        public double Partial1 { get => partial1; set => partial1 = value; }
        public double Partial2 { get => partial2; set => partial2 = value; }
        public double Partial3 { get => partial3; set => partial3 = value; }
    }
}
