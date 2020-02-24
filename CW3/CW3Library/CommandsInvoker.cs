using CW3;
using System;
using System.Collections.Generic;
using System.Text;

namespace CW3Library
{
    public class CommandsInvoker
    {
        CalkulyatorPage page;
        public CommandsInvoker(CalkulyatorPage page)
        {
            this.page = page;
        }        
        public string GetResult(string buttonSequence)
        {
            var result = buttonSequence.Split(' ');
            foreach(var res in result)
            {
                page.buttons[res].Click();
            }
            return page.Display.Text;
        }

    }
}
