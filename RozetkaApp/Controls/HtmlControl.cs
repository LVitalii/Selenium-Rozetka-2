using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;


namespace RozetkaApp
{
    public class HtmlControl : IWebElement
    {
        private IWebElement element;
        
        public bool IsAvailable()
        {
            try
            {
                bool result = true;
                if (this.Displayed && this.Enabled)
                {
                    result = result && true;
                }
                else
                {
                    Console.Out.WriteLine("Element is not displayed and enabled on page: " + this.ToString());
                    result = result && false;
                }
                return result;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public void Clear()
        {
            this.element.Clear();
        }

        public void Click()
        {
            this.element.Click();
        }

        public bool Displayed
        {
            get { return this.element.Displayed; }
            private set {  }
        }

        public bool Enabled
        {
            get { return this.element.Enabled; }
            private set { }
        }

        public string GetAttribute(string attributeName)
        {
            return this.element.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return this.element.GetCssValue(propertyName);
        }

        public System.Drawing.Point Location
        {
            get { return this.element.Location; }
            private set { }
        }

        public bool Selected
        {
            get { return this.element.Selected; }
            private set { }
        }

        public void SendKeys(string text)
        {
            this.element.SendKeys(text);
        }

        public System.Drawing.Size Size
        {
            get { return this.element.Size; }
            private set { }
        }

        public void Submit()
        {
            this.element.Submit();
        }

        public string TagName
        {
            get { return this.element.TagName; }
            private set { }
        }

        public string Text
        {
            get { return this.element.Text; }
            private set { }
        }

        public IWebElement FindElement(By by)
        {
            return this.element.FindElement(by);
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return this.element.FindElements(by);
        }
    }
}
