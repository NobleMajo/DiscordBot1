using Discord.Commands;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace DiscordBot.Modules
{
    public class meme : ModuleBase<SocketCommandContext>
    {
        [Command("meme")]
        public async Task Meme()
        {

            var client = new HttpClient();
            var result = await client.GetStringAsync("https://reddit.com/r/memes/random.json?limit=1");
            JArray arr = JArray.Parse(result);
            JObject post = JObject.Parse(arr[0]["data"]["children"][0]["data"].ToString());
            await ReplyAsync(post["url"].ToString());



        }
        [Command("automeme")]
        public async Task autoMeme(int number)
        {
            if (number > 20)
            {
                await ReplyAsync("You can't type bigger number than 20!");
            }
            else
            {

                for (int i = 0; i < number; i++)
                {

                    var client = new HttpClient();
                    var result = await client.GetStringAsync("https://reddit.com/r/memes/random.json?limit=1");
                    JArray arr = JArray.Parse(result);
                    JObject post = JObject.Parse(arr[0]["data"]["children"][0]["data"].ToString());
                    await ReplyAsync(post["url"].ToString());



                }
            }
        }

    }
}