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

        public MainWindow()
        {
            InitializeComponent();
            
            yt = new YandexTranslator();
        }

        private void textChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Switcher_Click(object sender, RoutedEventArgs e)
        {
            var temp = languageFrom.SelectedItem;
            languageFrom.SelectedItem = languageTo.SelectedItem;
            languageTo.SelectedItem = temp;
        }

        private void textbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            

            //foreach (RichTextBox r in richTextBoxes)
            //{
            //    r.Document.Blocks.Clear();
            //    r.Document.FontSize = 14;
            //    r.Foreground = Brushes.Black;
            //}
            
            text.TextChanged += new TextChangedEventHandler(textChanged);
            text.GotKeyboardFocus -= new KeyboardFocusChangedEventHandler(textbox_GotKeyboardFocus);
        }

        
    }
}
