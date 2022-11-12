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
using System.Windows.Media.Media3D;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для _3d_model.xaml
    /// </summary>
    public partial class _3d_model : Window
    {
        
        public _3d_model(float wid, float len, float h1, float h2, float h3)
        {
            InitializeComponent();
            widt = wid;
            leng = len;
            h11 = h1;
            h22 = h2;
            h33 = h3;
            meshMain.Positions.Clear();
            meshMain.Positions.Add(new Point3D(0, 0, 0));
            //Point3D point = new Point3D(0,0,0);
            //meshMain.Positions.Add(point);
            float a = widt;
            float b = leng;
            float c = h11;

            float maximum = Math.Max(a, b);
            if (maximum < c)
            {
                maximum = c;
            }
            a = 2 / (maximum / a);
            b = 2 / (maximum / b);
            c = 2 / (maximum / c);
            //MessageBox.Show("a = "+a.ToString());
            //MessageBox.Show("b = "+b.ToString());
            //MessageBox.Show("c = "+c.ToString());

            meshMain.Positions.Add(new Point3D(0, 0, c));
            meshMain.Positions.Add(new Point3D(0, b, 0));
            meshMain.Positions.Add(new Point3D(0, b, c));
            meshMain.Positions.Add(new Point3D(a, 0, 0));
            //meshMain.Positions.Add(new Point3D(a, 0, c));
            meshMain.Positions.Add(new Point3D(a, b, 0));
            meshMain.Positions.Add(new Point3D(a, b, c));
            Color white_light = new Color();
            white_light = Color.FromRgb(255, 255, 255);
            dirLightMain.Color = white_light;
            //MessageBox.Show(meshMain.Positions.ToString());
        }

        public float widt, leng, h11, h22, h33;
        //MainWindow main = this.Owner as MainWindow;
        //3d_model powned = new _3d_model();
        //_3d_model.Owner = MainWindow();
        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {/*
            */
        }
        
        int texture_num = 0;
        private void test_btn_Click(object sender, RoutedEventArgs e)
        {
            //Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("default_black.png", UriKind.Relative);

            switch (texture_num)
            {
                case 0:
                    bi3.UriSource = new Uri("default_black.png", UriKind.Relative);
                    texture_num++;
                    break;
                case 1:
                    bi3.UriSource = new Uri("default_white.png", UriKind.Relative);
                    texture_num++;
                    break;
                case 2:
                    bi3.UriSource = new Uri("points_black.png", UriKind.Relative);
                    texture_num++;
                    break;
                case 3:
                    bi3.UriSource = new Uri("points_white.png", UriKind.Relative);
                    texture_num++;
                    break;
                case 4:
                    bi3.UriSource = new Uri("text_texture.png", UriKind.Relative);
                    texture_num = 0;
                    break;
            }
            bi3.EndInit();
            //myImage3.Stretch = Stretch.Fill;
            //myImage3.Source = bi3;
            Box_texture.ImageSource = bi3;

            //camMain.Position.Point3D.X(1);
            //MessageBox.Show(e);
            // MessageBox.Show(meshMain.Positions.ToString());
            
        }
        int theme_count = 0;


        private void backgound_color_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void backgr_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush theme_w = new SolidColorBrush(Colors.White);
            SolidColorBrush theme_b = new SolidColorBrush(Colors.Black);
            if (theme_count == 0)
            {
                theme_count++;
                //window_main.Background = theme_w;
                //window_main.Background = theme_w;
            }
            else
            {
                theme_count = 0;
                //window_main.Background = theme_b;
            }
            MessageBox.Show(theme_count.ToString());
        }

        private void backgound_color_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
