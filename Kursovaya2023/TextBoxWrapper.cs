using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Kursovaya2023
{
    internal class TextBoxWrapper
    {
        private TextBox textBox;

        public TextBoxWrapper(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public Brush BorderBrush
        {
            get { return textBox.BorderBrush; }
            set { textBox.BorderBrush = value; }
        }
    }
}
