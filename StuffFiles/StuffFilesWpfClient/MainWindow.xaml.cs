using System;
using System.Windows;

namespace StuffFilesWpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var conn = new StuffFilesServiceReference.StuffFilesServiceClient("BasicHttpBinding_IStuffFilesService"))
            {
                try
                {
                    string res = conn.GetGreetings(greetingsTextBox.Text);
                    MessageBox.Show(res);
                    conn.Close();
                }
                catch (Exception) { }
            }
        }
    }
}
