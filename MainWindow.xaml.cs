using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Speech.Recognition;
using System.IO;
using System.Windows.Navigation;


namespace Lacia_GUI
{
    public partial class MainWindow : Window
    {
        bool started = false; //check if hello initiated
        Lacia lacia = new Lacia();      
        SpeechRecognitionEngine listner = new SpeechRecognitionEngine();
        private string pass = "12345";       
        public MainWindow()
        {
            InitializeComponent();
            StartListen();
            DateLabel.Content = DateTime.Now.ToString("dd MMMM yyyy");
            TimeLabel.Content = DateTime.Now.ToString("h:mm tt");
            Start.Visibility = Visibility.Hidden;
            Input.Visibility = Visibility.Hidden;
            PasswordStatus.Visibility = Visibility.Hidden;
            this.Background= new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "/Images/Lacia_Logo.jpg")));
        }
        
        private async void Start_Click(object sender, RoutedEventArgs e)
        {                                                       
            Start.Visibility = Visibility.Hidden;          
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "/Images/Lacia_Activate.jpg")));
            listner.RecognizeAsync(RecognizeMode.Multiple);
                await Task.Run(() =>
                {                    
                    lacia.Laciainit();
                    });
             started = true;
            Input.Visibility = Visibility.Visible;
        }

        private void StartListen()
        {
            listner.SetInputToDefaultAudioDevice();
            listner.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"D:\Grammer.txt")))));
            listner.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Speech_recognized);           
        }

        private void Speech_recognized(object sender, SpeechRecognizedEventArgs e)
        {           
            string speech = e.Result.Text;
            Input.Text = speech;
       }

        private async void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (started)
            {              
                string input = Input.Text;              
                await Task.Run(() => {                   
                    Lacia(input);
                    });
            }
        }
        public void Lacia(string input)
        {       
            if (input != null)
            {
                if (lacia.LaciaBody(input))
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        Input.Clear();
                        Input.Text = null;
                    });
                }
            }
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if(login.Text == pass)
            {
                Rect.Visibility = Visibility.Collapsed;
                login.Visibility = Visibility.Collapsed;
                loginButton.Visibility = Visibility.Collapsed;
                PasswordLabel.Visibility = Visibility.Collapsed;
                PasswordStatus.Visibility = Visibility.Collapsed;
                Start.Visibility = Visibility.Visible;              
            }
            else
            {
                PasswordStatus.Visibility = Visibility.Visible;
            }
        }
    }
}
