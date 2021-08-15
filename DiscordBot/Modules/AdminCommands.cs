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
namespace DiscordBot.Modules
{
    class AdminCommands : ModuleBase<SocketCommandContext>
    {
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
    }
}
