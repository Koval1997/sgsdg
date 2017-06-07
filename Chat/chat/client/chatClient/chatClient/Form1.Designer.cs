﻿namespace chatClient
{
    partial class chatForm
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
            this.enterChat = new System.Windows.Forms.Button();
            this.gui_userName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chat_msg = new System.Windows.Forms.TextBox();
            this.chat_send = new System.Windows.Forms.Button();
            this.gui_chat = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterChat
            // 
            this.enterChat.Location = new System.Drawing.Point(226, 4);
            this.enterChat.Name = "enterChat";
            this.enterChat.Size = new System.Drawing.Size(123, 23);
            this.enterChat.TabIndex = 0;
            this.enterChat.Text = "Войти";
            this.enterChat.UseVisualStyleBackColor = true;
            this.enterChat.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // gui_userName
            // 
            this.gui_userName.AutoSize = true;
            this.gui_userName.Location = new System.Drawing.Point(10, 9);
            this.gui_userName.Name = "gui_userName";
            this.gui_userName.Size = new System.Drawing.Size(111, 13);
            this.gui_userName.TabIndex = 1;
            this.gui_userName.Text = "Введите свой логин:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(120, 5);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 2;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(12, 144);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(524, 192);
            this.chatBox.TabIndex = 3;
            this.chatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // chat_msg
            // 
            this.chat_msg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chat_msg.Enabled = false;
            this.chat_msg.Location = new System.Drawing.Point(12, 344);
            this.chat_msg.Name = "chat_msg";
            this.chat_msg.Size = new System.Drawing.Size(395, 20);
            this.chat_msg.TabIndex = 4;
            this.chat_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_msg_KeyDown);
            // 
            // chat_send
            // 
            this.chat_send.Enabled = false;
            this.chat_send.Location = new System.Drawing.Point(413, 342);
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(123, 23);
            this.chat_send.TabIndex = 5;
            this.chat_send.Text = "Отправить";
            this.chat_send.UseVisualStyleBackColor = true;
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // gui_chat
            // 
            this.gui_chat.AutoSize = true;
            this.gui_chat.Location = new System.Drawing.Point(12, 128);
            this.gui_chat.Name = "gui_chat";
            this.gui_chat.Size = new System.Drawing.Size(68, 13);
            this.gui_chat.TabIndex = 6;
            this.gui_chat.Text = "Сообщения:";
            // 
            // userList
            // 
            this.userList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userList.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 21;
            this.userList.Location = new System.Drawing.Point(542, 4);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(129, 340);
            this.userList.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите IP сервера:";
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.gui_chat);
            this.Controls.Add(this.chat_send);
            this.Controls.Add(this.chat_msg);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.gui_userName);
            this.Controls.Add(this.enterChat);
            this.Name = "chatForm";
            this.Text = "OnlineChat";
            this.Load += new System.EventHandler(this.chatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterChat;
        private System.Windows.Forms.Label gui_userName;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.TextBox chat_msg;
        private System.Windows.Forms.Button chat_send;
        private System.Windows.Forms.Label gui_chat;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

