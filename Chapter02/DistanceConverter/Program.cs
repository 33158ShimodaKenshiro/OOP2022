using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(1, 10);
            }
            else {

                PrintFeetToMeterList(1, 10);
            }

        }
        private static void PrintFeetToMeterList(int start, int stop) { 
            
            for (int feet = start; feet <= 10; feet++) {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000}ft", feet, meter);
            }

        }
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double feet = FeetConverter.ToMeter(meter);
                Console.WriteLine("{0} ft = {1:0.0000}ft", feet, meter);
            }
            //クラスメソッド
            //double meter = FeetConverter.ToMeter(feet);

           



        }
    }
}
            
