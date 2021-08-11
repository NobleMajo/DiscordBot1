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
        public static int MsgCount { get; set; } = 0;
        public Task MsgCouter(SocketMessage msg)
        {
            //btns = new Form1();
            if(!msg.Author.IsBot)
            MsgCount++;
           // btns.serverMessagesButton.Text = MsgCount.ToString();
            return Task.CompletedTask;
        }

    }
}
