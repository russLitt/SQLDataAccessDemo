using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            UpdateBindind();
        }

        private void UpdateBindind()
        {
            peopleFoundListbox.ItemsSource = people;
            peopleFoundListbox.DisplayMemberPath = "FullInfo";
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameText.Text);

            UpdateBindind();
        }
    }
}
