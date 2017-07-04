using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace RozetkaApp
{
    public class HtmlTextBox : HtmlControl
    {
        public string TextToLower()
        {
            return this.Text.ToLower();
        }
    }
}
