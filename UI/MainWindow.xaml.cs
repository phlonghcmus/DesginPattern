using Project.ValidationFarmework.violation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Validation = Project.ValidationFarmework.validation.Validation;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Validation validation = new Validation();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(taikhoan.Text, matkhau.Text, email.Text, date.Text);
            //User user = new User((string)taikhoan.Text);
            Validation validation = Validation.GetInstance();
            HashSet<Violation> violations = validation.validate(user);
            List<string> notification = new List<string>();
            foreach (var violation in violations)
            {
                notification.Add(violation.getMessage());
            }
            if(notification.Count > 0)
            {
                var message = string.Join(Environment.NewLine, notification.ToArray());
                MessageBox.Show(message,"Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Đăng ký thành công","Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            

        }

    }
}
