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
using System.Speech.Synthesis;
using System.Threading;

namespace Lacia_GUI
{
    public partial class MainWindow : Window
    {
        bool started = false;
        Lacia lacia = new Lacia();
        
        
        public MainWindow()
        {
            InitializeComponent();
            Status.Content = "Click Start";

        }
        private async void Start_Click(object sender, RoutedEventArgs e)
        {
            
            if(!started)
            {
                started = true;
                await Task.Run(() => lacia.Laciainit());
                
            }
        }
        private async void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (started)
            {
                string input = Input.Text;
                await Task.Run(() =>
                {                  
                    if(lacia.LaciaBody(input))
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            Input.Text = null;
                        });
                    }
                    });               
            }
        }       
    }
}
