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
        private static string Name { get; set; }
        private static string Owner { get; set; }
        private static string TotalMembers { get; set; }
        private static string RolesNum {  get; set; }
        private static string TotalChannels {  get; set; }
        private static string CreatedAt { get; set; }
        [Command("set")]
        public async Task Set()
        {
            Name = Context.Guild.Name;
            Owner = Context.Guild.Owner.ToString();
            TotalMembers = Context.Guild.MemberCount.ToString();
            RolesNum = Context.Guild.Roles.Count.ToString();
            TotalChannels = Context.Guild.Channels.Count.ToString();
            CreatedAt = Context.Guild.CreatedAt.ToString();
            await ReplyAsync("done");
        }
        static SafeThreading.SafeThreadingForm safe;
        public async Task info()
        {  
            safe = new SafeThreading.SafeThreadingForm();
            safe.ServerNameText(Name);
            safe.ServerOwner(Owner);
            safe.TotalMembers(TotalMembers);
            safe.RolesNumber(RolesNum);
            safe.TotalChannels(TotalChannels);
            safe.CreatedAt(CreatedAt);
        }

    }
}
