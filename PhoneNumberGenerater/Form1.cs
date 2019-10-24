using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace PhoneNumberGenerater
{
    public partial class Form1 : Form
    {

 
        public Form1()
        {
            InitializeComponent();
          
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<String> list = NumberGenerator.Generate(txtStarts.Text, txtThreeDigit.Text, numbersTableAdapter1);


        }

    

        
    }
}
