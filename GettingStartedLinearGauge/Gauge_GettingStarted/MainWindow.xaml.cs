using System.Windows;
using System.Windows.Media;
using Syncfusion.UI.Xaml.Gauges;

namespace Gauge_GettingStarted
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //SfLinearGauge sfLinearGauge = new SfLinearGauge();
            //LinearScale linearScale = new LinearScale();
            //linearScale.LabelStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#424242");
            //linearScale.MajorTickStroke = new SolidColorBrush(Colors.Gray);
            //linearScale.MajorTickSize = 15;
            //linearScale.MajorTickStrokeThickness = 1;
            //linearScale.MinorTickStroke = new SolidColorBrush(Colors.Gray);
            //linearScale.MinorTickSize = 7;
            //linearScale.MinorTickStrokeThickness = 1;
            //linearScale.MinorTicksPerInterval = 3;
            //linearScale.ScaleBarStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#E0E0E0");
            //linearScale.ScaleBarLength = 300;
            //linearScale.ScaleBarSize = 10;

            ////Adding symbol pointer
            //LinearPointer linearPointer = new LinearPointer();
            //linearPointer.PointerType = LinearPointerType.SymbolPointer;
            //linearPointer.Value = 60;
            //linearPointer.SymbolPointerHeight = 10;
            //linearPointer.SymbolPointerWidth = 10;
            //linearPointer.SymbolPointerPosition = LinearSymbolPointersPosition.Below;
            //linearPointer.SymbolPointerStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#757575");
            //linearScale.Pointers.Add(linearPointer);

            //////Adding bar pointer
            //LinearPointer linearPointer1 = new LinearPointer();
            //linearPointer1.PointerType = LinearPointerType.BarPointer;
            //linearPointer1.Value = 50;
            //linearPointer1.BarPointerStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#757575");
            //linearPointer1.BarPointerStrokeThickness = 10;
            //linearScale.Pointers.Add(linearPointer1);

            ////Adding Range
            //LinearRange linearRange = new LinearRange();
            //linearRange.StartValue = 0;
            //linearRange.EndValue = 40;
            //linearRange.RangeStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#27BEB7");
            //linearRange.StartWidth = 10;
            //linearRange.EndWidth = 10;
            //linearRange.RangeOffset = 0.4;
            //linearScale.Ranges.Add(linearRange);

            //LinearRange linearRange1 = new LinearRange();
            //linearRange1.StartValue = 40;
            //linearRange1.EndValue = 100;
            //linearRange1.RangeStroke = new SolidColorBrush(Colors.LightCyan);
            //linearRange1.RangeOffset = 0.4;
            //linearRange1.StartWidth = 10;
            //linearRange1.EndWidth = 10;
            //linearScale.Ranges.Add(linearRange1);
            //sfLinearGauge.MainScale = linearScale;
            //this.Content = sfLinearGauge;
        }
    }
}