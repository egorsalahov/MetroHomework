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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var c1 = new FBCategory { Label = "Ховрино" };
            c1.Causes = new List<string>
    { "Дыбенко", "Зеленоградская", "Прибрежный проезд" };
            var c1empty = new FBCategory { Label = "" };

            var c3 = new FBCategory { Label = "Речной вокзал" };
            c3.Causes = new List<string>
    { "Фестивальная"};
            var c3empty = new FBCategory { Label = "" };

            var c2 = new FBCategory { Label = "Войковская" };
            c2.Causes = new List<string>
    { "Ленинградское шоссе", "площадь Ганецкого, Зои и Александра Космодемьянских" };
            var c2empty = new FBCategory { Label = "" };

            var c4 = new FBCategory { Label = "Аэропорт" };
            c4.Causes = new List<string>
    { "Ленинградский проспект", "Черняховского", "1-я Аэропортская", "Викторенко" };
            var c4empty = new FBCategory { Label = "" };

            var c5 = new FBCategory { Label = "Белорусская" };
            c5.Causes = new List<string>
    { "Тверская застава", "Грузинский вал", "Ленинградский проспект", "2-я Брестская" };
            var c5empty = new FBCategory { Label = "" };

            var c6 = new FBCategory { Label = "Тверская" };
            c6.Causes = new List<string>
    { "Тверская улица", "Пушкинская площадь", "Страстной бульвар", "Тверской бульвар" };
            var c6empty = new FBCategory { Label = "" };

            var c7 = new FBCategory { Label = "Новокузнецкая" };
            c7.Causes = new List<string>
    { "Пятницкая", "Садовнический проезд", "Новокузнецкая", "Кузбасская площадь" };
            var c7empty = new FBCategory { Label = "" };

            var c8 = new FBCategory { Label = "Автозаводская" };
            c8.Causes = new List<string>
    { "Автозаводская", "Мастеркова"};
            var c8empty = new FBCategory { Label = "" };

            var c9 = new FBCategory { Label = "Коломенская" };
            c9.Causes = new List<string>
    { "Нагатинская", "проспект Андропова"};
            var c9empty = new FBCategory { Label = "" };

            var c10 = new FBCategory { Label = "Кантемировская" };
            c10.Causes = new List<string>
    { "Пролетарский проспект", "Кантемировская"};
            var c10empty = new FBCategory { Label = "" };

            var c11 = new FBCategory { Label = "Орехово" };
            c11.Causes = new List<string>
    { "улица Баженова", "Шипиловский проезд"};
            var c11empty = new FBCategory { Label = "" };

            var c12 = new FBCategory { Label = "Красногвардейская" };
            c12.Causes = new List<string>
    { "Ореховый бульвар", "Мусы Джалиля", "Ясеневая" };
            var c12empty = new FBCategory { Label = "" };

            var c13 = new FBCategory { Label = "Алма-Атинская" };
            c13.Causes = new List<string>
    { "Братеевская", "Паромная", "Ключевая" };
            var c13empty = new FBCategory { Label = "" };
            
            var c14 = new FBCategory { Label = "Беломорская" };
            c14.Causes = new List<string>
    { "Беломорская", "Смольная"};
            var c14empty = new FBCategory { Label = "" };

            var c15 = new FBCategory { Label = "Водный стадион" };
            c15.Causes = new List<string>
    { "Головинское шоссе", "Кронштадский бульвар", "улица Адмирала Макарова" };
            var c15empty = new FBCategory { Label = "" };

            var c16 = new FBCategory { Label = "Сокол" };
            c16.Causes = new List<string>
    { "Ленинградский проспект"};
            var c16empty = new FBCategory { Label = "" };

            var c17 = new FBCategory { Label = "Динамо" };
            c17.Causes = new List<string>
    { "Ленинградский проспект", "Московская аллея", "Тетральная аллея", "Трудовая аллея", "к стадиону Динамо"};
            var c17empty = new FBCategory { Label = "" };

            var c18 = new FBCategory { Label = "Маяковская" };
            c18.Causes = new List<string>
    { "Триумфальная площадь", "Тверская", "1-я Тверская-Ямская", "Садовая-Триумфальная", "Большая Садовая" };
            var c18empty = new FBCategory { Label = "" };

            var c19 = new FBCategory { Label = "Театральная" };
            c19.Causes = new List<string>
    { "Охотный Ряд", "Театральный проезд", "Манежная площадь", "Никольская" };
            var c19empty = new FBCategory { Label = "" };

            var c20 = new FBCategory { Label = "Павелецкая" };
            c20.Causes = new List<string>
    { "здание Павелецкого вокзала", "Павелецкая площадь", "Зацепа", "Дубининская", "Садовое кольцо", "Новокузнецкая улица" };
            var c20empty = new FBCategory { Label = "" };

            //магическая магия, нужно для верстки
            var c21 = new FBCategory { Label = "21" };
            var c21empty = new FBCategory { Label = "" };

            var c22 = new FBCategory { Label = "Технопарк" };
            c22.Causes = new List<string>
    { "проспект Андропова", "Мустая Карима", "проспект Лихачёва" };
            var c22empty = new FBCategory { Label = "" };

            var c23 = new FBCategory { Label = "Каширская" };
            c23.Causes = new List<string>
    { "Маршала Шестопалова", "Каширское шоссе"};
            var c23empty = new FBCategory { Label = "" };

            var c24 = new FBCategory { Label = "Царицыно" };
            c24.Causes = new List<string>
    { "Луганская", "Товарищеская", "Каспийская" };
            var c24empty = new FBCategory { Label = "" };

            var c25 = new FBCategory { Label = "Домодедовская" };
            c25.Causes = new List<string>
    { "Каширское шоссе", "улица Генерала Белова", "Ореховый бульвар" };
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