using System.Drawing;

namespace DiscordBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTabs1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.CreatedAtButton = new MetroFramework.Controls.MetroButton();
            this.TotalChannelsButton = new MetroFramework.Controls.MetroButton();
            this.RolesButton = new MetroFramework.Controls.MetroButton();
            this.OwnerButton = new MetroFramework.Controls.MetroButton();
            this.MembersButton = new MetroFramework.Controls.MetroButton();
            this.ServerButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.GuildsComboBox = new System.Windows.Forms.ComboBox();
            this.ServerIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.StatusLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.prefixLabel = new MetroFramework.Controls.MetroLabel();
            this.ConnectBotToken = new MetroFramework.Controls.MetroButton();
            this.tokenLabel = new MetroFramework.Controls.MetroLabel();
            this.TokenTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MessagesRichBo = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SendBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChannelsTExtBox = new MetroFramework.Controls.MetroComboBox();
            this.LoadBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.serverMessagesButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.MainTabs1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs1
            // 
            this.MainTabs1.Controls.Add(this.metroTabPage1);
            this.MainTabs1.Controls.Add(this.metroTabPage2);
            this.MainTabs1.Controls.Add(this.metroTabPage5);
            this.MainTabs1.Controls.Add(this.metroTabPage3);
            this.MainTabs1.Controls.Add(this.metroTabPage4);
            this.MainTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs1.Location = new System.Drawing.Point(20, 60);
            this.MainTabs1.Name = "MainTabs1";
            this.MainTabs1.SelectedIndex = 1;
            this.MainTabs1.Size = new System.Drawing.Size(1071, 445);
            this.MainTabs1.TabIndex = 0;
            this.MainTabs1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTabs1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = false;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1063, 403);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "General";
            this.metroTabPage1.VerticalScrollbarBarColor = false;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1063, 403);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.CreatedAtButton);
            this.metroPanel3.Controls.Add(this.TotalChannelsButton);
            this.metroPanel3.Controls.Add(this.RolesButton);
            this.metroPanel3.Controls.Add(this.OwnerButton);
            this.metroPanel3.Controls.Add(this.MembersButton);
            this.metroPanel3.Controls.Add(this.ServerButton);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(136, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(182, 403);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // CreatedAtButton
            // 
            this.CreatedAtButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreatedAtButton.Location = new System.Drawing.Point(0, 115);
            this.CreatedAtButton.Name = "CreatedAtButton";
            this.CreatedAtButton.Size = new System.Drawing.Size(182, 23);
            this.CreatedAtButton.TabIndex = 7;
            this.CreatedAtButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CreatedAtButton.UseSelectable = true;
            // 
            // TotalChannelsButton
            // 
            this.TotalChannelsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalChannelsButton.Location = new System.Drawing.Point(0, 92);
            this.TotalChannelsButton.Name = "TotalChannelsButton";
            this.TotalChannelsButton.Size = new System.Drawing.Size(182, 23);
            this.TotalChannelsButton.TabIndex = 6;
            this.TotalChannelsButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TotalChannelsButton.UseSelectable = true;
            // 
            // RolesButton
            // 
            this.RolesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RolesButton.Location = new System.Drawing.Point(0, 69);
            this.RolesButton.Name = "RolesButton";
            this.RolesButton.Size = new System.Drawing.Size(182, 23);
            this.RolesButton.TabIndex = 5;
            this.RolesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RolesButton.UseSelectable = true;
            // 
            // OwnerButton
            // 
            this.OwnerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OwnerButton.Location = new System.Drawing.Point(0, 46);
            this.OwnerButton.Name = "OwnerButton";
            this.OwnerButton.Size = new System.Drawing.Size(182, 23);
            this.OwnerButton.TabIndex = 4;
            this.OwnerButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OwnerButton.UseSelectable = true;
            // 
            // MembersButton
            // 
            this.MembersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MembersButton.Location = new System.Drawing.Point(0, 23);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(182, 23);
            this.MembersButton.TabIndex = 3;
            this.MembersButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MembersButton.UseSelectable = true;
            // 
            // ServerButton
            // 
            this.ServerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServerButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServerButton.Location = new System.Drawing.Point(0, 0);
            this.ServerButton.Name = "ServerButton";
            this.ServerButton.Size = new System.Drawing.Size(182, 23);
            this.ServerButton.TabIndex = 2;
            this.ServerButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ServerButton.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroButton8);
            this.metroPanel2.Controls.Add(this.metroButton6);
            this.metroPanel2.Controls.Add(this.metroButton4);
            this.metroPanel2.Controls.Add(this.metroButton3);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(136, 403);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton8
            // 
            this.metroButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton8.Location = new System.Drawing.Point(0, 115);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(136, 23);
            this.metroButton8.TabIndex = 7;
            this.metroButton8.Text = "Created at:";
            this.metroButton8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton8.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton6.Location = new System.Drawing.Point(0, 92);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(136, 23);
            this.metroButton6.TabIndex = 6;
            this.metroButton6.Text = "Total Channels:";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton4.Location = new System.Drawing.Point(0, 69);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(136, 23);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Roles:";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton3.Location = new System.Drawing.Point(0, 46);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(136, 23);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Owner:";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton2.Location = new System.Drawing.Point(0, 23);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(136, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Members:";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(136, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Server:";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.GuildsComboBox);
            this.metroTabPage2.Controls.Add(this.ServerIdTextBox);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.StatusLabel);
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.prefixLabel);
            this.metroTabPage2.Controls.Add(this.ConnectBotToken);
            this.metroTabPage2.Controls.Add(this.tokenLabel);
            this.metroTabPage2.Controls.Add(this.TokenTextBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = false;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 0;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1063, 403);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Settings";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = false;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 0;
            // 
            // GuildsComboBox
            // 
            this.GuildsComboBox.FormattingEnabled = true;
            this.GuildsComboBox.Location = new System.Drawing.Point(802, 46);
            this.GuildsComboBox.Name = "GuildsComboBox";
            this.GuildsComboBox.Size = new System.Drawing.Size(129, 21);
            this.GuildsComboBox.TabIndex = 11;
            this.GuildsComboBox.SelectedIndexChanged += new System.EventHandler(this.GuildsComboBox_SelectedIndexChanged);
            // 
            // ServerIdTextBox
            // 
            // 
            // 
            // 
            this.ServerIdTextBox.CustomButton.Image = null;
            this.ServerIdTextBox.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.ServerIdTextBox.CustomButton.Name = "";
            this.ServerIdTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerIdTextBox.CustomButton.TabIndex = 1;
            this.ServerIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerIdTextBox.CustomButton.UseSelectable = true;
            this.ServerIdTextBox.CustomButton.Visible = false;
            this.ServerIdTextBox.Lines = new string[0];
            this.ServerIdTextBox.Location = new System.Drawing.Point(802, 17);
            this.ServerIdTextBox.MaxLength = 32767;
            this.ServerIdTextBox.Name = "ServerIdTextBox";
            this.ServerIdTextBox.PasswordChar = '\0';
            this.ServerIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerIdTextBox.SelectedText = "";
            this.ServerIdTextBox.SelectionLength = 0;
            this.ServerIdTextBox.SelectionStart = 0;
            this.ServerIdTextBox.ShortcutsEnabled = true;
            this.ServerIdTextBox.Size = new System.Drawing.Size(129, 23);
            this.ServerIdTextBox.TabIndex = 10;
            this.ServerIdTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ServerIdTextBox.UseSelectable = true;
            this.ServerIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "ServerID:";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 239);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(70, 19);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Bot Status:";
            this.StatusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(59, 66);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(63, 23);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(12, 70);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(45, 19);
            this.prefixLabel.TabIndex = 5;
            this.prefixLabel.Text = "Prefix:";
            this.prefixLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ConnectBotToken
            // 
            this.ConnectBotToken.Location = new System.Drawing.Point(-4, 108);
            this.ConnectBotToken.Name = "ConnectBotToken";
            this.ConnectBotToken.Size = new System.Drawing.Size(403, 23);
            this.ConnectBotToken.TabIndex = 4;
            this.ConnectBotToken.Text = "CONNECT";
            this.ConnectBotToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConnectBotToken.UseSelectable = true;
            this.ConnectBotToken.Click += new System.EventHandler(this.ConnectBotToken_Click);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(12, 20);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(45, 19);
            this.tokenLabel.TabIndex = 3;
            this.tokenLabel.Text = "Token:";
            this.tokenLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TokenTextBox
            // 
            // 
            // 
            // 
            this.TokenTextBox.CustomButton.Image = null;
            this.TokenTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.TokenTextBox.CustomButton.Name = "";
            this.TokenTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TokenTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TokenTextBox.CustomButton.TabIndex = 1;
            this.TokenTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TokenTextBox.CustomButton.UseSelectable = true;
            this.TokenTextBox.CustomButton.Visible = false;
            this.TokenTextBox.Lines = new string[0];
            this.TokenTextBox.Location = new System.Drawing.Point(59, 19);
            this.TokenTextBox.MaxLength = 32767;
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.PasswordChar = '\0';
            this.TokenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TokenTextBox.SelectedText = "";
            this.TokenTextBox.SelectionLength = 0;
            this.TokenTextBox.SelectionStart = 0;
            this.TokenTextBox.ShortcutsEnabled = true;
            this.TokenTextBox.Size = new System.Drawing.Size(230, 23);
            this.TokenTextBox.TabIndex = 2;
            this.TokenTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TokenTextBox.UseSelectable = true;
            this.TokenTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TokenTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.panel2);
            this.metroTabPage5.Controls.Add(this.panel1);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(1063, 403);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Messages";
            this.metroTabPage5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.MessagesRichBo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 353);
            this.panel2.TabIndex = 3;
            // 
            // MessagesRichBo
            // 
            this.MessagesRichBo.BackColor = System.Drawing.SystemColors.InfoText;
            this.MessagesRichBo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesRichBo.ForeColor = System.Drawing.SystemColors.Info;
            this.MessagesRichBo.Location = new System.Drawing.Point(0, 0);
            this.MessagesRichBo.Name = "MessagesRichBo";
            this.MessagesRichBo.Size = new System.Drawing.Size(1063, 315);
            this.MessagesRichBo.TabIndex = 1;
            this.MessagesRichBo.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MessageBox);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 38);
            this.panel3.TabIndex = 0;
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBox.ForeColor = System.Drawing.SystemColors.Info;
            this.MessageBox.Location = new System.Drawing.Point(0, 0);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(933, 38);
            this.MessageBox.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SendBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(933, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 38);
            this.panel4.TabIndex = 0;
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.Black;
            this.SendBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SendBtn.Location = new System.Drawing.Point(0, 0);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(130, 38);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ChannelsTExtBox);
            this.panel1.Controls.Add(this.LoadBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 50);
            this.panel1.TabIndex = 2;
            // 
            // ChannelsTExtBox
            // 
            this.ChannelsTExtBox.FormattingEnabled = true;
            this.ChannelsTExtBox.ItemHeight = 23;
            this.ChannelsTExtBox.Location = new System.Drawing.Point(21, 9);
            this.ChannelsTExtBox.Name = "ChannelsTExtBox";
            this.ChannelsTExtBox.Size = new System.Drawing.Size(178, 29);
            this.ChannelsTExtBox.TabIndex = 2;
            this.ChannelsTExtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChannelsTExtBox.UseSelectable = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(205, 9);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 29);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoadBtn.UseSelectable = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click_1);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.logTextBox);
            this.metroTabPage3.HorizontalScrollbarBarColor = false;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 0;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1063, 403);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Log";
            this.metroTabPage3.VerticalScrollbarBarColor = false;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 0;
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(1063, 403);
            this.logTextBox.TabIndex = 2;
            this.logTextBox.Text = "";
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroPanel5);
            this.metroTabPage4.Controls.Add(this.metroPanel4);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1063, 403);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Stats";
            this.metroTabPage4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.serverMessagesButton);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(97, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(161, 403);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // serverMessagesButton
            // 
            this.serverMessagesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.serverMessagesButton.Location = new System.Drawing.Point(0, 0);
            this.serverMessagesButton.Name = "serverMessagesButton";
            this.serverMessagesButton.Size = new System.Drawing.Size(161, 23);
            this.serverMessagesButton.TabIndex = 2;
            this.serverMessagesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serverMessagesButton.UseSelectable = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroButton5);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(97, 403);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroButton5
            // 
            this.metroButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton5.Location = new System.Drawing.Point(0, 0);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(97, 23);
            this.metroButton5.TabIndex = 2;
            this.metroButton5.Text = "Server Messages:";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 525);
            this.Controls.Add(this.MainTabs1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "DiscordBot";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabs1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTabs1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel tokenLabel;
        private MetroFramework.Controls.MetroTextBox TokenTextBox;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton ConnectBotToken;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel prefixLabel;
        public MetroFramework.Controls.MetroLabel StatusLabel;
        private System.Windows.Forms.RichTextBox logTextBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroButton RolesButton;
        public MetroFramework.Controls.MetroButton OwnerButton;
        public MetroFramework.Controls.MetroButton MembersButton;
        public MetroFramework.Controls.MetroButton ServerButton;
        public MetroFramework.Controls.MetroTabPage metroTabPage4;
        public MetroFramework.Controls.MetroPanel metroPanel5;
        public MetroFramework.Controls.MetroButton serverMessagesButton;
        public MetroFramework.Controls.MetroPanel metroPanel4;
        public MetroFramework.Controls.MetroButton metroButton5;
        public MetroFramework.Controls.MetroButton CreatedAtButton;
        public MetroFramework.Controls.MetroButton TotalChannelsButton;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RichTextBox MessagesRichBo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton LoadBtn;
        private MetroFramework.Controls.MetroComboBox ChannelsTExtBox;
        private MetroFramework.Controls.MetroTextBox ServerIdTextBox;
        private MetroFramework.Controls.MetroLabel label1;
        public System.Windows.Forms.ComboBox GuildsComboBox;
    }
}

