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

        private void ConnectBotToken_Click(object sender, EventArgs e)
        {


        }
        public async Task RunBotAsync()
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

        }

        private async Task RegisterCommandAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            try
            {
                var message = arg as SocketUserMessage;
                var context = new SocketCommandContext(_client, message);
                if (message.Author.IsBot) return;
                int argpos = 0;
                if (message.HasStringPrefix(TokenTextBox.Text, ref argpos)) ;
            }
            catch
            {
            }
        }

        private Task _client_Log(LogMessage arg)
        {
            logTextBox.Text = arg + " " + Environment.NewLine;
            return Task.CompletedTask;

        }
    }
}
