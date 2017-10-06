using FacadeDemo.Apps;
using FacadeDemo.Controllers;

namespace FacadeDemo.Facade
{
    public class JoggingFacade
    {
        // These handles will be passed to this facade in a real application
        // also on actual device these controllers will be singleton too.
        TextStatusController textStatus = new TextStatusController();
        GPSController gps = new GPSController();
        MobileDataController data = new MobileDataController();
        MusicController iTunes = new MusicController();
        WifiController wifi = new WifiController();
        HeartRateMontiorController heartRateMonitor = new HeartRateMontiorController();
        MoodIndicatorController moodIndicator = new MoodIndicatorController();
        SportsTrackerApp app = new SportsTrackerApp();

        public void StartJogging()
        {
           // 1. Set IM Status to Away
            textStatus.SetToAway = true;
            
            // 2. Turn off the wifi -- save battery
            wifi.IsSwitchedOn = false;

            // 3. Switch on the Mobile Data
            data.IsSwitchedOn = true;

            // 4. Turn on the GPS
            gps.IsSwitchedOn = true;

            // 5. Turn on Heart Rate Monitor
            heartRateMonitor.IsSwitchedOn = true;

            // 6. Turn on Mood Indicator
            moodIndicator.IsSwitchedOn = true;

            // 7. Turn on the Music
            iTunes.IsSwitchedOn = true;

            // 8. Start the Sports-Tracker
            
            app.Start();

            // 9. Pair Heart Rate Monitor
            heartRateMonitor.Pair();

            // 10. Load GPS Map

            // 11. Load playlist 
            iTunes.LoadPlaylist("RockOut");

            // 12. Start playing music
            iTunes.Start();

            // 13. Start Monitoring Heart Rate
            heartRateMonitor.Start();
        }

        public void StopJogging()
        {
            // 1. Stop heart rate monitor
            heartRateMonitor.Stop();

            // 2. Turn off the Music
            iTunes.IsSwitchedOn = false;

            // 3. Turn off the GPS
            gps.IsSwitchedOn = false;

            // 4. Share Sports tracker stats on twitter and facebook
            app.Share();

            // 5. Stop the Sports Tracker
            app.Stop();

            // 6. Turn off heart rate monitor
            heartRateMonitor.IsSwitchedOn = false;

            // 7. Turn off the GPS
            moodIndicator.IsSwitchedOn = false;

            // 8. Turn off the Mobile Data
            data.IsSwitchedOn = false;

            // 9. Turn on the wifi
            wifi.IsSwitchedOn = true;
        }
    }
}