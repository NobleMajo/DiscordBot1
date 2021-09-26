using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Net;
using Discord.Commands;
using System.IO;
using Discord.WebSocket;
using System.Text.RegularExpressions;

namespace DiscordBot.Modules
{
    public class customCommands : ModuleBase<SocketCommandContext>
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}/smallDB/customCommands.txt";
        [Command("create")]
        public async Task Create(string com , [Remainder]string action)
        {
            if(action.ToLower().Contains("@everyone") || action.ToLower().Contains("@here"))
            {
                return;
            }
            if(!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            using (StreamWriter writer = File.AppendText(PATH))
            {
                writer.WriteLine($"!{com} , {action}!");
            }
        }
        public async Task Read(SocketMessage msg)
        {
            string text = "";
            if(msg.Content.Contains("+"))
            {
                using (StreamReader read = File.OpenText(PATH))
                {
                    text = read.ReadToEnd();
                }
                Match match = Regex.Match(text, $"!{msg.Content.Replace("+", "")} , (.*)!");
                if (match.Success)
                {
                    await msg.Channel.SendMessageAsync(match.Groups[1].ToString());
                    await Context.Channel.SendMessageAsync(match.Groups[1].ToString());
                }
                
                
            }
        }

    }
}
