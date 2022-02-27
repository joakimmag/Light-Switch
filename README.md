# Light Switch

<img src="Readme/Logo.png" width="120" height="120">

## Description

Easily switch from light to dark theme, or the other way around, in Windows 10 and Windows 11.

This application displays an icon in your system tray. Just click the icon to change Windows theme.

### How it works

It updates the values `AppsUseLightTheme` and `SystemUsesLightTheme` under the registry key `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize`. Your Windows updates the same registry values when you change color settings under Settings > Personalization.

## Download

Go to the [Releases](https://github.com/wireless-r/Light-Switch/releases) page to download the installer.

## How to use

Click the icon once to switch from light to dark, or from dark to light.

![Screenshot](Readme/Screen.gif)

Right-click the icon to open the menu.

![Screenshot](Readme/Context-Menu.png)

Set your preferences.

![Screenshot](Readme/Preferences.png)

## Release notes

- Version 2.2:
  - New icon and new logo.
  - Some of your Preferences may become reset if you choose to install this version.
