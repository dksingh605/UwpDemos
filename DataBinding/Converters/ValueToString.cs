using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace DataBinding.Converters
{
public	class ValueToString:IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			return value??"";
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return "error";
		}
	}
}
