using System;
using System.Collections;
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

namespace WinTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void close_windows(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void select_win(int win_num)
        {
            List<Button> btn_to_win = new List<Button>();
            btn_to_win.Add(winLeft0);
            btn_to_win.Add(winLeft1);
            btn_to_win.Add(winLeft2);
            btn_to_win.Add(winLeft3);
            btn_to_win.Add(winLeft4);
            btn_to_win.Add(winLeft5);

            List<TextBlock> TB_to_win = new List<TextBlock>();
            TB_to_win.Add(winLeftTB0);
            TB_to_win.Add(winLeftTB1);
            TB_to_win.Add(winLeftTB2);
            TB_to_win.Add(winLeftTB3);
            TB_to_win.Add(winLeftTB4);
            TB_to_win.Add(winLeftTB5);

            for (int i = 0; i < btn_to_win.Count; i++)
            {
                if(i == win_num)
                {
                    var btn = new BrushConverter();
                    btn_to_win[i].Background = (Brush)btn.ConvertFrom("#9C27B3");
                    btn_to_win[i].BorderBrush = (Brush)btn.ConvertFrom("#9C27B3");
                    TB_to_win[i].Foreground = (Brush)btn.ConvertFrom("#DDFFFFFF");
                }
                else
                {
                    var btn = new BrushConverter();
                    btn_to_win[i].Background = (Brush)btn.ConvertFrom("Transparent");
                    btn_to_win[i].BorderBrush = (Brush)btn.ConvertFrom("Transparent");
                    TB_to_win[i].Foreground = (Brush)btn.ConvertFrom("#848484");
                }
            }
        }
        private void win_0_click(object sender, RoutedEventArgs e)
        {
            select_win(0);
        }

        private void win_1_click(object sender, RoutedEventArgs e)
        {
            select_win(1);
        }

        private void win_2_click(object sender, RoutedEventArgs e)
        {
            select_win(2);
        }
        private void win_3_click(object sender, RoutedEventArgs e)
        {
            select_win(3);
        }
        private void win_4_click(object sender, RoutedEventArgs e)
        {
            select_win(4);
        }
        private void win_5_click(object sender, RoutedEventArgs e)
        {
            select_win(5);
        }

        private void mix_windows(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void max_windows(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                btn_max_TB.Text = "\ue60c";
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                btn_max_TB.Text = "\ue653";
            }
        }
    }
}
