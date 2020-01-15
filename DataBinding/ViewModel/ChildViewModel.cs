using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace DataBinding.ViewModel
{
	public class ChildViewModel:ViewModelBase
	{
		private int _sliderValue = 25;
		public int EllipseDimention
		{
			get
			{
				return _sliderValue;
			}
			set
			{
				Set(ref _sliderValue, value, "SliderValue");
			}
		}
	
		public int SliderValue
		{
			get
			{
				return _sliderValue;
			}
			set
			{
				Set(ref _sliderValue, value, "EllipseDimention");			

			}
		}
	}
}
