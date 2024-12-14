using System.IO.Packaging;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MetroHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var c1 = new FBCategory { Label = "Ховрино" };
            var c1empty = new FBCategory { Label = "" };

            var c3 = new FBCategory { Label = "Речной вокзал" };
            var c3empty = new FBCategory { Label = "" };

            var c2 = new FBCategory { Label = "Войковская" };
            var c2empty = new FBCategory { Label = "" };

            var c4 = new FBCategory { Label = "Аэропорт" };
            var c4empty = new FBCategory { Label = "" };

            var c5 = new FBCategory { Label = "Белорусская" };
            var c5empty = new FBCategory { Label = "" };

            var c6 = new FBCategory { Label = "Тверская" };
            var c6empty = new FBCategory { Label = "" };

            var c7 = new FBCategory { Label = "Новокузнецкая" };
            var c7empty = new FBCategory { Label = "" };

            var c8 = new FBCategory { Label = "Автозаводская" };
            var c8empty = new FBCategory { Label = "" };

            var c9 = new FBCategory { Label = "Коломенская" };
            var c9empty = new FBCategory { Label = "" };

            var c10 = new FBCategory { Label = "Кантемировская" };
            var c10empty = new FBCategory { Label = "" };

            var c11 = new FBCategory { Label = "Орехово" };
            var c11empty = new FBCategory { Label = "" };

            var c12 = new FBCategory { Label = "Красногвардейская" };
            var c12empty = new FBCategory { Label = "" };

            var c13 = new FBCategory { Label = "Алма-Атинская" };
            var c13empty = new FBCategory { Label = "" };
            
            var c14 = new FBCategory { Label = "Беломорская" };
            var c14empty = new FBCategory { Label = "" };

            var c15 = new FBCategory { Label = "Водный стадион" };
            var c15empty = new FBCategory { Label = "" };

            var c16 = new FBCategory { Label = "Сокол" };
            var c16empty = new FBCategory { Label = "" };

            var c17 = new FBCategory { Label = "Динамо" };
            var c17empty = new FBCategory { Label = "" };

            var c18 = new FBCategory { Label = "Маяковская" };
            var c18empty = new FBCategory { Label = "" };

            var c19 = new FBCategory { Label = "Театральная" };
            var c19empty = new FBCategory { Label = "" };

            var c20 = new FBCategory { Label = "Павелецкая" };
            var c20empty = new FBCategory { Label = "" };

            var c21 = new FBCategory { Label = "21" };
            var c21empty = new FBCategory { Label = "" };

            var c22 = new FBCategory { Label = "Технопарк" };
            var c22empty = new FBCategory { Label = "" };

            var c23 = new FBCategory { Label = "Каширская" };
            var c23empty = new FBCategory { Label = "" };

            var c24 = new FBCategory { Label = "Царицыно" };
            var c24empty = new FBCategory { Label = "" };

            var c25 = new FBCategory { Label = "Домодедовская" };
            var c25empty = new FBCategory { Label = "" };

            var c26 = new FBCategory { Label = "ТЧ Южное" };
            var c26empty = new FBCategory { Label = "" };








            var model = new List<FBCategory>
    {c1,c1empty,c3,c3empty,c2,c2empty,c4,c4empty,c5,c5empty,c6,c6empty,c7,c7empty,c8,c8empty,c9,c9empty,c10,c10empty,c11,c11empty,c12,c12empty,c13,c13empty,c14,c14empty,c15,c15empty,c16,c16empty,c17,c17empty,c18,c18empty,c19,c19empty,c20,c21empty,c22,c22empty,c23,c23empty,c24,c24empty,c25,c25empty,c26,c26empty};

            

            fdiag.Title = "Замоскворецкая линия";
            fdiag.LabelPath = "Label";
            fdiag.CausesPath = "Causes";
            fdiag.ItemsSource = model;

            fdiag.StemStroke = Brushes.Red;
            fdiag.BranchStroke = Brushes.Green;

            fdiag.DiagramGenerated +=
                (s, args) => fdiag.ResizeToFitItems(10);

        }


        public class FBCategory
        {
            public FBCategory()
            {
                Causes = new List<string>();
            }
            public string Label { get; set; }
            public List<string> Causes { get; set; }
        }


    }
}