﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Марафон
{
    class ComboBoxItem
    {
        // Класс для элемента формы Combobox, содержащий текст и значение элемента
        public string text { get; set; }
        public string value { get; set; }
        public override string ToString()
        {
            return this.text;
        }
    }
}
