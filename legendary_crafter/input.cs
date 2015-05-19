using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace legendary_crafter
{
    internal class input
    {
        public int i_value
        {
            get;
            set;
        }

        public TextBox textBox
        {
            get;
            set;
        }

        public void setInput(TextBox textBox)
        {
            this.i_value = int.Parse(textBox.Text);
            //this.i_value = Int32.TryParse(textBox.Text);
            //Int32.TryParse(textBox.Text, out i_value);
            //this.i_value = i_value;
        }
    }
}