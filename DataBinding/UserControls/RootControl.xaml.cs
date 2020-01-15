using DataBinding.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace DataBinding.UserControls
{
	public sealed partial class RootControl : UserControl
	{
		public RootControl()
		{
			this.InitializeComponent();
		}		

		public double Radius
		{
			get { return (double)GetValue(RadiusProperty); }
			set { SetValue(RadiusProperty, value); }
		}
		public static readonly DependencyProperty RadiusProperty =
			DependencyProperty.Register("Radius", typeof(double), typeof(RootControl), new PropertyMetadata((double)new ChildViewModel().SliderValue));

		private void WPath_KeyDown(object sender, KeyRoutedEventArgs e)
		{

		}

		private void WPath_PointerPressed(object sender, PointerRoutedEventArgs e)
		{

		}

		private void WPath_PointerMoved(object sender, PointerRoutedEventArgs e)
		{

		}

		private void WPath_PointerReleased(object sender, PointerRoutedEventArgs e)
		{
			//var x = sender as Path;
			
		}
	}
}
