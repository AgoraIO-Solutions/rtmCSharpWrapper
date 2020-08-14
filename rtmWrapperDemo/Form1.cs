using io.agora.rtm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public static IRtmWrapper rtm;
        public static IRtmChannel channel;
        public static string username;
        private const string APPID = "";
        static SynchronizationContext main_thread_sync_context_;
        StringBuilder log = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            main_thread_sync_context_ = new WindowsFormsSynchronizationContext();
            rtm = RtmWrapper.Instance;
            rtm.Initialize();
            rtm.OnLoginSuccess += Rtm_OnLoginSuccess;
            rtm.OnJoinSuccess += Rtm_OnJoinSuccess;
            rtm.OnMessageReceived += Rtm_OnMessageReceived;
            rtm.OnQueryStatusReceived += Rtm_OnQueryStatusReceived;
            rtm.OnChannelMemberCountReceived += Rtm_OnChannelMemberCountReceived;
            rtm.OnMemberChanged += Rtm_OnMemberChanged;
        }

        private void SendMessageToChat(string str)
        {
            log.Append("\r\n");
            log.Append(str);
            tbConsole.Text = log.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = tbAccountName.Text;
            rtm.Login(APPID, null, username);
            SendMessageToChat("user " + tbAccountName.Text + " login status: " + rtm.LoggedIn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtm.Logout();
            SendMessageToChat("user " + tbAccountName.Text + " login status: " + rtm.LoggedIn);
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            channel = rtm.JoinChannel(tbChannelName.Text);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            rtm.LeaveChannel(channel);
        }

        private void Rtm_OnMemberChanged(string userName, string channelId, bool joined)
        {
            main_thread_sync_context_.Post(UpdateChatUI, (userName + (joined ? " joined" : " left") + " channel " + channelId));
        }

        private void Rtm_OnChannelMemberCountReceived(long requestId, List<ChannelMemberCount> channelMembers)
        {
            foreach (var ch in channelMembers)
            {
                main_thread_sync_context_.Post(UpdateChatUI, ("Channel: " + ch.channelId + " has: " + ch.count + " member(s)"));
            }
        }

        private void Rtm_OnQueryStatusReceived(long requestId, PeerOnlineStatus peersStatus, int peerCount, int errorCode)
        {
            main_thread_sync_context_.Post(UpdateChatUI, ("Query users: " + ": " + (peersStatus.onlineState == 0)));
        }

        private void Rtm_OnMessageReceived(string userName, string msg)
        {
            main_thread_sync_context_.Post(UpdateChatUI, userName + ": " + msg);
        }

        public void Rtm_OnJoinSuccess()
        {
            main_thread_sync_context_.Post(UpdateChatUI, username + " joined the " + tbChannelName.Text + " channel");
        }

        public void UpdateChatUI(object text)
        {
            SendMessageToChat((string)text);
        }

        public void Rtm_OnLoginSuccess()
        {
            main_thread_sync_context_.Post(UpdateChatUI, username + " logged into the rtm");
        }

        private void btnSendChannelMsg_Click(object sender, EventArgs e)
        {
            channel.SendMessage(tbChannelMessage.Text);
            SendMessageToChat(username + " send channel message: "+ tbChannelMessage.Text);
        }

        private void btnSendPeerMsg_Click(object sender, EventArgs e)
        {
            SendMessageToChat(username + " send peer message: " + tbPeerMsg.Text);

            rtm.SendPeerMessage(tbPeer.Text, tbPeerMsg.Text, true);

            tbPeerMsg.Text = "";
        }
    }

    class ConsoleLog
    {
        public ConsoleLog(StringBuilder str)
        {
            this.data = str;
        }

        private StringBuilder data;

        public string Data { get => data.ToString();}

    }
}
