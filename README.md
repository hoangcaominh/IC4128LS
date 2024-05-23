# IC4128LS - ISCORE Calculator for 12.8 Lunatic Survival

This is a program designed specifically for GFW Lunatic Survival match from Touhou World Cup, to help staffs and viewers have easier time tracking the participant's progress.

This program requires the user to have th128.exe v1.00a unmodified (SHA256 hash: `ba515750ece845b56640fe440592fc39ebb7bdd1ed87c541b67a19b148e767d4`). Thcrap, thprac or vpatch does not affect the program's performance. It can also run without internet connection.
Once IC4128LS finds th128.exe it will start reading the game's memory and display information on the user interface.
This program displays the game difficulty, route, miss count, bomb count, gold medal count, silver medal count, bronze medal count and renews the data when a new run is started.

## Installation
Go to the [release](https://github.com/hoangcaominh/IC4128LS/releases) page and download the zip file of the latest version. Once the download is finished, extract the zip file into a folder and run IC4128LS.exe

## How to use
When starting IC4128LS for the first time, you will be asked to select one of these languages: English, Japanese or Simplified Chinese.
After starting th128.exe, hit "Find th128.exe" button. If successful, the main panel will display the information mentioned above.
This program only tracks after it found th128.exe and all progress before it reads the game's memory will not be recorded. It is highly recommended the user start the program at the menu screen of the game.
To stop the program from tracking the game, close and reopen the game or IC4128LS.

## Dependencies
[.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer) or above

## Known issues
- Sometimes the program will not read the game's memory when the game is in fullscreen mode. This is an unknown problem that comes from the Windows operating system. To fix the problem, try alt-tabbing the game or closing and reopening the program. Especially for participants, please ALWAYS make sure the program is running before starting a new run.
