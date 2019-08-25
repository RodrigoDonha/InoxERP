using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Business
{
    class GeneralFunctions
    {
        public void CtrlC(string selectedText)
        {
            if (selectedText != "") 
            {
                SendKeys.Send("^(C)");
            }
        }

        public void CtrlV(string selectedText)
        {
            SendKeys.Send("^(V)");
        }

        public void CtrlX(string selectedText)
        {
            SendKeys.Send("^(X)");
        }
    }
}
