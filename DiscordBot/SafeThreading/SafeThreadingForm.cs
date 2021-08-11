using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot.SafeThreading
{
    class SafeThreadingForm 
    {
        //all safe thread calls should be there 
        static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public void ServerNameText(string text)
        {
            if (myForm.ServerButton.InvokeRequired)
            {
                Action safeWrite = delegate { ServerNameText(text); };
                myForm.ServerButton.Invoke(safeWrite);
            }
            else
                myForm.ServerButton.Text = text;
        }
    }
}
