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
    /// Логика взаимодействия для LoginCard.xaml
    /// </summary>
    public partial class LoginCard : UserControl
    {
        public LoginCard()
        {
            InitializeComponent();
        }

        //name
        public string nameCard
        {
            get { return (string)GetValue(tbNameProperty); }
            set { SetValue(tbNameProperty, value); }
        }

        public static readonly DependencyProperty tbNameProperty = DependencyProperty.Register(
            "nameCard", // имя параметра в разметке 
            typeof(string), // тип данных параметра 
            typeof(LoginCard), // тип данных элемента управления 
            new PropertyMetadata(string.Empty, nameCardChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра 

        private static void nameCardChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var tbNameForm = obj as LoginCard;
            tbNameForm.tbName.Text = tbNameForm.nameCard.ToString();
        }

        //ID
        public string IDCard
        {
            get { return (string)GetValue(tbIDProperty); }
            set { SetValue(tbIDProperty, value); }
        }

        public static readonly DependencyProperty tbIDProperty = DependencyProperty.Register(
            "IDCard", // имя параметра в разметке 
            typeof(string), // тип данных параметра 
            typeof(LoginCard), // тип данных элемента управления 
            new PropertyMetadata(string.Empty, IDCardChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра 

        private static void IDCardChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var tbIDForm = obj as LoginCard;
            tbIDForm.tbID.Text = tbIDForm.IDCard.ToString();
        }

        //position
        public string positionCard
        {
            get { return (string)GetValue(tbPositionProperty); }
            set { SetValue(tbPositionProperty, value); }
        }

        public static readonly DependencyProperty tbPositionProperty = DependencyProperty.Register(
            "positionCard", // имя параметра в разметке 
            typeof(string), // тип данных параметра 
            typeof(LoginCard), // тип данных элемента управления 
            new PropertyMetadata(string.Empty, positionCardChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра 

        private static void positionCardChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var tbPositionForm = obj as LoginCard;
            tbPositionForm.tbPosition.Text = tbPositionForm.positionCard.ToString();
        }

        //images
        public string imagesCard
        {
            get { return (string)GetValue(imImagesProperty); }
            set { SetValue(imImagesProperty, value); }
        }

        public static readonly DependencyProperty imImagesProperty = DependencyProperty.Register(
            "imagesCard", // имя параметра в разметке 
            typeof(string), // тип данных параметра 
            typeof(LoginCard), // тип данных элемента управления 
            new PropertyMetadata(string.Empty, imagesCardChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра 

        private static void imagesCardChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var imImagesForm = obj as LoginCard;
            imImagesForm.imImages.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/lf1.jpg"));
        }
    }
}
