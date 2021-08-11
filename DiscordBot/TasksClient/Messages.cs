using System;
using Discord.Commands;
using Discord.Net;
using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;
using DiscordBot;
using System.Windows.Forms;
using System.Linq;

namespace DiscordBot.TasksClient
{
    public class Messages : ModuleBase<SocketCommandContext>
    {
        static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public async Task info()
        {
            try
            {

            }
            catch { }

         
        }

    }
}
