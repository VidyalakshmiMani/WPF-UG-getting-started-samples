using Syncfusion.UI.Xaml.Maps;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace GettingStarted
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //// Setting DataContext.
            //ViewModel viewModel = new ViewModel();
            //this.DataContext = viewModel;

            //// SfMap.
            //SfMap maps = new SfMap();

            //// ShapeFileLayer.
            //ShapeFileLayer shapeLayer = new ShapeFileLayer();
            //shapeLayer.Background = new SolidColorBrush(Colors.White);
            //shapeLayer.EnableSelection = true;
            //shapeLayer.Uri = "GettingStarted.ShapeFiles.usa_state.shp";
            //shapeLayer.ItemsSource = viewModel.ElectionResults;
            //shapeLayer.MapItemsVisibility = Visibility.Hidden;
            //shapeLayer.ShapeIDPath = "State";
            //shapeLayer.ShapeIDTableField = "STATE_NAME";
            //shapeLayer.Markers = viewModel.Models;
            //shapeLayer.MarkerIconFill = new SolidColorBrush(Colors.LimeGreen);
            //shapeLayer.MarkerLabelForeground = new SolidColorBrush(Colors.White);

            //// Adding legend
            //shapeLayer.LegendColumnSplit = 2;
            //shapeLayer.LegendPositionX = 950;
            //shapeLayer.LegendPositionY = 580;
            //shapeLayer.LegendVisibility = Visibility.Visible;
            //shapeLayer.LegendIcon = LegendIcons.Rectangle;

            //// ShapeSetting
            //ShapeSetting shapeSetting = new ShapeSetting();
            //shapeSetting.ShapeFill = (SolidColorBrush)new BrushConverter().ConvertFrom("#E5E5E5");
            //shapeSetting.ShapeStroke = new SolidColorBrush(Colors.White);
            //shapeSetting.ShapeStrokeThickness = 0.5;
            //shapeSetting.SelectedShapeColor = (SolidColorBrush)new BrushConverter().ConvertFrom("#CEBF93");
            //shapeSetting.ShapeValuePath = "Electors";
            //shapeSetting.ShapeColorValuePath = "Candidate";

            //// ShapeFillSetting
            //ShapeFillSetting shapeFillSetting = new ShapeFillSetting
            //{
            //    AutoFillColors = false
            //};

            //// EqualColorMapping
            //EqualsColorMapping romeyColorMapping = new EqualsColorMapping
            //{
            //    Color = (Color)new ColorConverter().ConvertFrom("#D84444"),
            //    LegendLabel = "Romney",
            //    Value = "Romney"
            //};

            //EqualsColorMapping obamaColorMapping = new EqualsColorMapping
            //{
            //    Color = (Color)new ColorConverter().ConvertFrom("#316DB5"),
            //    LegendLabel = "Obama",
            //    Value = "Obama"
            //};

            //// Adding EqualColorMapping to ColorMappings.
            //shapeFillSetting.ColorMappings.Add(romeyColorMapping);
            //shapeFillSetting.ColorMappings.Add(obamaColorMapping);

            //shapeSetting.FillSetting = shapeFillSetting;

            //shapeLayer.ShapeSettings = shapeSetting;

            //// Adding ShapeFileLayer into Map.
            //maps.Layers.Add(shapeLayer);
            //maps.EnableZoom = false;
            //maps.EnablePan = false;
            //this.Content = maps;
        }
    }
}