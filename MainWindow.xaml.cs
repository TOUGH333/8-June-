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
using System.Text.RegularExpressions;

namespace day7
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Name;
            Name = FIO.Text;
            string Num;
            Num = Number.Text;
            string mail;
            mail = Email.Text;
            string Sn;
            Sn = SNILS.Text;
            if (Sn.Length < 11 || Sn.Length > 11)
            {

                textBlock7.Foreground = Brushes.Red;
                textBlock7.Text = ("Fail");

                
            }
            if (Sn.Length == 11)
            {
                textBlock7.Foreground = Brushes.Green;
                textBlock7.Text = ("Acces");
                
            }
            if (Num.Length == 11)
            {
                textBlock8.Foreground = Brushes.Green;
                textBlock8.Text = ("Acces");
                
            }
            if (Num.Length < 11 || Num.Length > 11)
            {

                textBlock8.Foreground = Brushes.Red;
                textBlock8.Text = ("Fail");
            }
            if (mail.Contains(".com"))
            {
                textBlock9.Foreground = Brushes.Green;
                textBlock9.Text = ("Acces");
                
            }
            else if (mail.Contains(".ru"))
            { 
                textBlock9.Foreground = Brushes.Green;
                textBlock9.Text = ("Acces");
                
              }
              
            if (mail.Length < 3)
            {
                textBlock9.Foreground = Brushes.Red;
                textBlock9.Text = ("Fail");
            }
            if (Name.Length > 1)
            {
                textBlock10.Foreground = Brushes.Green;
                textBlock10.Text = ("Acces");
                
            }



            if (FIO.Text.Contains("0"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("1"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("2"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("3"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("4"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("5"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("6"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("7"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("8"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("9"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }
            else if (FIO.Text.Contains("0"))
            {
                textBlock10.Foreground = Brushes.Red;
                textBlock10.Text = ("Fail");
            }




        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string Name = FIO.Text;
            string Num = Number.Text;
            string mail = Email.Text;
            string Sn = SNILS.Text;

            int a = 0;
            for (; a < listbox.Items.Count; a++)
            {

            }
            listbox.Items.Add($"{Name}    |    {Num}    |     {mail}     |    {Sn}  ");


        }

        private void Number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) || (e.Text == "+"))
            {
                e.Handled = true;
            }
        }
    }
}
