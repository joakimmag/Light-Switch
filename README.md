# Light Switch

<img src="Readme/Logo.png" width="120" height="120">

## Description

Easily switch from light to dark theme, or the other way around, in Windows 10 and Windows 11.

This application displays an icon in your system tray. Just click the icon to change Windows theme.

## Download

Go to the [Releases](https://github.com/wireless-r/Light-Switch/releases) page to download the installer.

## How to use

Click the icon once to switch from light to dark, or from dark to light.

![Screenshot](Readme/Screen.gif)

Right-click the icon to open the menu.

![Screenshot](Readme/Context-Menu.png)

Set your preferences.

![Screenshot](Readme/Preferences.png)

## How it works

It updates the `AppsUseLightTheme` and `SystemUsesLightTheme` values under the `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize` registry key, which are the same values which are changed by Windows when you change color settings under Settings > Personalization.

## Release notes

- Version 2.2:
  - New icon and new logo.
  - Some of your Preferences may become reset if you choose to install this version.
