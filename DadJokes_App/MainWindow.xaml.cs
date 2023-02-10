using RestApi_Library;
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

namespace DadJokes_App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.Init();
        }
        public async Task LoadJoke(int num=0)
        {
            var joke=await WorkProcess.LoadJoke(num);
            jokeText.Text=joke.joke;
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadJoke();
        }
    }
}
