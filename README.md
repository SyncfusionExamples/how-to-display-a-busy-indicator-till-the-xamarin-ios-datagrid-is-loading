# how-to-display-a-busy-indicator-till-the-xamarin-ios-datagrid-is-loading

This app implements to load an animation in the meantime the SfDataGrid is loading using an SfBusyIndicator in the SfDataGrid.GridLoaded event. SfDataGrid takes some time for its initial loading of data and it largely depends on the type and size of the bound data. 

## Syncfusion Controls

This project uses the following Syncfusion controls:

* [SfDataGrid](https://www.syncfusion.com/xamarin-ui-controls/datagrid)

* [SfBusyIndicator](https://www.syncfusion.com/xamarin-ui-controls/xamarin-busy-indicator)

## Screenshots

![Loading animation while loading SfDataGrid](SampleApp\SampleApp\Screenshots\SfDataGrid.png)


## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| iOS | iOS 9.0 and later versions |

Refer to the following link for more details: 
[System Requirements](https://help.syncfusion.com/xamarin/installation-and-upgrade/system-requirements)

## Requirements to run the sample

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available in Visual Studio installer)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register the license key in FinishedLaunching override method of AppDelegate.cs.    
      
       public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)   
       {                                         

      	//Register Syncfusion license
      	Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
      
      	// create a new window instance based on the screen size
      	Window = new UIWindow(UIScreen.MainScreen.Bounds);
      
        // If you have defined a root view controller, set it here:
      	// Window.RootViewController = myViewController;
      
      	// make the window visible
      	Window.MakeKeyAndVisible();
      
      	return true;          
       }

Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#xamarinios) for more details.

3. Clean and build the application.
4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
