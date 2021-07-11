# Cross-Platform Embedded Images (CPEI)

## Objective
This is a demo showing the use of Embedded Images so that images can be shared across multiple platforms, i.e. iOS, Android, and UWP with Xamarin.Forms.

<div align="center">
    <img src="https://gclstorage.blob.core.windows.net/images/cpei.gif" />
</div>

## Technical Specification
Framework: Xamarin.Form 5.0, .NET Standard 2.0\
Windows 10 SDK: Version 2004 (10.0.19041.0), the minimum target must be 10.0.16299 or higher\
Android SDK: 30, the minimum target must be 21 or higher\
iOS Deployment Target: 14.5

## How to Run?
### Windows 10
1. Launch this solution in Visual Studio 2019 (16.9.4 and above);
2. Set `CPEI.UWP` as the Startup Project;
3. Launch it in the Debug mode.

### Android Emulator
1. Launch this solution in Visual Studio 2019 (16.9.4 and above);
2. Set `CPEI.Android` as the Startup Project;
3. Launch it in the Debug mode on the suitable Android emulator, eg. Android 9.0 - API 28.

### iOS Simulator
1. Launch this solution in Visual Studio 2019 for Mac;
2. Set `CPEI.iOS` as the Startup Project;
3. Launch it in the Debug mode on the suitable iOS simulator.