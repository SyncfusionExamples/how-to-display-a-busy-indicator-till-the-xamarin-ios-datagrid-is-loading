using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Syncfusion.SfDataGrid;
using Syncfusion.SfBusyIndicator.iOS;
using System.Threading.Tasks;
using Foundation;

namespace SampleApp
{
    class MyViewController : UIViewController
    {
        SfDataGrid dataGrid;
        SFBusyIndicator busyIndicator;
        ViewModel viewModel;
        public MyViewController()
        {          
            dataGrid = new SfDataGrid();
            busyIndicator = new SFBusyIndicator();
            viewModel = new ViewModel();
            dataGrid.ItemsSource = viewModel.Collection;
            dataGrid.ColumnSizer = ColumnSizer.Star;
            dataGrid.GridLoaded += DataGrid_GridLoaded;
            View.AddSubview(dataGrid);
        }
       
        private async void DataGrid_GridLoaded(object sender, GridLoadedEventArgs e)
        {
            busyIndicator.IsBusy = true;
            busyIndicator.AnimationType = SFBusyIndicatorAnimationType.SFBusyIndicatorAnimationTypeDoubleCircle;
            busyIndicator.ViewBoxHeight = 100;
            busyIndicator.ViewBoxWidth = 100;
            busyIndicator.Title =(NSString) "Loading...";          
            View.AddSubview(busyIndicator);
            await Task.Delay(5000);
            busyIndicator.IsBusy = false;
            busyIndicator.Hidden = true;
            busyIndicator.UserInteractionEnabled = false;
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            dataGrid.Frame = new CoreGraphics.CGRect(0,0,this.View.Frame.Width,this.View.Frame.Height);
            busyIndicator.Frame = new CoreGraphics.CGRect(0, 0, this.View.Frame.Width, this.View.Frame.Height);
        }
    }
}