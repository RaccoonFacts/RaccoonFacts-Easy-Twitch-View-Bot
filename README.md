
# RaccoonFacts Easy Twitch View Bot

## Overview
RaccoonFacts Easy Twitch View Bot is a Windows Forms application designed to automate the process of generating Twitch viewership using Selenium WebDriver and external proxy sites. The bot launches multiple headless Chrome instances, each navigating through a randomly selected proxy site to view a specified Twitch channel, simulating real viewership. The application is built for ease of use with a simple GUI, allowing users to configure the target channel, number of bots, and viewing intervals.

**Note:** This project is for educational purposes only. Using view bots violates Twitch's Terms of Service and may result in account bans. Use responsibly and at your own risk.

## Features
- **Automated Viewership**: Launches multiple bots to view a specified Twitch channel via external proxy sites.
- **Headless Chrome**: Uses Selenium WebDriver with headless Chrome for efficient, UI-less operation.
- **Proxy Support**: Integrates a list of external proxy sites (e.g., blockaway.net, croxyproxy.com) to route traffic and simulate unique viewers.
- **Configurable Settings**:
  - Specify the target Twitch channel.
  - Set the number of simultaneous bots (viewers).
  - Adjust the viewing interval with randomization to mimic natural behavior.
  - Optional staggered bot launches to avoid detection.
- **Performance Optimization**:
  - Disables images, extensions, and GPU usage to reduce CPU and memory load.
  - Automatically mutes streams and sets video quality to the lowest (160p) to minimize bandwidth.
- **User Interface**:
  - Windows Forms GUI with a progress bar, logging window, and settings persistence.
  - "Spoof" mode to disguise the application window as a calculator.
  - Additional form for extended functionality (customizable via `extraForm`).
- **Robust Cleanup**: Stops all bots, closes ChromeDriver instances, and terminates stray processes on application close or manual stop.
- **Error Handling**: Gracefully handles proxy failures, element not found errors, and cancellations with detailed logging.

## Requirements
- **.NET Framework**: Compatible with .NET Framework (tested on 4.x).
- **Selenium WebDriver**: Requires `Selenium.WebDriver` and `Selenium.WebDriver.ChromeDriver` NuGet packages.
- **Chrome Browser**: A compatible version of Google Chrome must be installed.
- **Windows OS**: Designed for Windows due to Windows Forms dependency.

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/RaccoonFacts-Easy-Twitch-View-Bot.git
   ```
2. Open the solution in Visual Studio.
3. Install required NuGet packages:
   - `Selenium.WebDriver`
   - `Selenium.WebDriver.ChromeDriver`
4. Ensure Google Chrome is installed and the ChromeDriver version matches your Chrome browser version.
5. Build and run the project.

## Usage
1. Launch the application.
2. Enter the target Twitch channel name in the username field.
3. Set the desired number of bots (viewers) and viewing interval (in minutes).
4. (Optional) Enable staggered launches for randomized bot startup delays.
5. (Optional) Enable spoof mode to disguise the application window.
6. Click **Start** to begin the bot swarm.
7. Monitor progress via the progress bar and log window.
8. Click **Stop** to halt all bots and clean up processes.
9. Use the **Extra Form** button for additional features (if implemented).

## Proxy Sites
The bot uses a predefined list of external proxy sites to route traffic, including:
- https://www.blockaway.net
- https://www.croxyproxy.com
- https://www.youtubeunblocked.live
- And more (see source code for the full list)

Additional proxy lists are included in the code comments for future expansion, with suggestions for storing them in a JSON or text file.

## Limitations
- **Proxy Reliability**: External proxy sites may be slow, unavailable, or blocked, affecting bot performance.
- **Twitch Detection**: Twitch may detect and flag automated viewership, risking bans.
- **Resource Usage**: Running multiple ChromeDriver instances can be resource-intensive, though optimizations are in place.
- **Platform-Specific**: Currently limited to Windows due to Windows Forms.

## Future Improvements
- Store proxy lists in an external JSON or text file for easier updates.
- Implement advanced anti-detection techniques (e.g., randomized user agents)
- Extend the `extraForm` for additional configuration options.
- Add multi-platform support by migrating to a cross-platform UI framework.

## Disclaimer
This project is intended for educational and research purposes only. Automating viewership on Twitch violates their Terms of Service and Community Guidelines. The developer is not responsible for any consequences, including account suspensions or bans, resulting from the use of this tool. Use at your own risk.

## License
[MIT License](LICENSE) - Feel free to modify and distribute, but please adhere to ethical usage guidelines. Not responsible for you getting banned. 

## Contributing
Contributions are welcome! Please submit issues or pull requests for bug fixes, optimizations, or new features. Ensure all changes align with the project's educational purpose and include clear documentation.
