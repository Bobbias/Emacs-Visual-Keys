using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace EmacsVisualKeys
{
    /// <summary>
    /// Interaction logic for KeyboardKeyControl.xaml
    /// </summary>
    [ContentProperty("AdditionalContent")]
    public partial class KeyboardKeyControl : UserControl
    {
        public KeyboardKeyControl()
        {
            InitializeComponent();
        }

        static KeyboardKeyControl()
        {
            AdditionalContentProperty =
DependencyProperty.Register("AdditionalContent", typeof(object), typeof(KeyboardKeyControl),
new PropertyMetadata(null));
        }

        /// <summary>
        /// Gets or sets additional content for the UserControl
        /// </summary>
        public object AdditionalContent
        {
            get { return GetValue(AdditionalContentProperty); }
            set { SetValue(AdditionalContentProperty, value); }
        }
        public static readonly DependencyProperty AdditionalContentProperty;
    }
}
