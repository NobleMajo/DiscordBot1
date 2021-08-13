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

        public void ServerOwner(string text)
        {
            if (myForm.OwnerButton.InvokeRequired)
            {
                Action safeWrite = delegate { ServerOwner(text); };
                myForm.OwnerButton.Invoke(safeWrite);
            }
            else
                myForm.OwnerButton.Text = text;
        }

        public void TotalMembers(string text)
        {
            if (myForm.MembersButton.InvokeRequired)
            {
                Action safeWrite = delegate { TotalMembers(text); };
                myForm.MembersButton.Invoke(safeWrite);
            }
            else
                myForm.MembersButton.Text = text;
        }
        public void RolesNumber(string text)
        {
            if (myForm.RolesButton.InvokeRequired)
            {
                Action safeWrite = delegate { RolesNumber(text); };
                myForm.RolesButton.Invoke(safeWrite);
            }
            else myForm.RolesButton.Text = text;
        }
        public void TotalChannels(string text)
        {
            if(myForm.TotalChannelsButton.InvokeRequired)
            {
                Action safeWrite = delegate { TotalChannels(text); };
                myForm.TotalChannelsButton.Invoke(safeWrite);
            }
            else
                myForm.TotalChannelsButton.Text = text;
        }
        public void CreatedAt(string text)
        {
            if (myForm.CreatedAtButton.InvokeRequired)
            {
                Action safeWrite = delegate { CreatedAt(text); };
                myForm.CreatedAtButton.Invoke(safeWrite);
            }
            else
                myForm.CreatedAtButton.Text = text;

        }
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
        public void ComboBoxServers(string item)
        {
            if(myForm.GuildsComboBox.InvokeRequired)
            {
                Action safeWrite = delegate { ComboBoxServers(item); };
                myForm.GuildsComboBox.Invoke(safeWrite);
            }
            else
            {
                myForm.GuildsComboBox.Items.Add(item);
            }
        }
        public void StatusLAbel(string text)
        {
            if (myForm.StatusLabel.InvokeRequired)
            {
                Action safeWrite = delegate { StatusLAbel(text); };
                myForm.StatusLabel.Invoke(safeWrite);
            }
            else
            {
                myForm.StatusLabel.Text = text;
            }
        }
        public void ConnectBtn(string text)
        {
            if(myForm.ConnectBotToken.InvokeRequired)
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
            if(myForm.GuildsComboBox.InvokeRequired)
            {
                Action safeWrite = delegate { ClearBoxGuildsBox(); };
                myForm.GuildsComboBox.Invoke(safeWrite);
            }
            else
            {
                myForm.GuildsComboBox.Items.Clear();
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
    }
}
