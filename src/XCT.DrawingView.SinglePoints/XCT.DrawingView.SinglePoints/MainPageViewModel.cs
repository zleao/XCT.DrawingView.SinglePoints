using System.Collections.ObjectModel;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace XCT.DrawingView.SinglePoints
{
    public class MainPageViewModel
    {
        public ObservableCollection<Line> Lines { get; private set; } = new ObservableCollection<Line>();
        public float LineWidth => 7;
        public Color LineColor => Color.Black;
        public Color BackgroundColor => Color.LightGray;

        public MainPageViewModel()
        {
            Lines.Add(new Line() 
            { 
                Points = new ObservableCollection<Point> 
                { 
                    new Point(200, 300) 
                },
                LineColor = LineColor,
                LineWidth = LineWidth
            });
            Lines.Add(new Line()
            {
                Points = new ObservableCollection<Point>
                {
                    new Point(220, 300)
                },
                LineColor = LineColor,
                LineWidth = LineWidth
            });
            Lines.Add(new Line()
            {
                Points = new ObservableCollection<Xamarin.Forms.Point>
                {
                    new Point(200, 320), new Xamarin.Forms.Point(220, 320) 
                },
                LineColor = LineColor,
                LineWidth = LineWidth
            });
        }
    }
}
