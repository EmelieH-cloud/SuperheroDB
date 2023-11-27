using SuperheroDB.Databas;
using System.Windows;
using System.Windows.Controls;

namespace SuperheroDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateUI();
        }

        void PopulateUI()
        {
            using (myDbContext context = new())
            {
                var heroes = context.Heroes.ToList();

                foreach (var h in heroes)
                {
                    ListViewItem item = new();
                    item.Tag = h;
                    item.Content = h.Name;
                    lstHeroes.Items.Add(item);
                }
            }

        }
    }
}