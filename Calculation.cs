﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Calculation
    {
        private long count = 0;
        private long n = 0;
        private long m = 0;
        public long N {
            get
            {
                return n;
            }

            set
            {
                if (value < 1) throw new Exception();
                else n = value;
            }
        }
        public long M {
            get
            {
                return m;
            }

            set
            {
                if (value < 1) throw new Exception();
                else m = value;
            }
        }
        private long[] v;
        public long[] V
        {
            get
            {
                return v;
            }
            set
            {

                for(int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 1)
                    {
                       throw new Exception();
                    }
                }
                v = value;
            }
        }
       
        public long GetResult()
        {
            //time - мінімальний час виконання роботи
            //time -> min
            //(int)(time/v[0]) + (int)(time/v[1]) +...+ (int)(time/v[n-1]) >= m
            // x - приблизне значення time (x <= time)
            //x/v[0] + x/v[1] +...+ x/v[n-1] >= m
            double koef = 0;

            //знаходимо суму коефіцієнтів при х
            foreach (var item in v)
            {
                koef += 1.0 / item;
            }
            //знаходимо х
            long x = (long)(m / koef +1);
            
            //знаходимо кількість зображень оброблених за час х
            GetCount(x);
            //якщо кількість менша ніж задана, збільшуємо час на 1
            //цей етап необхідний оскільки х не точне, а приблизне значення
            while (count < m)
            {
                ++x;
                GetCount( x);
            }
            return x;
        }
        void GetCount(long x)
        {
            count = 0;
            foreach (var item in v)
            {
                count += x / item;
            }
        }

    }
}
