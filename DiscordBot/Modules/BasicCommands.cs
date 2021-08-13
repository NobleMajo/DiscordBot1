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

namespace DiscordBot.Modules
{
    public class BasicCommands : ModuleBase<SocketCommandContext>
    {
        [Command("hi")]
        public async Task hi()
        {

            // initialize empty string builder for reply
            var sb = new StringBuilder();

            // get user info from the Context
            var user = Context.User;

            // build out the reply
            sb.AppendLine($"Hello {user}!");

            // send simple string reply
            await ReplyAsync(sb.ToString());
        }
        [Command("math")]
        public async Task Add(int numberOne, char operation, int numberTwo)
        {
            switch(operation)
            {
                case '+':
                    {
                        await ReplyAsync($"{numberOne} + {numberTwo} = {(numberOne + numberTwo).ToString()}");
                        break;
                    }
                case '-':
                    {
                        await ReplyAsync($"{numberOne} - {numberTwo} = {(numberOne-numberTwo).ToString()}");
                        break;
                    }
                case '/':
                    {
                        await ReplyAsync($"{numberOne} / {numberTwo} = {(numberOne / numberTwo).ToString()}");
                        break;
                    }
                case '*':
                    {
                        await ReplyAsync($"{numberOne} * {numberTwo} = {(numberOne * numberTwo).ToString()}");
                        break;
                    }
                case '%':
                    {
                        await ReplyAsync($"{numberOne} % {numberTwo} = {(numberOne % numberTwo).ToString()}");
                        break;
                    }


            }


        }
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
