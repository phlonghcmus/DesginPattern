using Project.ValidationFarmework.validator;
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
using UI.CustomValidator;
using Validation = Project.ValidationFarmework.validation.Validation;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Validation validation;
        public MainWindow()
        {
            InitializeComponent();
            ValidatorFactory validatorFactory = ValidatorFactory.GetInstance();
            validatorFactory.addValidator("NewVal", new NewValidator());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(taikhoan.Text, matkhau.Password, email.Text, date.Text);
            //User user = new User((string)taikhoan.Text);
            Validation validation = Validation.GetInstance();
            HashSet<Violation> violations = validation.validate(user);
            //List<string> notification = new List<string>();
            List<KeyValuePair<string, string>> notification = new List<KeyValuePair<string, string>>();
            var list_taikhoan = new List<string>();
            var list_matkhau = new List<string>();
            var list_email = new List<string>();
            var list_date = new List<string>();


            foreach (var violation in violations)
            {
                if (violation.PropName == "taikhoan")
                {
                    list_taikhoan.Add(violation.Message);
                    continue;
                }
                if (violation.PropName == "matkhau")
                {
                    list_matkhau.Add(violation.Message);
                    continue;
                }
                if (violation.PropName == "email")
                {
                    list_email.Add(violation.Message);
                    continue;
                }
                if (violation.PropName == "date")
                {
                    list_date.Add(violation.Message);
                    continue;
                }
            }

            listview_taikhoan.ItemsSource = list_taikhoan;
            listview_matkhau.ItemsSource = list_matkhau;
            listview_email.ItemsSource = list_email;
            listview_date.ItemsSource = list_date;

        }

    }
}
