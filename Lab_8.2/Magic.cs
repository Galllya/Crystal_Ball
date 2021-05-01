using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    
    public class Magic
    {
        public double A;
        
        double[] nums = new double[9];
        public string DoAmazing()
        {
            nums[1] = 0.1;
            nums[2] = 0.13;
            nums[3] = 0.16;
            nums[4] = 0.08;
            nums[5] = 0.07;
            nums[6] = 0.15;
            nums[7] = 0.17;
            nums[8] = 0.14;
            

            Random rnd = new Random();

            double value = rnd.NextDouble();
            Math.Round(value, 2);
             A = value;
            int k = 1;
            while (A>=0)
            {
                A = A - nums[k];
                k++;
            }

            string word = "";
            k--;
            switch (k)
            {
                case 1:
                    word = "Бесспорно";
                    break;
                case 2:
                    word = "Можешь быть уверен в этом";
                    break;
                case 3:
                    word = "Мне кажется - ДА";
                    break;
                case 4:
                    word = "Дa";
                    break;
                case 5:
                    word = "Пока не ясно, попробуй снова";
                    break;
                case 6:
                    word = "Сконцентрируйся и спроси снова";
                    break;
                case 7:
                    word = "Даже не думай";
                    break;
                case 8:
                    word = "Весьма сомнительно";
                    break;
            }


            return word;
        }
    }
}
