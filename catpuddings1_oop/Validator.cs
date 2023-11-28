using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public static class Validator
    {
        private static string title = "Entry Error";

        private static string Title
        { 
            get => title;
            set => title = value;
        }




        public static bool isPresent(TextBox textbox)
        {
            if(textBox.Text = "")
            {
                MessageBox.Show(textBox.Tag + " is a required field", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool isInt32(TextBox textbox)
        {
            int number = 0
            if (Int32.TryParse(textBox.Text , out number))
            {
                return true;
            }
            return true;
            else
            {
                MessageBox.Show(textBox.Tag + " is a required field", Title);
                textBox.Focus();
                return false;
            }
        }

    }
}
