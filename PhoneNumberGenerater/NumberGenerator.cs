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
        static int i = 0;
        public static List<String> Generate(List<String> number)
        {
            number = new List<string>();
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    String generated = "" + a + "" + b;
                    number.Add(generated);
                }
            }
            return number;
        }
        public static List<String> Generate2(List<String> number2)
        {
            List<String> number = new List<string>();

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < number2.Count; b++)
                {
                    String generated = "" + a + "" + number2[b];
                    number.Add(generated);
                }
            }

            return number;
        }

        public static async void GeneratePost(List<String> number2, String starts, NumbersTableAdapter adapter, Label label)
        {
            List<String> number = new List<string>();

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < number2.Count; b++)
                {
                    String generated = starts + "" + a + "" + number2[b];
                    //adapter.Insert(generated, "", "", "");
                    await X(generated, adapter, label);
                }
            }

            // return number;
        }

        public static Task X(String number2, NumbersTableAdapter adapter, Label label)
        {
            return Task.Run(() =>
            {
                adapter.Insert(number2, "", "", "");
                label.Text = "" + i;
                i++;
            });
        }



    }

}

