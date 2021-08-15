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
    public class BasicCommands : ModuleBase<SocketCommandContext>
    {
        [Command("hi")]
        public async Task Hi()
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
        [Command("flipcoin")]
        [Summary("Flips a coin which either it can be heads or tails (50/50)")]
        public async Task FlipCoin()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 3);

            if (number == 1)
            {
                await ReplyAsync("Heads!");
            }
            else
                await ReplyAsync("Tails!");
        }

    }
}
