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

namespace DiscordBot.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        private readonly AdminCommands m_Service;

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
        public async Task Ban(IGuildUser userAccount, int daysBanned, string reason = null)
        {
            var user = Context.User as SocketGuildUser;

            if (!userAccount.GuildPermissions.Administrator)
            {
                if (user.GuildPermissions.BanMembers)
                {
                    await userAccount.BanAsync(daysBanned, reason);
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
        [Remarks("addrole [user]")]
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
        [Remarks("mute [user]")]
        [Summary("This allows admins to mute users.")]
        [RequireUserPermission(GuildPermission.Administrator)]
        [RequireUserPermission(GuildPermission.MuteMembers)]
        public async Task MuteUser(IGuildUser user)
{
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Muted");
            await (user as IGuildUser).AddRoleAsync(role);
        }

        [Command("unmute")]
        [Remarks("unmute [user]")]
        [Summary("This allows admins to unmute users.")]
        [RequireUserPermission(GuildPermission.Administrator)]
        [RequireUserPermission(GuildPermission.MuteMembers)]
        public async Task UnmuteUser(IGuildUser user)
        {
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Muted");
            await (user as IGuildUser).RemoveRoleAsync(role);
        }
    }
}
