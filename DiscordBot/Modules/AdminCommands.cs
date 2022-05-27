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
        [Command("purge")]
        [Alias("clean", "clear")]

        [Summary("Downloads and removes X messages from the current channel.")]
        [RequireUserPermission(ChannelPermission.ManageMessages)]
        [RequireBotPermission(ChannelPermission.ManageMessages)]
        public async Task PurgeAsync(int amount)
        {



            // Check if the amount provided by the user is positive.
            if (amount <= 0)
            {
                await ReplyAsync("The amount of messages to remove must be positive.");
                return;
            }
            else if (amount > 100)
            {
                await ReplyAsync("You can't delete more than 100 messages");
            }
            else
            {
                var messages = await Context
                    .Channel.GetMessagesAsync(Context.Message, Direction.Before, amount)
                    .FlattenAsync();
                var filteredMessages = messages
                    .Where(x => (DateTimeOffset.UtcNow - x.Timestamp).TotalDays <= 14);

                var count = filteredMessages.Count();



                if (count == 0)
                {
                    await ReplyAsync("Nothing to delete.");
                }


                else
                {
                    await (Context.Channel as ITextChannel)
                        .DeleteMessagesAsync(messages);
                    await ReplyAsync($"Done! Removed {count} {(count > 1 ? "messages" : "message")}.");
                }

                messages = await Context
                    .Channel
                    .GetMessagesAsync(Context.Message, Direction.Around, 1)
                    .FlattenAsync();

                filteredMessages = messages
                    .Where(x => (DateTimeOffset.UtcNow - x.Timestamp).TotalDays <= 14);


                count = filteredMessages.Count();

                await (Context.Channel as ITextChannel)
                    .DeleteMessagesAsync(messages);

                messages = await Context
                    .Channel
                    .GetMessagesAsync(Context.Message, Direction.After, 1)
                    .FlattenAsync();

                filteredMessages = messages.Where(x => (DateTimeOffset.UtcNow - x.Timestamp)
                    .TotalDays <= 14);


                count = filteredMessages.Count();

                await (Context.Channel as ITextChannel)
                    .DeleteMessagesAsync(messages);


            }


        }
        [Command("unban")]
        [RequireBotPermission(GuildPermission.BanMembers)]
        public async Task UnbanTask(ulong userId)
        {
            await Context.Guild.RemoveBanAsync(userId);
            // Unbanned
        }
        [Command("kick"), Alias("Kick"), Summary("Kicks a user from the server")]
        [RequireUserPermission(GuildPermission.KickMembers, ErrorMessage = "You don't have rights for this command!")]
        public async Task Kick(SocketGuildUser userAccount)
        {
            string reason = "";
            var user = Context.User as SocketGuildUser;
            var role = (user as IGuildUser)
                .Guild
                .Roles
                .FirstOrDefault(x => x.Name == "Admin");

            if (!userAccount.Roles.Contains(role))
            {
                if (user.GuildPermissions.KickMembers)
                {
                    await userAccount.KickAsync(reason);
                    await Context.Channel.SendMessageAsync($"The user `{userAccount}` has been kicked!");
                }
                else
                {
                    await Context.Channel.SendMessageAsync("No permissions for kicking a user.");
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync("This User can't be kicked, because the user has a admin role.");
            }


        }
        [Command("jail")]
        [RequireUserPermission(GuildPermission.KickMembers, ErrorMessage = "You don't have rights for this command!")]
        public async Task JailRole(IUser user, int days, [Remainder] string reason)
        {
            IRole role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Issue");
            IChannel channel = Context.Guild.Channels.FirstOrDefault(x => x.Name == "mental-hospital");
            await (user as IGuildUser).AddRoleAsync(role);
            await Context.Guild.GetTextChannel(channel.Id).SendMessageAsync($"{user} is in jail for {days} D because [ {reason} ]");
            await ReplyAsync("done");


        }
        [Command("Info")]
        public async Task Info(IGuildUser user)
        {
            string perms = "";
            var userPerms = user.GuildPermissions.ToList().ToArray();
            var createdAt = user.CreatedAt.ToString();
            var joinedAt = user.JoinedAt.ToString();
            var premiumSince = user.PremiumSince.ToString();
            if (premiumSince == null || premiumSince == "")
            {
                premiumSince = "No boost";
            }
            else
            {
                premiumSince = premiumSince.Substring(0, premiumSince.IndexOf("+"));

            }
            string isBot = "";
            if (user.IsBot == false)
            {
                isBot = "No";
            }
            else
            {
                isBot = "Yes";
            }
            joinedAt = joinedAt.Substring(0, joinedAt.IndexOf('+'));
            createdAt = createdAt.Substring(0, createdAt.IndexOf("+"));
            for (int i = 0; i < userPerms.Length; i++)
            {
                perms += userPerms[i] + ",";
            }
            perms = perms.Substring(0, perms.LastIndexOf(","));
            var embed = new EmbedBuilder();
            embed.WithTitle($"Info about: {user.Username}");
            embed.WithThumbnailUrl(user.GetAvatarUrl());
            embed.WithDescription($"Status: {user.Status}"
            + $"\n\nuser ID: {user.Id}"
            + $"\n\nAccount Created: {createdAt}"
            + $"\n\nJoined: {joinedAt}"
            + $"\n\nBooster from: {premiumSince}"
            + $"\n\nBot: {isBot}"
            + $"\n\nPermissions: {perms}");
            embed.WithCurrentTimestamp();
            await ReplyAsync("", false, embed.Build());
        }
        [Command("serverinfo")]
        public async Task ServerInfo()
        {
            string createdAt = Context.Guild.CreatedAt.ToString();
            createdAt = createdAt.Substring(0, createdAt.IndexOf("+"));
            var embd = new EmbedBuilder();
            embd.WithTitle($"Server Name : {Context.Guild.Name}");
            embd.WithThumbnailUrl(Context.Guild.IconUrl);
            embd.WithDescription($"Owner Name : {Context.Guild.Owner.Nickname}"
            + $"\n\ncreated at : {createdAt}"
            + $"\n\nUsers : {Context.Guild.MemberCount}"
            + $"\n\nRoles : {Context.Guild.Roles.Count}"
            + $"\n\nText Channels : {Context.Guild.Channels.Count}"
            + $"\n\nVoice Channels : {Context.Guild.VoiceChannels.Count}"
            + $"\n\nEmotes : {Context.Guild.Emotes.Count}"
            + $"\n\n2FAuth : {Context.Guild.MfaLevel}"
            + $"\n\nBoosts :  {Context.Guild.PremiumSubscriptionCount}"
            + $"\n\nBoost Level : {Context.Guild.PremiumTier}");

            embd.WithCurrentTimestamp();
            await ReplyAsync("", false, embd.Build());




        }
        [Command("serverIn")]
        [RequireUserPermission(GuildPermission.KickMembers, ErrorMessage = "You don't have rights for this command!")]
        public async Task ServerInsigs()
        {
            if (Context.Guild.Id != 759424063130304592)
            {
                await ReplyAsync($"Data for {Context.Guild.Name} are not avaible");
                return;
            }
            var PAth = @"C:\Users\sindl\OneDrive\Plocha\Data";
            var keymetrics = $@"{PAth}/KeyMetrics.png";
            var messages = $@"{PAth}/messages.png";
            var joining = $@"{PAth}/joining.png";
            var leaves = $@"{PAth}/leaves.png";

            var msg = $@"{PAth}/msg.png";
            var speaking = $@"{PAth}/speaking.png";
            var from = $@"{PAth}/from.png";
            var devices = $@"{PAth}/devices.png";

            await Context.Channel.SendFileAsync(keymetrics);
            await Context.Channel.SendFileAsync(messages);
            await Context.Channel.SendFileAsync(joining);
            await Context.Channel.SendFileAsync(leaves);
            await Context.Channel.SendFileAsync(msg);
            await Context.Channel.SendFileAsync(speaking);
            await Context.Channel.SendFileAsync(from);
            await Context.Channel.SendFileAsync(devices);
            

        }


    }
}
