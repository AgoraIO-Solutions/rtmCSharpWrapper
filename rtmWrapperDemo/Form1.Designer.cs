namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRTMToken = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChannelName = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.tbChannelMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendChannelMsg = new System.Windows.Forms.Button();
            this.btnSendPeerMsg = new System.Windows.Forms.Button();
            this.tbPeerMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPeer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name";
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(36, 59);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(156, 21);
            this.tbAccountName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "RTM Token";
            // 
            // tbRTMToken
            // 
            this.tbRTMToken.Location = new System.Drawing.Point(36, 123);
            this.tbRTMToken.Name = "tbRTMToken";
            this.tbRTMToken.Size = new System.Drawing.Size(156, 21);
            this.tbRTMToken.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(36, 151);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(117, 150);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Channel Name";
            // 
            // tbChannelName
            // 
            this.tbChannelName.Location = new System.Drawing.Point(36, 222);
            this.tbChannelName.Name = "tbChannelName";
            this.tbChannelName.Size = new System.Drawing.Size(156, 21);
            this.tbChannelName.TabIndex = 7;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(36, 249);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 8;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(117, 249);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.TabIndex = 9;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // tbChannelMessage
            // 
            this.tbChannelMessage.Location = new System.Drawing.Point(36, 321);
            this.tbChannelMessage.Name = "tbChannelMessage";
            this.tbChannelMessage.Size = new System.Drawing.Size(156, 21);
            this.tbChannelMessage.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Channel Message";
            // 
            // btnSendChannelMsg
            // 
            this.btnSendChannelMsg.Location = new System.Drawing.Point(36, 348);
            this.btnSendChannelMsg.Name = "btnSendChannelMsg";
            this.btnSendChannelMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendChannelMsg.TabIndex = 12;
            this.btnSendChannelMsg.Text = "Send";
            this.btnSendChannelMsg.UseVisualStyleBackColor = true;
            this.btnSendChannelMsg.Click += new System.EventHandler(this.btnSendChannelMsg_Click);
            // 
            // btnSendPeerMsg
            // 
            this.btnSendPeerMsg.Location = new System.Drawing.Point(36, 502);
            this.btnSendPeerMsg.Name = "btnSendPeerMsg";
            this.btnSendPeerMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendPeerMsg.TabIndex = 19;
            this.btnSendPeerMsg.Text = "Send";
            this.btnSendPeerMsg.UseVisualStyleBackColor = true;
            this.btnSendPeerMsg.Click += new System.EventHandler(this.btnSendPeerMsg_Click);
            // 
            // tbPeerMsg
            // 
            this.tbPeerMsg.Location = new System.Drawing.Point(36, 468);
            this.tbPeerMsg.Name = "tbPeerMsg";
            this.tbPeerMsg.Size = new System.Drawing.Size(156, 21);
            this.tbPeerMsg.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Peer Message";
            // 
            // tbPeer
            // 
            this.tbPeer.Location = new System.Drawing.Point(36, 415);
            this.tbPeer.Name = "tbPeer";
            this.tbPeer.Size = new System.Drawing.Size(156, 21);
            this.tbPeer.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Peer Name";
            // 
            // tbConsole
            // 
            this.tbConsole.Enabled = false;
            this.tbConsole.Location = new System.Drawing.Point(244, 31);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(657, 491);
            this.tbConsole.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 534);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.btnSendPeerMsg);
            this.Controls.Add(this.tbPeerMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPeer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSendChannelMsg);
            this.Controls.Add(this.tbChannelMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.tbChannelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbRTMToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Agora RTM Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRTMToken;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChannelName;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.TextBox tbChannelMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendChannelMsg;
        private System.Windows.Forms.Button btnSendPeerMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPeer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPeerMsg;
        private System.Windows.Forms.TextBox tbConsole;
    }
}

