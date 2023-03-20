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

namespace P3_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void knopka_Click(object sender, RoutedEventArgs e)
        {
            var task = longalg(14, pb);
            await task;
        }
        public async Task longalg(double a, ProgressBar p)
        {
            double b = 1;
            p.Maximum = a;
            for (int i = 0; i < a; i++)
            {
                b *= a;
                p.Value += 1;
                await Task.Delay(TimeSpan.FromSeconds(0.1));

            }
            lb.Content = b;
        }
    }
    //В первом случае на время выполнения метода приложение зависало без возможности выполнять
    //какие-либо другие функции, помимо активной в данный момент, даже рисовать не было возможности.
    //При запуске асинхронного метода приложение перестало "застывать", и появилась возможность
    //работать сразу с несколькими функиональными позможностями программы
}
