using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace LoginToSql.Test
{
    class BooleanToBrushConverter:IValueConverter
    {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                bool? input =(bool?) value;
                //double result;
                SolidColorBrush rojo = new SolidColorBrush(Colors.Red);
                SolidColorBrush verde = new SolidColorBrush(Colors.Green);

            if (input == true)
            {
                return verde;
            }
            else
            {
                return rojo;
            }
               
          
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotSupportedException();
            }
        
    }
}
