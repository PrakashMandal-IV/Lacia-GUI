﻿using System;
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
using System.Speech.Recognition;
using System.IO;

namespace Lacia_GUI
{
    public partial class MainWindow : Window
    {
        bool started = false; //check if hello initiated
        Lacia lacia = new Lacia();
        SpeechRecognitionEngine listner = new SpeechRecognitionEngine();
        public MainWindow()
        {
            InitializeComponent();
            
            StartListen();
            
        }
        private async void Start_Click(object sender, RoutedEventArgs e)
        {
            
            if (!started)
            {
                started = true;
                Status.Content = "Listening...";
                await Task.Run(() => lacia.Laciainit());              
            }
        }

        private void StartListen()
        {
            listner.SetInputToDefaultAudioDevice();
            listner.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"D:\Audio\WordList.txt")))));
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
                listner.RecognizeAsync(RecognizeMode.Multiple);
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
        
    }
}
