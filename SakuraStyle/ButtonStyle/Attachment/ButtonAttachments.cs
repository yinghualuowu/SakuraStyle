using System.Windows;
using System.Windows.Media;

namespace SakuraStyle.ButtonStyle.Attachment
{
    public class ButtonAttachments
    {
        public static readonly DependencyProperty NormalImageProperty = DependencyProperty.RegisterAttached(
           "NormalImage",
           typeof(ImageSource),
           typeof(ButtonAttachments),
           new PropertyMetadata(null));

        public static ImageSource GetNormalImage(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(NormalImageProperty);
        }

        public static void SetNormalImage(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(NormalImageProperty, value);
        }

        public static readonly DependencyProperty PressedImageProperty = DependencyProperty.RegisterAttached(
            "PressedImage",
            typeof(ImageSource),
            typeof(ButtonAttachments),
            new PropertyMetadata(null));

        public static ImageSource GetPressedImage(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(PressedImageProperty);
        }

        public static void SetPressedImage(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(PressedImageProperty, value);
        }

        public static readonly DependencyProperty ImageWidthProperty = DependencyProperty.RegisterAttached(
            "ImageWidth",
            typeof(double),
            typeof(ButtonAttachments),
            new PropertyMetadata(default(double)));

        public static void SetImageWidth(DependencyObject element, double value)
        {
            element.SetValue(ImageWidthProperty, value);
        }

        public static double GetImageWidth(DependencyObject element)
        {
            return (double)element.GetValue(ImageWidthProperty);
        }


        public static readonly DependencyProperty ImageHeightProperty = DependencyProperty.RegisterAttached(
            "ImageHeight",
            typeof(double),
            typeof(ButtonAttachments),
            new PropertyMetadata(default(double)));

        public static void SetImageHeight(DependencyObject element, double value)
        {
            element.SetValue(ImageHeightProperty, value);
        }

        public static double GetImageHeight(DependencyObject element)
        {
            return (double)element.GetValue(ImageHeightProperty);
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(ButtonAttachments),
            new PropertyMetadata(default(CornerRadius)));

        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ImagePositionProperty = DependencyProperty.RegisterAttached(
            "ImagePosition",
            typeof(PositionEnumType),
            typeof(ButtonAttachments),
            new PropertyMetadata(PositionEnumType.Right));

        public static void SetImagePosition(DependencyObject element, PositionEnumType value)
        {
            element.SetValue(ImagePositionProperty, value);
        }

        public static PositionEnumType GetImagePosition(DependencyObject element)
        {
            return (PositionEnumType)element.GetValue(ImagePositionProperty);
        }

        public static readonly DependencyProperty ContentMarginProperty = DependencyProperty.RegisterAttached(
            "ContentMargin",
            typeof(Thickness),
            typeof(ButtonAttachments),
            new PropertyMetadata(default(Thickness)));

        public static void SetContentMargin(DependencyObject element, object value)
        {
            element.SetValue(ContentMarginProperty, value);
        }

        public static Thickness GetContentMargin(DependencyObject element)
        {
            return (Thickness)element.GetValue(ContentMarginProperty);
        }
    }
}
