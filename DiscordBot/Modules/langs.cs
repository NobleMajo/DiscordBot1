using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.Commands;


namespace DiscordBot.Modules
{
    public class langs : ModuleBase<SocketCommandContext>
    {
        //hello worlds in diff langs
        [Command("hw")]
        public async Task hw(string lang)
        {
            lang = lang.ToLower();
            if (lang == "python")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.DarkRed);
                eb.WithTitle("Python");
                eb.WithDescription("");

                eb.WithDescription(("Input: " + "print('Hello, World!')\n\nOutput:  Hello, World!"));

                await ReplyAsync("", false, eb.Build());

            }
            else if (lang == "cpp" || lang == "c++")
            {
                var eb = new EmbedBuilder();
                eb.WithColor(Color.DarkBlue);
                eb.WithTitle("C++");
                eb.WithDescription("Input:  std::cout << \"Hello World!\" << std::endl;\n\nOutput:  Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }
            else if (lang == "pascal")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.DarkTeal);
                eb.WithTitle("Pascal");
                eb.WithDescription("Input:  writeln(\"Hello, World!\");\n\nOutput:  Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }
            else if (lang == "java")
            {
                var eb = new EmbedBuilder();
                eb.WithColor(Color.LightOrange);
                eb.WithTitle("Java");
                eb.WithDescription("Input:  System.out.println(\"Hello, World!\");\n\nOutput:  Hello, World!");
                await ReplyAsync("", false, eb.Build());

            }
            else if (lang == "c")
            {
                var eb = new EmbedBuilder();
                eb.WithColor(Color.Gold);
                eb.WithTitle("C");
                eb.WithDescription("Input:  printf(\"Hello, World!\");\n\nOutput:  Hello, World!");
                await ReplyAsync("", false, eb.Build());

            }
            else if (lang == "c#" || lang == "csharp")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.DarkGreen);
                eb.WithTitle("C#");
                eb.WithDescription("Input:  Console.WriteLine(\"Hello, World!\");\n\nOutput:  Hello, World!");
                await ReplyAsync("", false, eb.Build());


            }
            else if (lang == "swift")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.DarkOrange);
                eb.WithTitle("Swift");
                eb.WithDescription("Input:  print(\"Hello, World!\");\n\nOutput:  Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }
            else if (lang == "obj-c" || lang == "objective-c")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Blue);
                eb.WithTitle("Objective-C");
                eb.WithDescription("Input:  NSLog(@\"Hello, World!\");\n\nOutput:  Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }






        }
        [Command("swift")]
        public async Task swift([Remainder] string swift)
        {
            if (swift == "print(\"Hello, World!\")")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Green);
                eb.WithTitle("Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }
            else
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Red);
                eb.WithDescription("Error");
                await ReplyAsync("", false, eb.Build());
            }
        }
        [Command("cpp")]
        [Alias("c++")]
        public async Task cpp([Remainder] string cpp)
        {
            if (cpp == "std::cout <<\"Hello World!\"<< std::endl;")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Green);
                eb.WithTitle("Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }
            else
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Red);
                eb.WithDescription("Error");
                await ReplyAsync("", false, eb.Build());
            }
        }
        [Command("c#")]
        [Alias("csharp")]
        public async Task Csharp([Remainder] string csharp)
        {
            if (csharp == "Console.WriteLine(\"Hello, World!\");")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Green);
                eb.WithTitle("Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }
            else
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Red);
                eb.WithDescription("Error");
                await ReplyAsync("", false, eb.Build());
            }
        }
        [Command("java")]
        public async Task java([Remainder] string java)
        {
            if (java == "System.out.println(\"Hello, World!\");")
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Green);
                eb.WithTitle("Hello, World!");
                await ReplyAsync("", false, eb.Build());
            }
            else
            {
                var eb = new EmbedBuilder();

                eb.WithColor(Color.Red);
                eb.WithDescription("Error");
                await ReplyAsync("", false, eb.Build());
            }
        }
        //resources
        //        [Command("rs")]
        //        [Alias("resources")]
        //        public async Task Resources()
        //        {

        //            ComponentBuilder builder = new ComponentBuilder();


        //            #region emotes
        //            Emote swift = Emote.Parse("<:Swift:873157490269880331>");
        //            Emote java = Emote.Parse("<:Java:728535382911746109>");
        //            Emote cpp = Emote.Parse("<:cpp:873160253691269160>");
        //            Emote csharp = Emote.Parse("<:Csharp:873164472502607902>");
        //            Emote C = Emote.Parse("<:C:873165264752099329>");
        //            Emote Python = Emote.Parse("<:Python:728535382479863870>");
        //            Emote ObjC = Emote.Parse("<:objectivec:873174100556783656>");
        //            Emote Js = Emote.Parse("<:JavaScript:766270521947455528>");



        //#endregion
        //#region btns

        //            builder.WithButton("C++", null, ButtonStyle.Link, cpp, "https://www.cplusplus.com/", row: 0);
        //            builder.WithButton("C#", null, ButtonStyle.Link, csharp, "https://dotnet.microsoft.com/learn/csharp", row: 0);
        //            builder.WithButton("Java", null, ButtonStyle.Link, java, "https://docs.oracle.com/javase/7/docs/api/javax/annotation/Resource.html", row: 0);
        //            builder.WithButton("C", null, ButtonStyle.Link, C, "https://www.w3resource.com/c-programming-exercises/", row: 0);
        //            builder.WithButton("Swift", null, ButtonStyle.Link, swift, "https://developer.apple.com/swift/resources/", row: 1);
        //            builder.WithButton("Python", null, ButtonStyle.Link, Python, "https://www.fullstackpython.com/best-python-resources.html", row: 1);
        //            builder.WithButton("Obj-C", null, ButtonStyle.Link, ObjC, "https://developer.apple.com/library/archive/documentation/Cocoa/Conceptual/ProgrammingWithObjectiveC/Introduction/Introduction.html#//apple_ref/doc/uid/TP40011210-CH1-SW1", row: 1);
        //            builder.WithButton("JavaScript", null, ButtonStyle.Link, Js, "https://developer.mozilla.org/en-US/docs/Web/JavaScript", row: 2);
        //            #endregion


        //            await Context.Channel.SendMessageAsync("Resources!", component: builder.Build());
        //        }




        //    }
    }
}