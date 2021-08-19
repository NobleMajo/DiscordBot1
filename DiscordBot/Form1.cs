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
using DiscordBot.SafeThreading;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.IO;


namespace DiscordBot
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        

        Dictionary<string, ulong> Channel;
        Dictionary<string, ulong> Server;
        Dictionary<string, ulong> Members;
        Dictionary<string, ulong> Roles;

        Messages mess;
        SafeThreading.SafeThreadingForm safe;

        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;


        public Form1()
        {
            InitializeComponent();
            StatusLabel.Text = "Status: Offline";
            StatusLabel.BackColor = Color.Red;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TokenTextBox.Text = Properties.Settings.Default.Token;
            PrefixTextBox.Text = Properties.Settings.Default.Prefix;
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
            mess = new Messages();
            _client.Ready += LoadGuilds;
            _client.Ready += ReadyStatus;
            _client.Disconnected += OffStatus;
            _client.MessageReceived += HandleCommandAsync;
            _client.MessageReceived += AllChangesChange;
            _client.MessageReceived += MsgCouter;
            _client.MessageReceived += MessLog;
            _client.MessageReceived += mess.FilterMess;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }

        private async Task OffStatus(Exception arg)
        {
            safe = new SafeThreadingForm();
            safe.StatusLAbel("Status: Offline", Color.Red);
            await Task.Delay(1);
        }

        private async Task ReadyStatus()
        {
            safe = new SafeThreadingForm();
            safe.ConnectBtn("DISCONNECT");
            safe.StatusLAbel("Status: Online", Color.Green);
            await Task.Delay(1);
        }

        
        private async Task MessLog(SocketMessage arg)
        {
            
            safe.MessageLog(arg.Channel.Name + " >> " + arg.Author.Username + " : " + arg.Content + Environment.NewLine);
            await Task.Delay(1);
        }

        private int msgCount = 0;
        private async Task MsgCouter(SocketMessage arg)
        {
            msgCount++;
            safeChange(msgCount.ToString());
            await Task.Delay(1);
        }

        private async Task AllChangesChange(SocketMessage arg)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            Style = (MetroColorStyle)next;
            await Task.Delay(1);
        }


        private async Task HandleCommandAsync(SocketMessage arg)
        {
            try
            {
                var message = arg as SocketUserMessage;
                var context = new SocketCommandContext(_client, message);
                if (message.Author.IsBot) return;

                int argPos = 0;
                if (message.HasStringPrefix(PrefixTextBox.Text, ref argPos))
                {
                    var result = await _commands.ExecuteAsync(context, argPos, _services);
                    if (!result.IsSuccess) Console.WriteLine(result.ErrorReason);
                    if (result.Error.Equals(CommandError.UnmetPrecondition)) await message.Channel.SendMessageAsync(result.ErrorReason);
                }

            }
            catch { };
        }

        private Task _client_Log(LogMessage arg)
        {
            LogText(arg.ToString().Replace(DateTime.Now.ToString(), " "));
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
            if (serverMessagesButton.InvokeRequired)
            {
                Action safeWrite = delegate { safeChange(text); };
                serverMessagesButton.Invoke(safeWrite);
            }
            else
                serverMessagesButton.Text = text;
        }
        
        private async Task LoadGuilds()
        {

            safe = new SafeThreadingForm();
            safe.ClearBoxGuildsBox();
            Server = new Dictionary<string, ulong>();
            foreach (var server in _client.Guilds)
            {
                safe.ComboBoxServers(server.Name);
                Server.Add(server.Name, server.Id);
            }
            safe.SelectITemGuilds();
            safe.DisableBtnConnect();
            await Task.Delay(1);
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var myKey = Channel.FirstOrDefault(x => x.Key == ChannelsTExtBox.Text).Value;
                _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).GetTextChannel(myKey).SendMessageAsync(MessageBox.Text);
            } catch
            {

            }
        }

        private void LoadChannels()
        {
            Channel = new Dictionary<string, ulong>();
            ChannelsTExtBox.Items.Clear();

            foreach (var channel in _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).TextChannels)
            {
                try
                {
                    Channel.Add(channel.ToString(), channel.Id);
                    ChannelsTExtBox.Items.Add(channel.ToString());

                }
                catch
                {
                    ChannelsTExtBox.Items.Add("Not Able To Add this Channel");
                }
            }
            ChannelsTExtBox.SelectedIndex = 0;
        }

        private void GuildsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadInfo();
                LoadChannels();
                loadMembers();
                loadMessages();
                LoadRoles();
            }
            catch
            {

            }
        }
        public void loadInfo()
        {
            try
            {
                safe = new SafeThreadingForm();
                var myKey = Server.FirstOrDefault(x => x.Key == GuildsComboBox.Text).Value;
                ServerIdTextBox.Text = myKey.ToString();

                safe.SafeThreadBtns(ServerButton, _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).Name);
                safe.SafeThreadBtns(OwnerButton, _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).Owner.Username);
                string Created = _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).CreatedAt.ToString();
                Created = Created.Substring(0, Created.LastIndexOf("+"));
                safe.SafeThreadBtns(CreatedAtButton, Created);
                safe.SafeThreadBtns(RolesButton, _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).Roles.Count.ToString());
                safe.SafeThreadBtns(MembersButton, _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).Users.Count.ToString());
                safe.SafeThreadBtns(TotalChannelsButton, _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).Channels.Count.ToString());
            } catch
            {
            }
        }

        private void MessageBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                try
                {
                    var myKey = Channel.FirstOrDefault(x => x.Key == ChannelsTExtBox.Text).Value;
                    _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).GetTextChannel(myKey).SendMessageAsync(MessageBox.Text);
                    MessageBox.Text = "";
                }
                catch
                {

                }
            }
        }
        
        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                LoadInfoUSer();
            } catch
            {

            }

        }
        private void LoadInfoUSer()
        {

            try
            {
                safe = new SafeThreadingForm();
                var myKey = Members.FirstOrDefault(x => x.Key == usersComboBox.Text).Value;
                var user = _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).GetUser(myKey);
                safe.SafeThreadBtns(UserNameBox, user.Username);
                string nickname = user.Nickname;

                if (nickname == null || nickname == String.Empty || nickname == "")
                {
                    safe.SafeThreadBtns(NickNameBox, "Unknown");
                }
                else
                {
                    safe.SafeThreadBtns(UserNameBox, nickname);
                }
                safe.SafeThreadBtns(IDBox, user.Id.ToString());
                safe.SafeThreadBtns(UserStatusBox, user.Status.ToString());
                string joinedAt = user.JoinedAt.ToString();
                joinedAt = joinedAt.Substring(0, joinedAt.LastIndexOf("+"));
                safe.SafeThreadBtns(JoinBtn, joinedAt);
                safe.SafeThreadBtns(avatarUrlBox, user.GetAvatarUrl());
                if (user.GuildPermissions.Administrator)
                {
                    safe.SafeThreadBtns(PermissionsBox, "Administrator");
                }
                else
                {
                    safe.SafeThreadBtns(PermissionsBox, "User");
                }
                string createdAt = user.CreatedAt.ToString();
                createdAt = createdAt.Substring(0, createdAt.LastIndexOf("+"));
                safe.SafeThreadBtns(CreatedAtBtn, createdAt);
                safe.SafeTextBox(UserIDTextBox, user.Id.ToString());
                if (user.IsBot)
                {
                    safe.SafeThreadBtns(BotBtn, "Yes");
                }
                else
                {
                    safe.SafeThreadBtns(BotBtn, "No");
                }

            }
            catch
            {

            }
        }
        private void LoadUSerByID(ulong id)
        {
            safe = new SafeThreadingForm();
            var myName = Members.FirstOrDefault(x => x.Value == ulong.Parse(UserIDTextBox.Text)).Key;
            safe.SafeThreadingComboBoxItem(usersComboBox, myName);
            var user = _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).GetUser(id);
            safe.SafeThreadBtns(UserNameBox, user.Username);
            string nickname = user.Nickname;

            if (nickname == null || nickname == String.Empty || nickname == "")
            {
                safe.SafeThreadBtns(NickNameBox, "Unknown");
            }
            else
            {
                safe.SafeThreadBtns(UserNameBox, nickname);
            }
            safe.SafeThreadBtns(IDBox, user.Id.ToString());
            safe.SafeThreadBtns(UserStatusBox, user.Status.ToString());
            string joinedAt = user.JoinedAt.ToString();
            joinedAt = joinedAt.Substring(0, joinedAt.LastIndexOf("+"));
            safe.SafeThreadBtns(JoinBtn, joinedAt);
            safe.SafeThreadBtns(avatarUrlBox, user.GetAvatarUrl());
            if (user.GuildPermissions.Administrator)
            {
                safe.SafeThreadBtns(PermissionsBox, "Administrator");
            }
            else
            {
                safe.SafeThreadBtns(PermissionsBox, "User");
            }
            string createdAt = user.CreatedAt.ToString();
            createdAt = createdAt.Substring(0, createdAt.LastIndexOf("+"));
            safe.SafeThreadBtns(CreatedAtBtn, createdAt);
            if(user.IsBot)
            {
                safe.SafeThreadBtns(BotBtn, "Yes");
            }
            else
            {
                safe.SafeThreadBtns(BotBtn, "No");
            }
        }
        public void loadMembers()
        {
            safe = new SafeThreadingForm();
            Members = new Dictionary<string, ulong>();
            try
            {
                safe.ClearComboBox(usersComboBox);
                foreach (var member in _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).Users)
                {
                    Members.Add(member.Username, member.Id);
                    safe.safeComboThreading(usersComboBox, member.Username);
                }
            }
            catch
            {

            }
        }

        private void avatarUrlBox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(avatarUrlBox.Text);
            }
            catch { }
        }

        private void UserIDTextBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    LoadUSerByID(ulong.Parse(UserIDTextBox.Text));
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error", "You need to enter user Id first");
            }
            
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
           
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if(ShowToken.Checked)
            {
                TokenTextBox.PasswordChar = '\0';
                

            }
            else if(!ShowToken.Checked)
            {
                TokenTextBox.PasswordChar = '*';
            }
            
        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Properties.Settings.Default.Prefix = PrefixTextBox.Text;
            Properties.Settings.Default.Token = TokenTextBox.Text;
        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Properties.Settings.Default.Prefix = PrefixTextBox.Text;
            Properties.Settings.Default.Token = TokenTextBox.Text;
        }
        static Managers.BannedWords bannedWords;
        private void AddRemoveBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                bannedWords = new Managers.BannedWords();
                safe = new SafeThreadingForm();
                if(BannedWords.Items.Contains(AddRemoveBox.Text))
                {
                   bannedWords.RemoveWord(AddRemoveBox.Text);
                    safe.ClearComboBox(BannedWords);
                    bannedWords.getMessages();
                }
                else
                {
                    bannedWords.AddWord(AddRemoveBox.Text);
                    safe.ClearComboBox(BannedWords);
                    bannedWords.getMessages();
                }
                
            }
        }
        private void loadMessages()
        {
            try
            {
                bannedWords = new Managers.BannedWords();
                bannedWords.getMessages();
            }
            catch
            {

            }
        }

        private void BannedWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            safe = new SafeThreadingForm();
            safe.SafeTextBox(AddRemoveBox, BannedWords.Text);
        }
        private void LoadRoles()
        {
            safe = new SafeThreadingForm();
            Roles = new Dictionary<string, ulong>();
            Roles.Clear();
            safe.ClearComboBox(RolesComboBox);
            var roles = _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).Roles;
            foreach(var role in roles)
            {
                Roles.Add(role.Name, role.Id);
                safe.safeComboThreading(RolesComboBox, role.Name);
                
            }
        }

        private async void AddRoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var myword = Roles.FirstOrDefault(x => x.Key == RolesComboBox.Text).Value;
                await _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).GetUser(ulong.Parse(UserIDTextBox.Text)).AddRoleAsync(myword);
            }catch
            {

            }
        }

        private async void RemoveRoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var myword = Roles.FirstOrDefault(x => x.Key == RolesComboBox.Text).Value;
                await _client.GetGuild(ulong.Parse(ServerIdTextBox.Text)).GetUser(ulong.Parse(UserIDTextBox.Text)).RemoveRoleAsync(myword);
            }
            catch
            {

            }
        }
    }
}
