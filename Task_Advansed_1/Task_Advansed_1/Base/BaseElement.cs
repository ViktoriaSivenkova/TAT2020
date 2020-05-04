using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Task_Advansed_1.Base
{
    public class BaseElement : IWebElement
    {
        protected IWebElement Element { get; set; }
        public By Locator { get; }
        protected IWebDriver _webDriver = DriverContext.DriverContext.Driver;

        public string TagName => GetElement().TagName;
        public string Text => GetElement().Text;
        public bool Enabled => GetElement().Enabled;
        public bool Selected => GetElement().Selected;
        public Point Location => GetElement().Location;
        public Size Size => GetElement().Size;
        public bool Displayed => GetElement().Displayed;

        public BaseElement(By locator)
        {
            Locator = locator;
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <returns>System.String.</returns>
        public string GetText()
        {
            return GetElement().Text;
        }

        /// <summary>
        /// Gets the element.
        /// </summary>
        /// <returns>IWebElement.</returns>
        public IWebElement GetElement()
        {
            Element = DriverContext.DriverContext.Driver.FindElement(Locator);
            return Element;
        }

        /// <summary>
        /// Clears the content of this element.
        /// </summary>
        /// <remarks>If this element is a text entry element, the <see cref="M:OpenQA.Selenium.IWebElement.Clear" />
        /// method will clear the value. It has no effect on other elements. Text entry elements
        /// are defined as elements with INPUT or TEXTAREA tags.</remarks>
        public void Clear()
        {
            GetElement().Clear();
        }

        /// <summary>
        /// Simulates typing text into the element.
        /// </summary>
        /// <param name="text">The text to type into the element.</param>
        /// <seealso cref="T:OpenQA.Selenium.Keys" />
        /// <remarks>The text to be typed may include special characters like arrow keys,
        /// backspaces, function keys, and so on. Valid special keys are defined in
        /// <see cref="T:OpenQA.Selenium.Keys" />.</remarks>
        public void SendKeys(string text)
        {
            GetElement().SendKeys(text);
        }

        /// <summary>
        /// Submits this element to the web server.
        /// </summary>
        /// <remarks>If this current element is a form, or an element within a form,
        /// then this will be submitted to the web server. If this causes the current
        /// page to change, then this method will block until the new page is loaded.</remarks>
        public void Submit()
        {
            GetElement().Submit();
        }

        /// <summary>
        /// Clicks this element.
        /// </summary>
        /// <remarks><para>
        /// Click this element. If the click causes a new page to load, the <see cref="M:OpenQA.Selenium.IWebElement.Click" />
        /// method will attempt to block until the page has loaded. After calling the
        /// <see cref="M:OpenQA.Selenium.IWebElement.Click" /> method, you should discard all references to this
        /// element unless you know that the element and the page will still be present.
        /// Otherwise, any further operations performed on this element will have an undefined.
        /// behavior.
        /// </para>
        /// <para>
        /// If this element is not clickable, then this operation is ignored. This allows you to
        /// simulate a users to accidentally missing the target when clicking.
        /// </para></remarks>
        public void Click()
        {
            try
            {
                GetElement().Click();
            }
            catch (Exception)
            {
                JsClick();
            }
        }

        /// <summary>
        /// Moves to element.
        /// </summary>
        public void MoveToElement()
        {
            new Actions(_webDriver).MoveToElement(GetElement()).Build().Perform();
        }

        /// <summary>
        /// Jses the click.
        /// </summary>
        public void JsClick()
        {
            var executor = (IJavaScriptExecutor)_webDriver;
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", GetElement());
            executor.ExecuteScript("arguments[0].click();", GetElement());
        }

        /// <summary>
        /// Doubles the click.
        /// </summary>
        public void DoubleClick()
        {
            new Actions(_webDriver).DoubleClick(GetElement()).Perform();
        }

        /// <summary>
        /// Finds the first <see cref="T:OpenQA.Selenium.IWebElement" /> using the given method.
        /// </summary>
        /// <param name="by">The locating mechanism to use.</param>
        /// <returns>The first matching <see cref="T:OpenQA.Selenium.IWebElement" /> on the current context.</returns>
        public IWebElement FindElement(By by)
        {
            return GetElement().FindElement(by);
        }

        /// <summary>
        /// Gets the value of the specified attribute for this element.
        /// </summary>
        /// <param name="attributeName">The name of the attribute.</param>
        /// <returns>The attribute's current value. Returns a <see langword="null" /> if the
        /// value is not set.</returns>
        /// <remarks>The <see cref="M:OpenQA.Selenium.IWebElement.GetAttribute(System.String)" /> method will return the current value
        /// of the attribute, even if the value has been modified after the page has been
        /// loaded. Note that the value of the following attributes will be returned even if
        /// there is no explicit attribute on the element:
        /// <list type="table"><listheader><term>Attribute name</term><term>Value returned if not explicitly specified</term><term>Valid element types</term></listheader><item><description>checked</description><description>checked</description><description>Check Box</description></item><item><description>selected</description><description>selected</description><description>Options in Select elements</description></item><item><description>disabled</description><description>disabled</description><description>Input and other UI elements</description></item></list></remarks>
        public string GetAttribute(string attributeName)
        {
            return GetElement().GetAttribute(attributeName);
        }

        /// <summary>
        /// Gets the value of a JavaScript property of this element.
        /// </summary>
        /// <param name="propertyName">The name JavaScript the JavaScript property to get the value of.</param>
        /// <returns>The JavaScript property's current value. Returns a <see langword="null" /> if the
        /// value is not set or the property does not exist.</returns>
        public string GetProperty(string propertyName)
        {
            return GetElement().GetProperty(propertyName);
        }

        /// <summary>
        /// Gets the value of a CSS property of this element.
        /// </summary>
        /// <param name="propertyName">The name of the CSS property to get the value of.</param>
        /// <returns>The value of the specified CSS property.</returns>
        /// <remarks>The value returned by the <see cref="M:OpenQA.Selenium.IWebElement.GetCssValue(System.String)" />
        /// method is likely to be unpredictable in a cross-browser environment.
        /// Color values should be returned as hex strings. For example, a
        /// "background-color" property set as "green" in the HTML source, will
        /// return "#008000" for its value.</remarks>
        public string GetCssValue(string propertyName)
        {
            return GetElement().GetCssValue(propertyName);
        }

        /// <summary>
        /// Finds all <see cref="T:OpenQA.Selenium.IWebElement">IWebElements</see> within the current context
        /// using the given mechanism.
        /// </summary>
        /// <param name="by">The locating mechanism to use.</param>
        /// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of all <see cref="T:OpenQA.Selenium.IWebElement">WebElements</see>
        /// matching the current criteria, or an empty list if nothing matches.</returns>
        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return GetElement().FindElements(@by);
        }
    }
}