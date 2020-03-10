using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace SakuraStyle.Converter.BooleanConverter
{
    public class BooleanConverter<T> : IValueConverter
    {
        protected BooleanConverter(T tValue, T fValue)
        {
            True = tValue;
            False = fValue;
        }

        public T True { get; set; }

        public T False { get; set; }


        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool flag && flag ? True : False;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is T flag && EqualityComparer<T>.Default.Equals(flag, True);
        }
    }
}
