using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;


namespace RozetkaApp
{
    public class HtmlButton : HtmlControl
    {
        public void ClickAndWait5sec()
        {
            Click();
            System.Threading.Thread.Sleep(5000);
        }
    }
}
