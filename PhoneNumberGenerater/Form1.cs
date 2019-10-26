
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhoneNumberGenerater
{
    public partial class Form1 : Form
    {

        private List<String> list1, list2, listFinal;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            list1 = NumberGenerator.Generate(list1);
            list1 = NumberGenerator.Generate2(list1);
            list1 = NumberGenerator.Generate2(list1);
            list1 = NumberGenerator.Generate2(list1);
            list1 = NumberGenerator.Generate2(list1);
            NumberGenerator.GeneratePost(list1, txtStarts.Text, numbersTableAdapter1, lblCount);
        }




    }
}
