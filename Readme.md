# Starri Mod Plugin - OnlineMode

This is a MelonLoader Plugin that is required for using other mods for the Game Starri: https://store.steampowered.com/app/1940410/Starri/

This is required because MelonLoader blocks some essential web requests that are required for Starri to work.

# Disclaimer

- **This mod is not affiliated with the game Starri or its developers NEX Team. It is an unofficial mod!**
- This is not intended for cheating or any other malicious purposes. I felt in love with this game and wanted to add some features to it.
- This is experimental! I'm not a software developer. Most of this code is created by ChatGPT and hacked together by me, while trying to figure out how the toolchain works.
- This mod is provided as-is. Use at your own risk!

# Usage

## Preparation - Install MelonLoader

This mod requires MelonLoader to be installed.

### Install MelonLoader Requirements

See: https://melonwiki.xyz/#/?id=requirements

You'll need all three:

- .NET Framework 4.8 Runtime
- Microsoft Visual C++ 2015-2019
- dotnet 6.0

### Install MelonLoader

1. Install the latest version of MelonLoader. See: https://melonwiki.xyz/#/?id=automated-installation. When installed via Steam, Starri is usually located in `C:\Program Files (x86)\Steam\steamapps\common\Starri`.
2. Run the game once to generate the `MelonLoader` folder in the game's installation directory. (The game will start in offline mode. This is fine. Just exit the game normally.)

### Install the required MelonLoader Plugin

1. Download `OnlineMode.dll`
2. Copy `OnlineMode.dll` to the `Plugins` folder in the Starri installation directory: `C:\Program Files (x86)\Steam\steamapps\common\Starri\Plugins`

# Development

## Contributing

Feel free to contribute to this project. If you have any questions, feel free to open an issue.

## Environment Variable

You need to set an environment variable to the path of the Starri installation directory before building the project.:

````powershell
[System.Environment]::SetEnvironmentVariable('STARRI_NET6_DIRECTORY', 'C:\Program Files (x86)\Steam\steamapps\common\Starri', 'User')
````
