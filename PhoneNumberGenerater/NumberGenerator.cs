using PhoneNumberGenerater.PhoneNumberDbTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneNumberGenerater
{
    public class NumberGenerator
    {
        static List<String> number = new List<string>();
        public static List<String> Generate(String starts, String three,NumbersTableAdapter adapter)
        {

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            for (int e = 0; e < 10; e++)
                            {

                                for (int f = 0; f < 10; f++)
                                {

                                    for (int g = 0; g < 10; g++)
                                    {
                                        String generated = starts + "" + three + a + "" + b + "" + c + "" + d + "" + e + "" + f + "" + g;
                                        adapter.Insert(generated, "", "", "");
                                        //number.Add(generated);

                                    }

                                }

                            }
                        }
                    }
                }
            }
            return number;


        }





    }



}

