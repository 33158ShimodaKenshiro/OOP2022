﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01 {
    public class YearMonth {
        //4.1.1
        public int Year { get; private set; }

        public int Month { get; private set; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        public bool Is21Century {
            get {
                return Year >= 2001 && Year <= 2100;

            }
        }

        public YearMonth AddOneMonth() {
            if (Month == 12) {
                return new YearMonth(this.Year + 1, 1);
            }
            else {
                return new YearMonth(this.Year, this.Month + 1);
            }
        }

        //4.1.4
        public override string ToString() {
            //return Year + "年"+ Month +"月";
            return $"{ Year}年{Month}月";
        }
    }
}

