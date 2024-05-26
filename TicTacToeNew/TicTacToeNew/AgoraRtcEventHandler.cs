using Agora.Rtc;
using System;

namespace TicTacToeNew
{
    internal class AgoraRtcEventHandler : IRtcEngineEventHandler
    {
        private readonly VideoScreen _form;

        public AgoraRtcEventHandler(VideoScreen form)
        {
            _form = form;
        }

        public override void OnJoinChannelSuccess(RtcConnection connection, int elapsed)
        {
            _form.OnJoinChannelSuccess(connection.channelId, connection.localUid, elapsed);
        }

        public override void OnUserJoined(RtcConnection connection, uint remoteUid, int elapsed)
        {
            _form.OnUserJoined(connection.channelId, remoteUid, elapsed);
        }

        public override void OnUserOffline(RtcConnection connection, uint remoteUid, USER_OFFLINE_REASON_TYPE reason)
        {
            _form.OnUserOffline(remoteUid, reason);
        }

        // Add additional event handlers as needed

        
    }
}
