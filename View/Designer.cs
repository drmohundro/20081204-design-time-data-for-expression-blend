using System.ComponentModel;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Allows the use of design-time only data binding... seems to only work
    /// in Blend and not the VS designer...
    /// </summary>
    public class Designer
    {
        public static readonly DependencyProperty DataContextProperty =
            DependencyProperty.RegisterAttached("DataContext", typeof (object), typeof (Designer),
                                                new PropertyMetadata(OnDataContextChanged));

        private static void OnDataContextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SetDataContext(d, e.NewValue);
        }

        public static void SetDataContext(DependencyObject d, object value)
        {
            var element = d as FrameworkElement;
            if (element == null) return;

            if (DesignerProperties.GetIsInDesignMode(element))
                element.DataContext = value;
        }
    }
}