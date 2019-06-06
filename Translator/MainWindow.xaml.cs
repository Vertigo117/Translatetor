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

namespace Translator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        YandexTranslator yt;
        Dictionary<string, string> languages;

        public MainWindow()
        {
            InitializeComponent();
            yt = new YandexTranslator();
            languages = yt.GetLanguages();
            languageFrom.ItemsSource = languages.Values;
            languageTo.ItemsSource = languages.Values;
            languageFrom.SelectedIndex = 69;
            languageTo.SelectedIndex = 16;
            text.Text = "Введите текст";
            translation.Text = "Перевод";
        }

        private void textChanged(object sender, TextChangedEventArgs e)
        {
            string dir;
            dir = GetDir(languageFrom.Text)+"-";
            dir += GetDir(languageTo.Text);
            translation.Text = yt.Translate(text.Text,dir);
        }

        private string GetDir(string val)
        {
            string key = null;

            foreach(KeyValuePair<string, string> pair in languages)
            {
                if(pair.Value==val)
                {
                    key = pair.Key;
                    
                    break;
                }
            }

            return key;
        }

        private void Switcher_Click(object sender, RoutedEventArgs e)
        {
            var temp = languageFrom.SelectedItem;
            languageFrom.SelectedItem = languageTo.SelectedItem;
            languageTo.SelectedItem = temp;

            var temp2 = translation.Text;
            text.Text = translation.Text;
            translation.Text = temp2;

        }

        private void textbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox[] textboxes = new TextBox[] { text, translation };

            foreach (TextBox t in textboxes)
            {
                t.Clear();
                t.FontSize = 14;
                t.Foreground = Brushes.Black;
                t.TextChanged += new TextChangedEventHandler(textChanged);
                t.GotKeyboardFocus -= new KeyboardFocusChangedEventHandler(textbox_GotKeyboardFocus);
            }

            translation.Background = Brushes.LightGray;
        }

        
    }
}
