using System.Windows;


namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Инициализация DataContex новым экземпляром MainVM
            DataContext = new MainVM(); 
        }
    }
}