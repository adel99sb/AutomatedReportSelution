﻿using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace AutomatedReportAPI.Services
{
    public class WhatsAppService
    {
        private static IWebElement SearchInput;
        private static bool isReady;
        private static EdgeDriver EdgeDriver;
        public WhatsAppService()
        {
            // Set up Edge WebDriver
            EdgeDriver = new EdgeDriver();
            EdgeDriver.Navigate().GoToUrl("https://web.whatsapp.com/");
            isReady = false;
        }
        public bool isReadyToRun()
        {
            Console.WriteLine("Please scan the QR code and log in to WhatsApp Web.");
            try
            {
                SearchInput = EdgeDriver.FindElement(By.CssSelector("div[contenteditable='true']"));
                Console.WriteLine("Search input Find !!");
                isReady = true;
            }
            catch (Exception)
            {
                Console.WriteLine("not ready yet !!");
                isReady = false;
            }
            return isReady;
        }
        public async Task<string> SendMessageToList(List<string> recipients, string message)
        {
            if (isReady)
            {
                if (recipients.Count > 0 && !string.IsNullOrEmpty(message))
                {
                    int FiledTimes = 0;
                    try
                    {
                        foreach (var item in recipients)
                        {
                            var res = await SendMessage(item, message);
                            if (res)
                                continue;
                            FiledTimes++;
                        }
                        if (recipients.Count - FiledTimes == 0)
                            return $"{recipients.Count} Messages Sent Succesfully";
                        else
                            return $"{recipients.Count - FiledTimes} Sent and {FiledTimes}" +
                                $"has filed";
                    }
                    catch (Exception ex)
                    {
                        isReady = false;
                        return ex.Message;
                    }
                }
                else
                    return "Please Choose The Recipients List And Write The Message First.";
            }
            else
            {
                isReady = false;
                return "WhatsApp Service Is Not Avilabel !!";
            }
        }
        private async Task<bool> SendMessage(string recipient, string message)
        {
            if (isReady)
            {
                try
                {
                    SearchInput.Clear();
                    SearchInput.SendKeys(recipient + Keys.Enter);
                    SearchInput.Click();
                    var chatScreen = EdgeDriver.FindElement(By.Id("main"));
                    var messageInput = chatScreen.FindElement(By.CssSelector("div[contenteditable='true']"));
                    messageInput.SendKeys(message + Keys.Enter); // Send the message        
                    Console.WriteLine($"Message sent to {recipient}: {message}");
                    return true;
                }
                catch (Exception)
                {
                    isReady = false;
                }
            }

            return false;
        }
    }
}
