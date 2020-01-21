using Reactive.Bindings;
using System.Windows.Controls;

namespace WpfSamples.UserControlSample.App.Components
{
    /// <summary>
    /// Interaction logic for NumericCounter.xaml
    /// </summary>
    public partial class NumericCounter : UserControl
    {
        public NumericCounter()
        {
            InitializeComponent();
        }

        public ReactiveProperty<int> NumericText { get; set; } = new ReactiveProperty<int>(0);
    }
}
