using System;
using FacadeDemo.Apps;
using FacadeDemo.Controllers;
using FacadeDemo.Facade;

namespace FacadeDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // First, life without Facade
            Console.WriteLine("*** Jog without Facade ***");
            JoggWithoutUsingFacade();
            Console.WriteLine();
            
            // Then, life with FACADE
            Console.WriteLine("*** Jog Using Facade ***");
            JoggWithFacade();

            Console.WriteLine("\nPress any key to end");
            Console.ReadLine();
        }

        private static void JoggWithoutUsingFacade()
        {
            // The phone has been booted up and all the controllers are running
            var textStatus = new TextStatusController();
            var gps = new GPSController();
            var data = new MobileDataController();
            var iTunes = new MusicController();
            var wifi = new WifiController();
            var heartRateMonitor = new HeartRateMontiorController();
            var moodIndicator = new MoodIndicatorController();

            ///////////// Going for Jogging /////////////////////

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
            var app = new SportsTrackerApp();
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
            

            ///////////// Back from Jogging /////////////////////
            Console.WriteLine();

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

        private static void JoggWithFacade()
        {
            var facade = new JoggingFacade();

            facade.StartJogging();
            Console.WriteLine();
            facade.StopJogging();
        }
    }
}