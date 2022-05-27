using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace DiscordBot.Modules
{

    public class FunCommands : ModuleBase<SocketCommandContext>
    {


        //all commands need to dd some 
        [Command("com")]
        [Alias("help")]
        public async Task com()
        {
            var eb = new EmbedBuilder();
            eb.WithColor(Color.Red);
            eb.WithTitle("Commands");
            eb.WithDescription("\n\nsmartbot" +

               "\n\nstupidbot" +

               "\n\nping" +

               "\n\nhello" +

               "\n\nAnnoying" +

               "\n\nMaths 5 x 5" +

               "\n\nhw lang" +

               "\n\nmeme" +

               "\n\nautomeme number(max 20)" +

               "\n\navatar" +

               "\n\nhack" +

               "\n\nInfo (user)" +

               "\n\nServerInfo" +

               "\n\nCointFlip" +

               "\n\nRandomNubber (Max)" +

               "\n\nHex (number)" +

               "\n\nrs" +

               "\n\n***Admin Commands***" +
               "\n\nEmb" +


               "\n\nban" +
               "\n\nPurge (number)" +
               "\n\nJail (user)" +

               "\n\nunban(userid)" +
               "\n\nkick" +
               "\n\ngiverole" +
               "\n\nremoverole" +
               "\n\nStartCount" +
               "\n\nSetCount" +
               "\n\nSetCount" +
               "\n\nFilter(on/off)");

            await ReplyAsync("", false, eb.Build());
        }
        [Command("hi")]

        public async Task Hi()
        {
            await ReplyAsync("Hi");
        }

        //some funny commands
        [Command("Annoying")]
        public async Task Annoying()
        {
            await ReplyAsync("Yes you are Annoying!");
        }
        [Command("stupidbot")]
        public async Task stupidBot()
        {
            await ReplyAsync("https://images-ext-2.discordapp.net/external/fj2WCoiUSojc9zoH3EtQ01tYDNRiOSlfyVZQ-nG8CCY/https/image.prntscr.com/image/GI5P8o_ZThaej659LnBiHw.png");
        }
        [Command("smartbot")]
        public async Task smartBot()
        {
            await ReplyAsync("https://cdn.discordapp.com/emojis/788666285579436073.png");
        }
        [Command("eranoob")]
        public async Task eraNoob()
        {
            for (int i = 0; i < 3; i++)
            {
                await ReplyAsync("You are an idiot");
            }
        }
        [Command("hello")]
        public async Task Hello()
        {
            string hello = "Hi how are you ?";
            await ReplyAsync(hello);
        }
        [Command("good")]
        public async Task nice()
        {
            await ReplyAsync("https://emoji.gg/assets/emoji/6843_Nice.png");
        }
        [Command("role")]
        public async Task role()
        {
            await ReplyAsync("");
        }
        [Command("avatar")]
        public async Task Avatar(IGuildUser avatar)
        {
            var embed = new EmbedBuilder();
            embed.WithTitle(avatar.Username);
            embed.WithImageUrl(avatar.GetAvatarUrl());
            await ReplyAsync("", false, embed.Build());
        }
    }
}