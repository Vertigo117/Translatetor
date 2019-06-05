using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Translator
{
    class Switcher:Button
    {
        static readonly Uri uri = new Uri("pack://application:,,,/Translator;component/arrows.bmp", UriKind.RelativeOrAbsolute);

        public Switcher()
        {
            Image image = new Image();
            image.Source = new BitmapImage(uri);
            StackPanel panel = new StackPanel();
            panel.Children.Add(image);

            AddChild(panel);
        }
    }
}
