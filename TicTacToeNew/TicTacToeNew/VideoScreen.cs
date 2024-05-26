using Agora.Rtc;
using System;
using TicTacToeNew;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeNew
{
    public partial class VideoScreen : Form
    {
        private string APP_ID = "APP_ID"; // Replace with your Agora App ID
        private IRtcEngine rtcEngine;
        private AgoraRtcEventHandler eventHandler;

        public VideoScreen()
        {
            InitializeComponent();
            InitializeAgoraEngine();
        }

        private void JoinChannel(string channelName)
        {
            rtcEngine.JoinChannel("", channelName, "Info", 0);
        }

        public void OnJoinChannelSuccess(string channel, uint uid, int elapsed)
        {
            Invoke(new Action(() =>
            {
                long v = (long)panelLocal.Handle.ToInt64();
                var localVideoCanvas = new VideoCanvas(v, RENDER_MODE_TYPE.RENDER_MODE_FIT, VIDEO_MIRROR_MODE_TYPE.VIDEO_MIRROR_MODE_AUTO, uid);
                rtcEngine.SetupLocalVideo(localVideoCanvas);
                rtcEngine.StartPreview();
            }));
        }

        public void OnUserJoined(string channel, uint uid, int elapsed)
        {
            Invoke(new Action(() =>
            {
                long v = (long)panelRemote.Handle.ToInt64(); // Assuming there is a separate panel for remote video
                var remoteVideoCanvas = new VideoCanvas(v, RENDER_MODE_TYPE.RENDER_MODE_FIT, VIDEO_MIRROR_MODE_TYPE.VIDEO_MIRROR_MODE_AUTO, uid);
                rtcEngine.SetupRemoteVideo(remoteVideoCanvas);
            }));
        }

        public void OnUserOffline(uint uid, USER_OFFLINE_REASON_TYPE reason)
        {
            Invoke(new Action(() =>
            {
                // Handle user offline
                // For example, you can clear the remote video display or show a message
            }));
        }

        private void LeaveChannel()
        {
            rtcEngine.LeaveChannel();
            rtcEngine.StopPreview();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string channelName = txtChannelName.Text;
            JoinChannel(channelName);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveChannel();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (rtcEngine != null)
            {
                rtcEngine.LeaveChannel();
                rtcEngine.Dispose();
            }
            base.OnFormClosing(e);
        }

        private void InitializeAgoraEngine()
        {
            // Initialize Agora RTC engine with context
            RtcEngineContext context = new RtcEngineContext(APP_ID, 123, CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_COMMUNICATION_1v1, AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_DEFAULT);
            rtcEngine = RtcEngine.CreateAgoraRtcEngine();
            rtcEngine.Initialize(context);

            eventHandler = new AgoraRtcEventHandler(this);
            rtcEngine.InitEventHandler(eventHandler);

            rtcEngine.EnableVideo();
        }
    }
}
