using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Net;
using Discord.Commands;
using Discord;
using System.Windows.Forms;
using Discord.WebSocket;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace DiscordBot.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        private readonly AdminCommands m_Service;
        private readonly string PATH = $"{Environment.CurrentDirectory}/warns.txt";

        [Command("kick")]
        public async Task Kick(IGuildUser userAccount, string reason = null)
        {
            var user = Context.User as SocketGuildUser;

            if (!userAccount.GuildPermissions.Administrator)
            {
                if (user.GuildPermissions.KickMembers)
                {
                    await userAccount.KickAsync(reason);
                    await Context.Channel.SendMessageAsync($"The user `{userAccount}` has been kicked, for {reason}");
                }
                else
                {
                    await Context.Channel.SendMessageAsync("No permissions for kicking a user.");
                }
            }
            else
            {
                await ReplyAsync("You can't kick Admin");
            }
        }
        [Command("ban")]
        public async Task Ban(IGuildUser userAccount,string reason = null)
        {
            var user = Context.User as SocketGuildUser;

            if (!userAccount.GuildPermissions.Administrator)
            {
                if (user.GuildPermissions.BanMembers)
                {
                    await userAccount.BanAsync();
                    await Context.Channel.SendMessageAsync($"The user `{userAccount}` has been banned, for {reason}");
                }
                else
                {
                    await Context.Channel.SendMessageAsync("No permissions for banning a user.");
                }
            }
            else
            {
                await ReplyAsync("You can't ban Admin");
            }
        }
        [Command("addrole")]
     
        [Summary("This allows admins to add specific roles to a user.")]
        [RequireUserPermission(GuildPermission.Administrator)]
        [RequireUserPermission(GuildPermission.ManageRoles)]
        public async Task AddRoleUser(IGuildUser user, [Remainder] string role)
        {
            await m_Service.AddRoleUser(user, role);
        }

        [Command("removerole")]
        [Alias("removerole", "delrole")]
        [Remarks("delrole [user]")]
        [Summary("This allows admins to remove specific roles to a user.")]
        [RequireUserPermission(GuildPermission.Administrator)]
        [RequireUserPermission(GuildPermission.ManageRoles)]
        public async Task RemoveRoleUser(IGuildUser user, [Remainder] string role)
        {
            await m_Service.RemoveRoleUser(user, role);
        }

        [Command("mute")]
        [Summary("This allows admins to mute users.")]
        
        public async Task MuteUser(IGuildUser user)
        {
            var User = Context.User as SocketGuildUser;
            if (User.GuildPermissions.Administrator || User.Id == 422708001976221697)
            {
                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Muted");
                await (user as IGuildUser).AddRoleAsync(role);
                await ReplyAsync($"{user} was muted");
            }
            else
            {
                await ReplyAsync("No rights");
            }
        }

        [Command("unmute")]
        [Remarks("unmute [user]")]
        [Summary("This allows admins to unmute users.")]
        [RequireUserPermission(GuildPermission.MuteMembers)]
        public async Task UnmuteUser(IGuildUser user)
        {
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Muted");
            await (user as IGuildUser).RemoveRoleAsync(role);
        }

        [Command("warn")]
        [Remarks("warn [user]")]
        [Summary("This allows admins to warn users.")]
        [RequireUserPermission(GuildPermission.ManageRoles)]
        public async Task WarnUser(IGuildUser user, [Remainder]string reason)
        {
            await ReplyAsync($"{user} was warned reason: {reason}");
            string text;
            if(!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            //using (StreamReader read = File.OpenText(PATH))
            //{
            //    text = read.ReadToEnd();
            //}
            using(StreamWriter write = File.AppendText(PATH))
            {
                write.WriteLine($"!{user.Username} , {reason}!");
                //write.WriteLine(text);
            }

        }
        [Command("warns")]
        public async Task Warns(IGuildUser user)
        {
            var builder = new EmbedBuilder();
            builder.WithTitle($"warns {user.Username}");
            string text;
            string reasons = "";
            using(StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();
            }
            foreach (var item in Regex.Matches(text, $"!{user.Username} , (.*)"))
            {
                reasons += "\n" + item;
            }
            builder.WithDescription(reasons.Replace("!" , "").Replace(user.Username, "").Replace(",",""));
            await ReplyAsync("",false, builder.Build());
        }

    }
}
