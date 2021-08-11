using System;
using Discord.Commands;
using Discord.Net;
using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;
using DiscordBot;

namespace DiscordBot.TasksClient
{
    public class Messages : ModuleBase<SocketCommandContext>
    {
        Form1 btns;
        public static int MsgCount { get; set; }
        public async Task MsgCouter(SocketMessage msg)
        {
            btns = new Form1();
            
            MsgCount++;
            btns.serverMessagesButton.Text = MsgCount.ToString();
            await Task.Delay(-1);
        }

    }
}
