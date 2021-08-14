using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace DiscordBot.SafeThreading
{
    class SafeThreadingForm
    {
        //all safe thread calls should be there 
        static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public void MessageLog(string log)
        {
            if (myForm.MessagesRichBo.InvokeRequired)
            {
                Action safeWrite = delegate { MessageLog(log); };
                myForm.MessagesRichBo.Invoke(safeWrite);
            }
            else
            {
                myForm.MessagesRichBo.Text += log;
            }
        }
        public void SafeTextBox(MetroTextBox txtB,string text)
        {
            if(txtB.InvokeRequired)
            {
                Action safeWrite = delegate { SafeTextBox(txtB, text); };
                txtB.Invoke(safeWrite);
            }
            else
            {
                txtB.Text = text;
            }
        }
        public void safeComboThreading(MetroComboBox cb, string name)
        {
            if (cb.InvokeRequired)
            {
                Action safeWrite = delegate { safeComboThreading(cb, name); };
                cb.Invoke(safeWrite);
            }
            else
            {
                cb.Items.Add(name);
            }
        }
        public void ClearComboBox(ComboBox cb)
        {
            if(cb.InvokeRequired)
            {
                Action safeWrite = delegate { ClearComboBox(cb); };
                cb.Invoke(safeWrite);
            }
            else
            {
                cb.Items.Clear();
            }
        }



        public void ComboBoxServers(string item)
        {
            if (myForm.GuildsComboBox.InvokeRequired)
            {
                Action safeWrite = delegate { ComboBoxServers(item); };
                myForm.GuildsComboBox.Invoke(safeWrite);
            }
            else
            {
                myForm.GuildsComboBox.Items.Add(item);
            }
        }
        public void StatusLAbel(string text, Color color)
        {
            if (myForm.StatusLabel.InvokeRequired)
            {
                Action safeWrite = delegate { StatusLAbel(text, color); };
                myForm.StatusLabel.Invoke(safeWrite);
            }
            else
            {
                myForm.ForeColor = color;
                myForm.StatusLabel.Text = text;
            }
        }
        public void ConnectBtn(string text)
        {
            if (myForm.ConnectBotToken.InvokeRequired)
            {
                Action safeWrite = delegate { ConnectBtn(text); };
                myForm.ConnectBotToken.Invoke(safeWrite);
            }
            else
            {
                myForm.ConnectBotToken.Text = text;
            }
        }
        public void ClearBoxGuildsBox()
        {
            if (myForm.GuildsComboBox.InvokeRequired)
            {
                Action safeWrite = delegate { ClearBoxGuildsBox(); };
                myForm.GuildsComboBox.Invoke(safeWrite);
            }
            else
            {
                myForm.GuildsComboBox.Items.Clear();
            }
        }
        public void SafeThreadingComboBoxItem(MetroComboBox cb, string text)
        {
            if (cb.InvokeRequired)
            {
                Action safeWrite = delegate { SafeThreadingComboBoxItem(cb, text); };
                cb.Invoke(safeWrite);
            }
            else
            {
                cb.SelectedItem = text;
            }
        }
        public void DisableBtnConnect()
        {
            if (myForm.ConnectBotToken.InvokeRequired)
            {
                Action safeWrite = delegate { DisableBtnConnect(); };
                myForm.ConnectBotToken.Invoke(safeWrite);
            }
            else
            {
                myForm.ConnectBotToken.Enabled = false;
            }
        }
        public void SelectITemGuilds()
        {
            if (myForm.GuildsComboBox.InvokeRequired)
            {
                Action safeWrite = delegate { SelectITemGuilds(); };
                myForm.GuildsComboBox.Invoke(safeWrite);
            }
            else
            {
                myForm.GuildsComboBox.SelectedIndex = 0;
            }
        }
        public void SafeThreadBtns(Button btn, string text)
        {
            if(btn.InvokeRequired)
            {
                Action safeWrite = delegate { SafeThreadBtns(btn,text); };
                btn.Invoke(safeWrite);
            }
            else
            {
                btn.Text = text;
            }
        }
    }
}
