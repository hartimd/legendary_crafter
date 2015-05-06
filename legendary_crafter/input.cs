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
            this.i_value = Int32.Parse(textBox.Text);
        }
    }
}