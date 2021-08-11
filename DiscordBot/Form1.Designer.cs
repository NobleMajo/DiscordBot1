
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
            this.MainTabs1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TokenTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tokenLabel = new MetroFramework.Controls.MetroLabel();
            this.ConnectBotToken = new MetroFramework.Controls.MetroButton();
            this.prefixLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MainTabs1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs1
            // 
            this.MainTabs1.Controls.Add(this.metroTabPage1);
            this.MainTabs1.Controls.Add(this.metroTabPage2);
            this.MainTabs1.Controls.Add(this.metroTabPage3);
            this.MainTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs1.Location = new System.Drawing.Point(20, 60);
            this.MainTabs1.Name = "MainTabs1";
            this.MainTabs1.SelectedIndex = 1;
            this.MainTabs1.Size = new System.Drawing.Size(334, 250);
            this.MainTabs1.TabIndex = 0;
            this.MainTabs1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(326, 208);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "General";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.prefixLabel);
            this.metroTabPage2.Controls.Add(this.ConnectBotToken);
            this.metroTabPage2.Controls.Add(this.tokenLabel);
            this.metroTabPage2.Controls.Add(this.TokenTextBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(326, 208);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Settings";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.logRichTextBox);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(326, 208);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Log";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(326, 208);
            this.logRichTextBox.TabIndex = 2;
            this.logRichTextBox.Text = "";
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
            this.TokenTextBox.UseSelectable = true;
            this.TokenTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TokenTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(12, 20);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(45, 19);
            this.tokenLabel.TabIndex = 3;
            this.tokenLabel.Text = "Token:";
            // 
            // ConnectBotToken
            // 
            this.ConnectBotToken.Location = new System.Drawing.Point(-4, 108);
            this.ConnectBotToken.Name = "ConnectBotToken";
            this.ConnectBotToken.Size = new System.Drawing.Size(334, 23);
            this.ConnectBotToken.TabIndex = 4;
            this.ConnectBotToken.Text = "CONNECT";
            this.ConnectBotToken.UseSelectable = true;
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(12, 70);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(45, 19);
            this.prefixLabel.TabIndex = 5;
            this.prefixLabel.Text = "Prefix:";
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
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 185);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Token:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 330);
            this.Controls.Add(this.MainTabs1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "DiscordBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabs1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTabs1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel tokenLabel;
        private MetroFramework.Controls.MetroTextBox TokenTextBox;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private MetroFramework.Controls.MetroButton ConnectBotToken;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel prefixLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

