using System;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using Discord.Commands;
using Discord.Net;
using Discord.WebSocket;
using Discord;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using DiscordBot.TasksClient;

namespace DiscordBot
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void ConnectBotToken_Click(object sender, EventArgs e)
        {
            await Task.Run(() => RunBotAsync().GetAwaiter().GetResult());
        }
      
        public async Task RunBotAsync()
        {
            await Task.Run(async () =>
            {
                _client = new DiscordSocketClient();
                _commands = new CommandService();
                _services = new ServiceCollection()
                    .AddSingleton(_client)
                    .AddSingleton(_commands)
                    .BuildServiceProvider();


                _client.Log += _client_Log;
                await RegisterCommandAsync();
                await _client.LoginAsync(TokenType.Bot, TokenTextBox.Text);
                await _client.StartAsync();
                await Task.Delay(-1);
            });
        }

        private async Task RegisterCommandAsync()
        {
            
            _client.MessageReceived += HandleCommandAsync;
            _client.MessageReceived += ColorChange;
            _client.MessageReceived += MsgCouter;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }
        private int msgCount = 0;
        private async Task MsgCouter(SocketMessage arg)
        {
            msgCount++;
            safeChange(msgCount.ToString());
            await Task.Delay(-1);
        }

        private Task ColorChange(SocketMessage arg)
        {
            
            var m = new Random();
            int next = m.Next(0, 13);
            Style = (MetroColorStyle)next;
            return Task.CompletedTask;
            
        }


        private async Task HandleCommandAsync(SocketMessage arg)
        {
            try
            {
                var message = arg as SocketUserMessage;
                var context = new SocketCommandContext(_client, message);
                if (message.Author.IsBot) return;
                int argpos = 0;
                if (message.HasStringPrefix(TokenTextBox.Text, ref argpos))
                {
                    var result = await _commands.ExecuteAsync(context, argpos, _services);
                    if (!result.IsSuccess) Console.WriteLine(result.ErrorReason);
                    if (result.Error.Equals(CommandError.UnmetPrecondition)) await message.Channel.SendMessageAsync(result.ErrorReason);
                }
               
            }
            catch
            {
            }
        }

        private Task _client_Log(LogMessage arg)
        {
            LogText(arg.ToString().Replace(DateTime.Now.ToString() , " "));
            return Task.CompletedTask;

        }
        public void LogText(string text)
        {
            if (logTextBox.InvokeRequired)
            {
               
                Action safeWrite = delegate { LogText(DateTime.Now + " " + text + " " + Environment.NewLine); };
                logTextBox.Invoke(safeWrite);
            }
            else
                logTextBox.Text += text;
        }
        public void safeChange(string text)
        {
            if(serverMessagesButton.InvokeRequired)
            {
                Action safeWrite = delegate { safeChange(text); };
                serverMessagesButton.Invoke(safeWrite);
            }
            else
                serverMessagesButton.Text += text;
        }
    }
}
