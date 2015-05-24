using System;
using System.Globalization;
using System.Windows.Data;
using Data;

namespace GUI.ViewModels
{
    [ValueConversion(typeof(Condition), typeof(char))]
    public class ConverterConditionToChar : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var res = ' ';
            switch ((Condition)value)
            {
                case Condition.FREE:
                    res = ' ';
                    break;
                case Condition.CROSS:
                    res = 'x';
                    break;
                case Condition.ZERO:
                    res = 'o';
                    break;
            }
            return res;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Condition res = Condition.FREE;
            switch ((char)value)
            {
                case ' ':
                    res = Condition.FREE;
                    break;
                case 'x':
                    res = Condition.CROSS;
                    break;
                case 'o':
                    res = Condition.ZERO;
                    break;
            }
            return res;
        }
    }
}