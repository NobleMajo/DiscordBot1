using System;
using Discord.Commands;
using Discord.Net;
using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;
using DiscordBot;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace DiscordBot.TasksClient
{
    public class Messages : ModuleBase<SocketCommandContext>
    {
        private readonly string PATH = $@"{Environment.CurrentDirectory}/bannedWords.txt";
        public static List<string> bannedWords;
        public async Task FilterMess(SocketMessage arg)
        {
            bannedWords = new List<string>();
            bannedWords.Clear();
            string item;
            string msg = arg.ToString().ToLower();
            using(StreamReader read = File.OpenText(PATH))
            {
                while((item = read.ReadLine()) != null)
                {
                    bannedWords.Add(item);
                }
            }
            foreach(string items in bannedWords)
            {
                if(msg.Contains(items))
                {
                    await arg.DeleteAsync();
                }
            }
            
            
        }
        
            
        
    }
}
