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
        private static string Name {  get; set; }
        [Command("set")]
        public async Task Set()
        {
            Name = Context.Guild.Name;
            await ReplyAsync("done");
        }
        static SafeThreading.SafeThreadingForm safe; 
        public async Task info()
        {
            safe = new SafeThreading.SafeThreadingForm();
            safe.ServerNameText(Name);
            //myForm.MembersButton.Text = Context.Guild.MemberCount.ToString();
            //myForm.OwnerButton.Text = Context.Guild.Owner.Username;
         
        }

    }
}
