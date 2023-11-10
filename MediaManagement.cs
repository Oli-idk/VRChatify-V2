
using Windows.Storage.Streams;
using WindowsMediaController;
using static WindowsMediaController.MediaManager;

namespace VRChatify
{
    public class MediaManagement
    {
        private static readonly MediaManager mediaManager = new();

        private MediaSession? currentSession = null;

        private static string? currentSessionName = null;

        public void Init()
        {
            mediaManager.Start();
            mediaManager.OnAnySessionOpened += MediaManager_OnAnySessionOpened;
            mediaManager.OnAnySessionClosed += MediaManager_OnAnySessionClosed;
        }

        public MediaSession? GetCurrentSession()
        {
            if (currentSession == null)
            {
                try
                {
                    currentSession = mediaManager.CurrentMediaSessions.FirstOrDefault().Value;
                    if (currentSession == null) return null;
                    currentSessionName = currentSession.Id;
                    return currentSession;
                }
                catch (InvalidOperationException)
                {
                    return null;
                }
            }
            return currentSession;
        }

        private void MediaManager_OnAnySessionOpened(MediaSession mediaSession)
        {
            GetCurrentSession();
        }

        private void MediaManager_OnAnySessionClosed(MediaSession mediaSession)
        {
            GetCurrentSession();
        }

        public IRandomAccessStreamReference? GetSongImage()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.Thumbnail;
            }
            return null;
        }

        public string GetSongName()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.Title;
            }
            return "Unable to get Title";
        }

        public string GetSongArtist()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.Artist;
            }
            return "Unable to get Author";
        }

        public string GetAlbumTitle()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.AlbumTitle;
            }
            return "Unable to get Author";
        }

        public TimeSpan GetSongDuration()
        {
            var timeline = GetCurrentSession()?.ControlSession.GetTimelineProperties();
            if (timeline != null)
            {
                return timeline.EndTime;
            }
            return new TimeSpan();
        }

        public TimeSpan GetCurrentSongTime()
        {
            var timeline = GetCurrentSession()?.ControlSession?.GetTimelineProperties();
            if (timeline != null)
            {
                return timeline.Position;
            }
            return new TimeSpan();
        }

        public MediaManager GetMediaManager()
        {
            return mediaManager;
        }

        public void SetCurrentSession(MediaSession session)
        {
            currentSessionName = session.Id;
            currentSession = session;
        }

        public void NextSession()
        {
            var sessions = mediaManager.CurrentMediaSessions.Values.ToList();
            if (sessions.Count > 1 && currentSession != null)
            {
                int currentIndex = sessions.IndexOf(currentSession);
                int nextIndex = (currentIndex + 1) % sessions.Count;
                var nextSession = sessions[nextIndex];
                SetCurrentSession(nextSession);
            }
        }

        public void PreviousSession()
        {
            var sessions = mediaManager.CurrentMediaSessions.Values.ToList();
            if (sessions.Count > 1 && currentSession != null)
            {
                int currentIndex = sessions.IndexOf(currentSession);
                int nextIndex = (currentIndex - 1 + sessions.Count) % sessions.Count;
                var nextSession = sessions[nextIndex];
                SetCurrentSession(nextSession);
            }
        }

    }
}
