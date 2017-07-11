using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using exemples.Models;
using exemples.Properties;

namespace exemples.Converters
{
    public class SimpleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (null == value)
            {
                return "";
            }
            if (value is string)
            {
                if ((string)value == Nombres.un.ToString())
                {
                    return 1;
                }
                if ((string)value == Nombres.deux.ToString())
                {
                    return 2;
                }
                if ((string)value == Nombres.trois.ToString())
                {
                    return 3;
                }
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter,
                              CultureInfo culture)
        {
            if (null == value)
            {
                return Visibility.Collapsed;
            }
            if (value.Count() == 2 && null != value[0] && null != value[1])
            {
                if (value[1] is string)
                {
                    if ("Visible" == value[1].ToString() )
                    {
                        if (value[0] is string)
                        {
                            if ((string)value[0] == Nombres.un.ToString())
                            {
                                return Visibility.Visible;
                            }
                            if ((string)value[0] == Nombres.deux.ToString())
                            {
                                return Visibility.Collapsed;
                            }
                            if ((string)value[0] == Nombres.trois.ToString())
                            {
                                return Visibility.Visible;
                            }
                        }
                    }
                }
            }
            return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
