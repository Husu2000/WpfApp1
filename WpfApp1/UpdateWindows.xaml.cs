using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1
{
  
    public partial class UpdateWindows : Window
    {
        private Car? car;
        private string? text;

        public event PropertyChangedEventHandler? PropertyChanged;
        public string? Text { get => text; set { text = value; OnPropertyChanged(); } }
        public Car? Car { get => car; set { car = value; OnPropertyChanged(); } }
        public UpdateWindows()
        {
            InitializeComponent();
        }
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
