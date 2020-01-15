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
	public sealed partial class RootControl : UserControl, INotifyPropertyChanged
	{
		public RootControl()
		{
			this.InitializeComponent();
		}
		private double _btnWidth = 50;

		public double Radius
		{
			get { return _btnWidth; }

			set
			{
				_btnWidth = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Radius"));
				}
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
