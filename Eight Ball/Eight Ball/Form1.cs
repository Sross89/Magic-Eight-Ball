using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eight_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = GetResults();
        }

        private string GetResults()
        {
            string[] options = new string[] 
                {"No",
                "Never",
                "Absolutely not",
                "Not likely",
                "Quite possibly not",
                "Maybe in your dreams.",
                "Yes",
                "Definitely",
                "Of course",
                "I'm not sure",
                "No one can know",
                "Your mother is a hamster",
                "It is possible",
                "If you believe it"};

            Random random = new Random();
            int randomNumber = random.Next(0, options.Length);
            return options[randomNumber];
        }
    }
}
