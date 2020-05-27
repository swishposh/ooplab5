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

namespace LoginForm_HB
{
    /// <summary>
    /// Логика взаимодействия для LF1.xaml
    /// </summary>
    public partial class LF1 : UserControl
    {
        public LF1()
        {
            InitializeComponent();
        }

        public string Login
        {
            get { return (string)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }

        public static readonly DependencyProperty LoginProperty = DependencyProperty.Register(
            "Login", // имя параметра в разметке 
            typeof(string), // тип данных параметра 
            typeof(LF1), // тип данных элемента управления 
            new PropertyMetadata(string.Empty, LoginChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра 

        private static void LoginChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as LF1;
            loginForm.tbLogin.Text = loginForm.Login;
        }


        private void tbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            string password = tbPassword.Text;

            if (password.Length > 4)
            {
                icon.Source = null;
            }
            else
            {
                icon.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/off.jpg"));
            }
            //string login = tbLogin.Text;

            //// длина логина должна быть не менее 4 символов, 
            //// а длина пароля - не менее 8 символов 
            //bool isDataValid = login.Length >= 4 && password.Length >= 4;
            //if (isDataValid)
            //    icon.Source = null;
            //else
            //{
            //    icon.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/off.jpg"));
            //}
        }
    }
}
