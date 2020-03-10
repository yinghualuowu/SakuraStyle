using System.Windows.Data;

namespace SakuraStyle.Converter.BooleanConverter
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class BooleanToInverseConverter : BooleanConverter<bool>
    {
        public BooleanToInverseConverter() : base(true, false) { }
    }
}
