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
        Managers.BannedWords banned;
        Dictionary<ulong, int> warns = new Dictionary<ulong, int>();
        private readonly string PATH = $@"{Environment.CurrentDirectory}/bannedWords.txt";
        public static List<string> bannedWords;
        public async Task FilterMess(SocketMessage arg)
        {
            try
            {

                if (arg.Author.IsBot) return;
                if (arg.Channel.Name == null) return;
                SocketUser user = arg.Author;
                var chnl = arg.Channel as SocketGuildChannel;
                var guild = chnl.Guild;
                bannedWords = new List<string>();
                bannedWords.Clear();
                string item;
                string msg = arg.ToString().ToLower();
                using (StreamReader read = File.OpenText(PATH))
                {
                    while ((item = read.ReadLine()) != null)
                    {
                        bannedWords.Add(item);
                    }
                }
                foreach (string items in bannedWords)
                {
                    if (msg.Contains(items) && arg.Author.IsBot == false)
                    {
                        if (!warns.ContainsKey(arg.Author.Id))
                        {
                            warns.Add(arg.Author.Id, 1);

                        }
                        else if (warns.ContainsKey(arg.Author.Id))
                        {
                            var MyWarns = warns.FirstOrDefault(x => x.Key == arg.Author.Id).Value;
                            warns.Remove(arg.Author.Id);
                            warns.Add(arg.Author.Id, MyWarns + 1);
                        }

                        var myWarns = warns.FirstOrDefault(x => x.Key == arg.Author.Id).Value;
                        await arg.DeleteAsync();
                        var DmChannel = await arg.Author.GetOrCreateDMChannelAsync();
                        if (myWarns == 3)
                        {
                            var role = guild.Roles.FirstOrDefault(x => x.Name == "Issue");
                            var user1 = user as SocketGuildUser;
                            await user1.AddRoleAsync(role);
                            await DmChannel.SendMessageAsync("You lost access to rooms for 24h");
                            return;
                        }

                        await DmChannel.SendMessageAsync($"{items} is banned if you send it {3 - myWarns} more times you will lose access to channels");
                        string ban;
                        foreach (string item2 in bannedWords)
                        {
                            ban += item2 + ",";
                        }
                        ban = ban.Substring(0, ban.LastIndexOf(","));
                        await DmChannel.SendMessageAsync($"Banned words: {ban}");

                    }
                }
            }catch (Exception ex)
            {
                return;
            }



        }
        static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public async Task Userj(SocketGuildUser user)
        {
            string text = myForm.ChannelsTExtBox.Text;
            var mykey = Form1.Channel.FirstOrDefault(x => x.Key == text).Value;
            var channel = Context.Client.GetChannel(mykey) as IMessageChannel;
            await channel.SendMessageAsync($"Welcome {user.Mention}!");
        }

        [Command("addword")]
        [RequireUserPermission(GuildPermission.Administrator, ErrorMessage = "You don't have rights")]
        public async Task AddBannedWord(string word)
        {
            banned = new Managers.BannedWords();
            banned.AddWord(word);
            banned.getMessages();
            await ReplyAsync(word + " is now banned");
        }
        [Command("removeword")]
        [RequireUserPermission(GuildPermission.Administrator, ErrorMessage = "You Don't have rights")]
        public async Task RemoveBannedWord(string word)
        {
            banned = new Managers.BannedWords();
            banned.RemoveWord(word);
            await ReplyAsync(word + " is not banned anymore");

        }
        

        
            
        
    }
}
