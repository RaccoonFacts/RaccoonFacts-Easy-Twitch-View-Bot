 /**
Hello, Good luck. Don't get banned. You need to install selenium. 

Here is a list of proxies, I hope it helps. 

        EZ LIST -> Use this tbh -> only using this for right now
        will add more later and others. May need to put this to a JSON file or txt document. 
        1: "https://www.blockaway.net",
        2: "https://www.croxyproxy.com",
        3: "https://www.croxyproxy.rocks",
        4: "https://www.croxy.network",
        5: "https://www.croxy.org",
        6: "https://www.youtubeunblocked.live",
        7: "https://www.croxyproxy.net
        8. https://cdn.youtubeunblocked.live/
        9. https://croxyproxy.best/ //this one is SAME SAME BUT DIFFERENT Not used yet

       

         DIFFERENT UI Interface List
          1. https://croxyproxy.best/ 
          2. https://www.proxysite.com/
          3. https://proxyium.com/
          4. https://proxysite.pro/
          5. https://www.my-proxy.com/
          6. https://unblockvideos.com/
          7. https://www.proxysite.com/
          9. http://kproxy.com/
         10. https://www.4everproxy.com/
         11. https://www.genmirror.com/
         12. https://freeproxy.me/
         13. https://proxy.vpn.asia/


          could be useful these are all the same
          1. https://unblockproxy.win/
          2. https://freeproxy.win/    
          3. https://unblock-websites.com/
          4. https://proxysite.one/
          5. https://unblockyoutube.video/
          6. https://proxy-youtube.com/


         popular ones that I dont care for
        1. https://www.hide-my-ip.net/proxy-site.html
        2. https://hidefrom.com/

         web proxy site lists websites
        1. https://proxy-site.net/
        2. https://free-proxy-list.net/web-proxy.html
        **/




using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RaccoonFacts_Easy_Twitch_View_Bot
{
    public partial class Form1 : Form
    {
        private static readonly Random rand = new Random();
        private CancellationTokenSource cts;
        private List<IWebDriver> drivers = new List<IWebDriver>();
        private readonly string[] proxySites = {
            "https://www.blockaway.net",
            "https://www.croxyproxy.com",
            "https://www.croxyproxy.rocks",
            "https://www.croxy.network",
            "https://www.croxy.org",
            "https://www.youtubeunblocked.live",
            "https://www.croxyproxy.net",
            "https://cdn.youtubeunblocked.live/",

        };






        public Form1()
        {
            InitializeComponent();
            LoadSettings(); // Load last used values
            mainBar.Minimum = 0;
            mainBar.Maximum = 100;
            mainBar.Value = 0;  

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            LogTxtBx.AppendText("Start button clicked\r\n");
            SaveSettings();
            Task.Run(() => StartBotSwarm());
        }
 

        private void LoadSettings()
        {
            // Load from Properties.Settings (add these in Project > Properties > Settings)
            usernameTxtBx.Text = Properties.Settings.Default.LastUsername;
            botCountNUD.Value = Properties.Settings.Default.LastBotCount > 0 ? Properties.Settings.Default.LastBotCount : 1;
            IntervalNUD.Value = Properties.Settings.Default.LastInterval > 0 ? Properties.Settings.Default.LastInterval : 5; // Default 5min
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LogTxtBx.Text = "Ready to start View Botter...\r\n";
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.LastUsername = usernameTxtBx.Text;
            Properties.Settings.Default.LastBotCount = (int)botCountNUD.Value;
            Properties.Settings.Default.LastInterval = (int)IntervalNUD.Value;
            Properties.Settings.Default.Save();
        }

        private string GetRandomProxySite()
        {
            return proxySites[rand.Next(proxySites.Length)];
        }
        private ChromeDriver CreateHeadlessDriver()
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                var services = ChromeDriverService.CreateDefaultService();



                options.AddArgument("--headless"); // Re-enable for no UI
                options.AddArgument("--disable-gpu");
             
                options.AddArgument("--no-sandbox");
                options.AddArgument("--autoplay-policy=no-user-gesture-required");
                options.AddArgument("--enable-unsafe-swiftshader");
                options.AddArgument("--disable-dev-shm-usage");

                 
                

                //Experimental trying to stop ads without downloading .crx files
                options.AddArgument("--enable-features=NetworkService,NetworkServiceInProcess");
                options.AddArgument("--disable-features=RendererCodeIntegrity");
                options.AddArgument("--block-new-web-contents"); // This helps block some ads

                //hide CMD window
                services.HideCommandPromptWindow = true;


                // Set low resource usage
                options.AddArgument("--blink-settings=imagesEnabled=false"); // Disable images to save CPU
                options.AddArgument("--disable-extensions"); // Disable extensions
                options.AddArgument("--disable-sync"); // Disable sync overhead

                // Disable some features to save CPU
                options.AddArgument("--disable-renderer-backgrounding");
                options.AddArgument("--disable-background-timer-throttling");
                options.AddArgument("--disable-accelerated-video-decode");

                //Could not get it to count as views when these were not disabled, so I guess leave it on

                // options.AddArgument("--disable-gpu-sandbox");
                //  options.AddArgument("--mute-audio");

                options.AddArgument($"--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/{rand.Next(90, 120)}.0.0.0 Safari/537.36");
                var driver = new ChromeDriver(services , options);
                LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText("ChromeDriver initialized successfully\r\n")));
                return driver;
            }
            catch (Exception ex)
            {
                LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Failed to initialize ChromeDriver: {ex.Message}\r\n")));
                throw;
            }
        }


        private async Task WatchStream(string channel, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
              
                string proxySite = GetRandomProxySite();
                ChromeDriver driver = null;
                try
                {
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Starting bot for {proxySite}...\r\n")));
                    driver = CreateHeadlessDriver();
                    lock (drivers) { drivers.Add(driver); }
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Opening {proxySite} for {channel}\r\n")));

                    driver.Navigate().GoToUrl(proxySite);
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Navigated to {proxySite}\r\n")));

                    await Task.Delay(3000, token); // 3s for proxy load
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Proxy site {proxySite} settled\r\n")));

                    IWebElement urlInput = driver.FindElement(By.Id("url"));
                    IWebElement goButton = driver.FindElement(By.Id("requestSubmit"));
                    string twitchUrl = $"https://www.twitch.tv/{channel}";
                    urlInput.SendKeys(twitchUrl);
                    goButton.Click();
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Submitted {twitchUrl} on {proxySite}\r\n")));

                    bool settingsFound = false;
                    for (int attempt = 1; attempt <= 5; attempt++)
                    {
                        if (token.IsCancellationRequested) break; // Check cancellation each loop
                        try
                        {
                            driver.FindElement(By.XPath("//*[@id='channel-player']/div/div[2]/div[1]/div[2]/div/button"));
                            settingsFound = true;
                            LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Settings button found on attempt {attempt} in {proxySite}\r\n")));
                            break;
                        }
                        catch (NoSuchElementException)
                        {
                            LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Attempt {attempt}: Settings button not found yet in {proxySite}, waiting 5s\r\n")));
                            await Task.Delay(5000, token); // 5s delay, respects cancellation
                        }
                    }

                    if (!settingsFound)
                    {
                        LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Failed to find settings button after 5 attempts in {proxySite}\r\n")));
                        
                    }
 


                    //mutes video but without having to worry about twitch figuring it out
                        driver.ExecuteScript(@"
                var video = document.querySelector('video');
                if (video) {
                    video.muted = true;
                }
            ");
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Successfully Muted video on {proxySite}\r\n")));
                    driver.ExecuteScript(@"
                var player = document.querySelector('.video-player');
                if (player) {
                    var settingsButton = document.querySelector('button[data-a-target=""player-settings-button""]');
                    if (settingsButton) {
                        settingsButton.click();
                        setTimeout(function() {
                            var qualityMenu = document.querySelector('button[data-a-target=""player-settings-menu-item-quality""]');
                            if (qualityMenu) {
                                qualityMenu.click();
                                setTimeout(function() {
                                    var qualityOptions = document.querySelectorAll('input[data-a-target=""tw-radio""]');
                                    if (qualityOptions.length > 0) {
                                        var lowestQuality = qualityOptions[qualityOptions.length - 1];
                                        lowestQuality.click();
                                    }
                                }, 1000);
                            }
                        }, 1000);
                    }
                }
            ");
                    await Task.Delay(3000, token);
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Set video quality to lowest (160p) on {proxySite}\r\n")));

                    int intervalMinutes = (int)IntervalNUD.Value;
                    int intervalMs = intervalMinutes * 60000;

                    // Maybe this should be different
                    int randomOffset = rand.Next(-30000, 70000);
                    int totalInterval = Math.Max(60000, intervalMs + randomOffset);
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Watching for {totalInterval / 60000}min ({totalInterval / 1000}s) via {proxySite}\r\n")));
                    await Task.Delay(totalInterval, token); // Long delay, respects cancellation

                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Closing tab for {proxySite}\r\n")));
                    driver.Quit();
                    lock (drivers) { drivers.Remove(driver); }
                    driver = null;
                }
                catch (TaskCanceledException)
                {
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Bot stopped for {proxySite} - user cancelled\r\n")));
                    break;
                }
                catch (NoSuchElementException ex)
                {
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Bot failed on {proxySite}: Element not found - {ex.Message}\r\n")));
                }
                catch (Exception ex)
                {
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Bot failed on {proxySite}: {ex.Message}\r\n")));
                }
                finally
                {
                    if (driver != null)
                    {
                        driver.Quit();
                        lock (drivers) { drivers.Remove(driver); }
                    }
                }
            }
        }

        private async Task StartBotSwarm()
        {
            if (string.IsNullOrWhiteSpace(usernameTxtBx.Text))
            {
                LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText("Enter a channel name first!\r\n")));
                return;
            }

            string targetChannel = usernameTxtBx.Text.Trim();
            int botCount = (int)botCountNUD.Value;

            cts = new CancellationTokenSource();
            List<Task> botTasks = new List<Task>();

            LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Starting {botCount} bots for {targetChannel}...\r\n")));
            startBtn.Invoke(new Action(() => startBtn.Enabled = false));
            stopBtn.Invoke(new Action(() => stopBtn.Enabled = true));

            mainBar.Invoke(new Action(() =>
            {
                mainBar.Maximum = botCount;
                mainBar.Value = 0;
                mainBar.Style = ProgressBarStyle.Continuous; // Ensure it's not Marquee
            }));

            try
            {
                for (int i = 0; i < botCount; i++)
                {
                    if (cts.IsCancellationRequested) break;
                    LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"Launching bot {i + 1} of {botCount}\r\n")));
                    botTasks.Add(Task.Run(() => WatchStream(targetChannel, cts.Token)));



                    // Update progress bar
                    mainBar.Invoke(new Action(() =>
                    {
                        mainBar.Value = i + 1; // Increment as each bot starts
                        mainBar.Refresh();     // Force UI update
                    }));


                    if (staggerChkBx.Checked)
                    {
                        await Task.Delay(rand.Next(10000, 60000), cts.Token);
                    }
                    else
                    {
                        await Task.Delay(rand.Next(2000, 5000), cts.Token);
                    }
                        
                }

                await Task.WhenAll(botTasks);
                LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText("View Botting Complete. Good Bye.\r\n")));
                mainBar.Invoke(new Action(() => mainBar.Value = 0));
            }
            catch (TaskCanceledException)
            {
                LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText("View Bot stopped by user.\r\n")));
                mainBar.Invoke(new Action(() => mainBar.Value = 0));
            }
            catch (Exception ex)
            {
                LogTxtBx.Invoke(new Action(() => LogTxtBx.AppendText($"View Bot failed: {ex.Message}\r\n")));
                mainBar.Invoke(new Action(() => mainBar.Value = 0));
            }
            finally
            {
                startBtn.Invoke(new Action(() => startBtn.Enabled = true));
                mainBar.Invoke(new Action(() => mainBar.Value = 0));

                // stopBtn.Invoke(new Action(() => stopBtn.Enabled = false)); // In a perfect world, this would not be commented out
            }
        }



        private void stopBtn_Click(object sender, EventArgs e)
        {
            mainBar.Invoke(new Action(() => mainBar.Value = 0));
            LogTxtBx.AppendText("Stop Button has been pressed\r\n");

            // Cancel all tasks
            if (cts != null && !cts.IsCancellationRequested)
            {
                LogTxtBx.AppendText("Signaling cancellation...\r\n");
                cts.Cancel();
                cts.Dispose();
                cts = null;
            }

            // Close and dispose managed drivers
            LogTxtBx.AppendText("Stopping all managed drivers...\r\n");
            lock (drivers)
            {
                foreach (var driver in drivers.ToList())
                {
                    try
                    {
                        if(staggerChkBx.Checked)
                        {
                            Thread.Sleep(rand.Next(1000, 10000));
                        }

                        driver.Close(); // Quit  does not work
                        driver.Dispose();
                        try
                        {
                            driver.Quit();
                        }
                        catch
                        {
                            LogTxtBx.AppendText($"Close & Dispose worked, but Quit failed for managed driver {driver}\r\n");
                            LogTxtBx.AppendText($"It probably still closed though\r\n");
                        }
                         
                        LogTxtBx.AppendText($"Closed managed driver {driver}\r\n");
                    }
                    catch (Exception ex)
                    {
                        driver.Quit();
                        LogTxtBx.AppendText($"Failed to close managed driver: {ex.Message}\r\n");
                    }
                }
                drivers.Clear();
                LogTxtBx.AppendText("All managed drivers cleared\r\n");
            }

            // Kill all chromedriver.exe processes system-wide
            LogTxtBx.AppendText("Killing all ChromeDriver processes...\r\n");
            try
            {
                foreach (var process in Process.GetProcessesByName("chromedriver"))
                {
                    try
                    {
                        process.Kill();
                        process.WaitForExit(2000); // Wait up to 2s for clean exit
                        LogTxtBx.AppendText($"Killed ChromeDriver process {process.Id}\r\n");
                    }
                    catch (Exception ex)
                    {
                        LogTxtBx.AppendText($"Failed to kill ChromeDriver process {process.Id}: {ex.Message}\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                LogTxtBx.AppendText($"Error during process cleanup: {ex.Message}\r\n");
            }

            LogTxtBx.AppendText("Full stop complete\r\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopBtn_Click(sender, e); // Clean up on close
            SaveSettings();
        }

        private void extraFrmBtn_Click(object sender, EventArgs e)
        {
            extraForm extraForm = new extraForm();
            extraForm.Show();
        }
    }
}
