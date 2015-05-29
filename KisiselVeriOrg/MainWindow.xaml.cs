using System;
using System.Collections.Generic;
using System.IO;
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
using Xceed.Wpf.Toolkit;
using System.Windows.Media.Animation;
using System.Data;

namespace KisiselVeriOrg
{
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    /// <summary>
    {
        StreamWriter cFile = File.AppendText(@"D:/ImportMe.txt");
        StreamWriter cFile2 = File.AppendText(@"D:/SearchMe.txt");
        StreamWriter cFile3 = File.AppendText(@"D:/Options.txt");
        Label[] labels = new Label[30];
        Button[] butons = new Button[20];
        ColorPicker[] colors = new ColorPicker[2];
        TextBox[] textboxes = new TextBox[20];
        bool canokon = true;
        bool canokon2 = true;
        bool kon = true;

        public MainWindow()
        {
            InitializeComponent();
            labels[0] = label1; labels[1] = label2; labels[2] = label3; labels[3] = label4; labels[4] = label5; labels[5] = label6; labels[6] = label7; labels[7] = label8; labels[8] = label9; labels[9] = label10; labels[10] = label11; labels[11] = label12;
            labels[12] = label13; labels[13] = label14; labels[14] = label15; labels[15] = label16; labels[16] = label17; labels[17] = label18; labels[18] = label19; labels[19] = label20; labels[20] = label21; labels[21] = label22; labels[22] = label23; labels[23] = label24; labels[24] = label25;
            butons[0] = buton1; butons[1] = buton2; butons[2] = buton3; butons[3] = buton4; butons[4] = buton5; butons[5] = buton6; butons[6] = buton7; butons[7] = buton8; butons[8] = buton9; butons[9] = buton10; butons[10] = buton11; butons[11] = buton12;
            colors[0] = colorpicker1; colors[1] = colorpicker2;
            textboxes[0] = textbox1; textboxes[1] = textbox2; textboxes[2] = textbox3; textboxes[3] = textbox4; textboxes[4] = textbox5; textboxes[5] = textbox6;
            cFile.Close();
            cFile2.Close();
            cFile3.Close();
            String ProjectFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.IO.DirectoryInfo diro = new System.IO.DirectoryInfo(ProjectFolder);
            for (int b = 1; b < 13; b++)
            {
                string filePath = System.IO.Path.Combine(diro.ToString() + "\\images", "buton" + b + ".png");
                if (File.Exists(filePath))
                {
                    BitmapImage bitimg = new BitmapImage();
                    bitimg.BeginInit();
                    bitimg.UriSource = new Uri(@"" + diro + "\\images\\buton" + b + ".png", UriKind.RelativeOrAbsolute);
                    bitimg.EndInit();
                    Image img = new Image();
                    img.Stretch = Stretch.Fill;
                    img.Source = bitimg;
                    butons[b - 1].Content = img;
                }
            }
            string filePath2 = System.IO.Path.Combine(diro.ToString() + "\\images", "default-avatar.png");
            if (File.Exists(filePath2))
            {
                BitmapImage bitimg = new BitmapImage();
                bitimg.BeginInit();
                bitimg.UriSource = new Uri(@"" + diro + "\\images\\default-avatar.png", UriKind.RelativeOrAbsolute);
                bitimg.EndInit();
                Image img = new Image();
                img.Stretch = Stretch.Fill;
                image3.Source = bitimg;
            }
            System.IO.DirectoryInfo diro2 = new System.IO.DirectoryInfo(ProjectFolder);
                string filePath3 = System.IO.Path.Combine(diro.ToString() + "\\images", "default-avatar.png");
                if (File.Exists(filePath3))
                {
                    BitmapImage bitimg = new BitmapImage();
                    bitimg.BeginInit();
                    bitimg.UriSource = new Uri(@"" + diro + "\\images\\default-avatar.png", UriKind.RelativeOrAbsolute);
                    bitimg.EndInit();
                    Image img = new Image();
                    img.Stretch = Stretch.Fill;
                    image1.Source = bitimg;
                }
            canvas4.Visibility = Visibility.Collapsed;
            canvas3.Visibility = Visibility.Collapsed;
            buton12.Visibility = Visibility.Collapsed;
            buton11.Visibility = Visibility.Collapsed;
            canvas1.Visibility = Visibility.Collapsed;
            canvas2.Visibility = Visibility.Collapsed;
            label8.Visibility = Visibility.Collapsed;
            Directory.CreateDirectory(diro + "\\pics");
            cFile.Close();
            cFile2.Close();
            cFile3.Close();
            StreamReader oku = new StreamReader(@"D:/ImportMe.txt");
            string okundu = oku.ReadToEnd();
            oku.Close();
            if (okundu == "")
            {
                StreamWriter wrote = new StreamWriter(@"D:/ImportMe.txt");
                wrote.Write("First Name,Last Name,E-mail Address,Mobile Phone,Birthday,Home Address");
                wrote.WriteLine();
                wrote.Close();
            } StreamReader oku2 = new StreamReader(@"D:/SearchMe.txt");
            string okundu2 = oku2.ReadToEnd();
            oku2.Close();
            if (okundu2 == "")
            {
                StreamWriter wrote2 = new StreamWriter(@"D:/SearchMe.txt");
                wrote2.Write("%");
                wrote2.Close();
            }
            StreamReader file3 = new StreamReader(@"D:/Options.txt");
            string dosya3 = file3.ReadToEnd();
            file3.Close();
            if (dosya3 == "")
            {
                StreamWriter wrote = new StreamWriter(@"D:/Options.txt");
                wrote.Write("&#FFFFFFFF&%#FF000000%$Segoe UI$");
                wrote.Close();
            }
            StreamReader file = new StreamReader(@"D:/Options.txt");
            string dosya = file.ReadToEnd();
            file.Close();
                string[] sembol = { "&" };
                string[] bolunenler = dosya.Split(sembol, StringSplitOptions.RemoveEmptyEntries);
                foreach (string renk in bolunenler)
                {
                    Application.Current.MainWindow.Background = new BrushConverter().ConvertFromString(bolunenler[0]) as SolidColorBrush;
                    canvas3.Background = new BrushConverter().ConvertFromString(bolunenler[0]) as SolidColorBrush;
                    if (bolunenler[0] == Brushes.Black.ToString())
                    {
                        canvas3.Background = new BrushConverter().ConvertFromString(Brushes.White.ToString()) as SolidColorBrush;
                        listview1.Background = new BrushConverter().ConvertFromString(Brushes.White.ToString()) as SolidColorBrush;
                    }
                    Color color1 = (Color)ColorConverter.ConvertFromString(bolunenler[0]);
                    colorpicker1.SelectedColor = color1;
                    listview1.Background = new BrushConverter().ConvertFromString(bolunenler[0]) as SolidColorBrush;
                    datepicker1.Background = new BrushConverter().ConvertFromString(bolunenler[0]) as SolidColorBrush;
                    datepicker2.Background = new BrushConverter().ConvertFromString(bolunenler[0]) as SolidColorBrush;
                }
                StreamReader file2 = new StreamReader(@"D:/Options.txt");
                string dosya2 = file2.ReadToEnd();
                file2.Close();
                string[] sembol2 = { "%" };
                string[] bolunenler2 = dosya2.Split(sembol2, StringSplitOptions.RemoveEmptyEntries);
                foreach (string renk2 in bolunenler2)
                {
                    for (int a = 0; a < 25; a++)
                        labels[a].Foreground = new BrushConverter().ConvertFromString(bolunenler2[1]) as SolidColorBrush;
                    for (int b = 0; b < 6; b++)
                        textboxes[b].Foreground = new BrushConverter().ConvertFromString(bolunenler2[1]) as SolidColorBrush;
                    datepicker1.Foreground = new BrushConverter().ConvertFromString(bolunenler2[1]) as SolidColorBrush;
                    datepicker2.Foreground = new BrushConverter().ConvertFromString(bolunenler2[1]) as SolidColorBrush;
                    combobox1.Foreground = new BrushConverter().ConvertFromString(bolunenler2[1]) as SolidColorBrush;
                    Color color2 = (Color)ColorConverter.ConvertFromString(bolunenler2[1]);
                    colorpicker2.SelectedColor = color2;
                    listview1.Foreground = new BrushConverter().ConvertFromString(bolunenler2[1]) as SolidColorBrush;
                }
                StreamReader file4 = new StreamReader(@"D:/Options.txt");
                string dosya4 = file4.ReadToEnd();
                file4.Close();
                string[] sembol4 = { "$" };
                string[] bolunenler4 = dosya4.Split(sembol4, StringSplitOptions.RemoveEmptyEntries);
                foreach (string yazi in bolunenler4)
                {
                    Application.Current.MainWindow.FontFamily = new FontFamily(yazi);
                    combobox1.Text = yazi;
                }
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 1;
            da.Duration = TimeSpan.FromSeconds(4);
            da.AutoReverse = false;
            //da.RepeatBehavior=new RepeatBehavior(3);
            label14.BeginAnimation(OpacityProperty, da);
            buton9.BeginAnimation(OpacityProperty, da);
            buton6.BeginAnimation(OpacityProperty, da);
            buton7.BeginAnimation(OpacityProperty, da);
            buton10.BeginAnimation(OpacityProperty, da);
        }
        class Item
        {
            string isim;
            string soyisim;
            string eposta;
            string telefon;

            public Item(string a, string b, string c, string d)
            {
                isim = a;
                soyisim = b;
                eposta = c;
                telefon = d;
            }

            public string İsim
            {
                set { isim = value; }
                get { return isim; }
            }

            public string Soyisim
            {
                set { soyisim = value; }
                get { return soyisim; }
            }
            public string Eposta
            {
                set { eposta = value; }
                get { return eposta; }
            }
            public string Telefon
            {
                set { telefon = value; }
                get { return telefon; }
            }
        }
        void ClearTextBoxes(DependencyObject obj)
        {
            TextBox tb = obj as TextBox;
            if (tb != null)
                tb.Text = "";

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                ClearTextBoxes(VisualTreeHelper.GetChild(obj, i));
            combobox1.Text = Application.Current.MainWindow.FontFamily.ToString();
            String ProjectFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.IO.DirectoryInfo diro = new System.IO.DirectoryInfo(ProjectFolder);
            string filePath = System.IO.Path.Combine(diro.ToString() + "\\images", "default-avatar.png");
            if (File.Exists(filePath))
            {
                BitmapImage bitimg = new BitmapImage();
                bitimg.BeginInit();
                bitimg.UriSource = new Uri(@"" + diro + "\\images\\default-avatar.png", UriKind.RelativeOrAbsolute);
                bitimg.EndInit();
                Image img = new Image();
                img.Stretch = Stretch.Fill;
                image1.Source = bitimg;
            }
        }
        void KayitKontrol(DependencyObject obj)
        {
            StreamReader file = new StreamReader(@"D:/SearchMe.txt");
            string dosya = file.ReadToEnd();
            file.Close();
            int k = 0;
            kon = true;
            string[] sembol = { "%" };
            string[] bolunenler = dosya.Split(sembol, StringSplitOptions.RemoveEmptyEntries);
            foreach (String word in bolunenler)
            {
                string[] sembol2 = { "*" };
                string[] bolunenler2 = word.Split(sembol2, StringSplitOptions.RemoveEmptyEntries);
                foreach (String word2 in bolunenler2)
                {
                    if (textbox1.Text == bolunenler2[k] && textbox6.Text == bolunenler2[k+1] && datepicker1.Text == bolunenler2[k+6])
                    {
                        System.Windows.MessageBox.Show("Bu kişi zaten kayıtlı!");
                        kon = false;
                        k++;
                        break;
                    }
                }
            }
        }
        private void buton1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            cFile.Close();
            String ProjectFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.IO.DirectoryInfo diro = new System.IO.DirectoryInfo(ProjectFolder);
            string filePath2 = System.IO.Path.Combine(diro.ToString() + "\\images", "default-avatar.png");
            dlg.Title = "Resim Seç";
            dlg.Filter = " (*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif";
            dlg.FilterIndex = 1;
            dlg.ShowDialog();
            if (dlg.FileName.ToString() == "")
            {
                BitmapImage bitimg = new BitmapImage();
                bitimg.BeginInit();
                bitimg.UriSource = new Uri(@"" + diro + "\\images\\default-avatar.png", UriKind.RelativeOrAbsolute);
                bitimg.EndInit();
                Image img = new Image();
                img.Stretch = Stretch.Fill;
                image1.Source = bitimg;
            }
            else
            image1.Source = new ImageSourceConverter().ConvertFromString(dlg.FileName.ToString()) as ImageSource;
        }

        private void buton2_Click(object sender, RoutedEventArgs e)
        {
            cFile.Close();
            cFile2.Close();
            KayitKontrol(this);
            if (kon == true)
            {
                String ProjectFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                System.IO.DirectoryInfo diro = new System.IO.DirectoryInfo(ProjectFolder);
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)image1.Source));
                using (FileStream stream = new FileStream(diro.ToString() + "\\pics\\" + textbox1.Text.ToString() + textbox6.Text.ToString() + ".png", FileMode.Create))
                    encoder.Save(stream);
                string[] split = textbox2.Text.Split(new char[] { '-', '(', ')' });// remove all old format,if your phone number is like(001)123-456-789
                StringBuilder sb = new StringBuilder();
                foreach (string s in split)
                {
                    if (s.Trim() != "")
                    {
                        sb.Append(s);
                    }
                }
                this.textbox2.Text = String.Format("{0:0000-0000000}", double.Parse(sb.ToString()));//you will get 0001-12-345-67-89
                StreamReader file = new StreamReader(@"D:/ImportMe.txt");
                string dosya = file.ReadToEnd();
                file.Close();
                StreamWriter yaz = new StreamWriter(@"D:/ImportMe.txt");
                yaz.Write(dosya);
                yaz.WriteLine(textbox1.Text.ToString() + "," + textbox6.Text.ToString() + "," + textbox3.Text.ToString() + "," + textbox2.Text.ToString() + "," + datepicker1.Text.ToString() + "," + textbox4.Text.ToString());
                yaz.Close();
                StreamReader file2 = new StreamReader(@"D:/SearchMe.txt");
                string dosya2 = file2.ReadToEnd();
                file2.Close();
                StreamWriter yaz2 = new StreamWriter(@"D:/SearchMe.txt");
                yaz2.Write(dosya2);
                yaz2.Write("*" + textbox1.Text.ToString() + "*" + textbox6.Text.ToString() + "*" + image1.Source.ToString() + ".png" + "*" + textbox2.Text.ToString() + "*" + textbox3.Text.ToString() + "*" + textbox4.Text.ToString() + "*" + datepicker1.Text.ToString() + "*" + datepicker2.Text.ToString() + "*%");
                yaz2.Close();
            }
            ClearTextBoxes(this);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.FontFamily = new FontFamily(combobox1.Text.ToString());
            StreamReader file = new StreamReader(@"D:/Options.txt");
            string dosya = file.ReadToEnd();
            file.Close();
            string[] sembol = { "&", "%" };
            string[] bolunenler = dosya.Split(sembol, StringSplitOptions.RemoveEmptyEntries);
            foreach (String word in bolunenler)
            {
                StreamWriter wrote = new StreamWriter(@"D:/Options.txt");
                wrote.Write("&"+ bolunenler[0] + "&%" + bolunenler[1] + "%$" + combobox1.Text.ToString() + "$");
                wrote.Close();

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Background = new BrushConverter().ConvertFromString(colorpicker1.SelectedColor.ToString()) as SolidColorBrush;
            for (int k = 0; k < 12; k++)
                butons[k].Background = new BrushConverter().ConvertFromString(colorpicker1.SelectedColor.ToString()) as SolidColorBrush;
            string canorenk = colorpicker1.SelectedColor.ToString();
            canvas3.Background = new BrushConverter().ConvertFromString(colorpicker1.SelectedColor.ToString()) as SolidColorBrush;
            listview1.Background = new BrushConverter().ConvertFromString(colorpicker1.SelectedColor.ToString()) as SolidColorBrush;
            datepicker1.Background = new BrushConverter().ConvertFromString(colorpicker1.SelectedColor.ToString()) as SolidColorBrush;
            datepicker2.Background = new BrushConverter().ConvertFromString(colorpicker1.SelectedColor.ToString()) as SolidColorBrush;
            if (canorenk == Brushes.Black.ToString())
            {
                canvas3.Background = new BrushConverter().ConvertFromString(Brushes.White.ToString()) as SolidColorBrush;
                listview1.Background = new BrushConverter().ConvertFromString(Brushes.White.ToString()) as SolidColorBrush;
            }
            cFile.Close();
            cFile2.Close();
            StreamReader file = new StreamReader(@"D:/Options.txt");
            string dosya = file.ReadToEnd();
            file.Close();
                string[] sembol = { "%","$" };
                string[] bolunenler = dosya.Split(sembol, StringSplitOptions.RemoveEmptyEntries);
                foreach (String word in bolunenler)
                {
                    StreamWriter wrote = new StreamWriter(@"D:/Options.txt");
                    wrote.Write("&" + colorpicker1.SelectedColor.ToString() + "&%" + bolunenler[1] + "%$"+ bolunenler[2] + "$");
                    wrote.Close();
                }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            for(int k = 0; k < 25; k++)
            labels[k].Foreground = new BrushConverter().ConvertFromString(colorpicker2.SelectedColor.ToString()) as SolidColorBrush;
            for (int l = 0; l < 6; l++ )
                textboxes[l].Foreground = new BrushConverter().ConvertFromString(colorpicker2.SelectedColor.ToString()) as SolidColorBrush;
            datepicker1.Foreground = new BrushConverter().ConvertFromString(colorpicker2.SelectedColor.ToString()) as SolidColorBrush;
            datepicker2.Foreground = new BrushConverter().ConvertFromString(colorpicker2.SelectedColor.ToString()) as SolidColorBrush;
            combobox1.Foreground = new BrushConverter().ConvertFromString(colorpicker2.SelectedColor.ToString()) as SolidColorBrush;
            listview1.Foreground = new BrushConverter().ConvertFromString(colorpicker2.SelectedColor.ToString()) as SolidColorBrush;

            cFile.Close();
            cFile2.Close();
            StreamReader file = new StreamReader(@"D:/Options.txt");
            string dosya = file.ReadToEnd();
            file.Close();
                string[] sembol = { "&", "$" };
                string[] bolunenler = dosya.Split(sembol, StringSplitOptions.RemoveEmptyEntries);
                foreach (String word in bolunenler)
                {
                    StreamWriter wrote = new StreamWriter(@"D:/Options.txt");
                    wrote.Write("&"+ bolunenler[0] + "&%" + colorpicker2.SelectedColor.ToString() + "%$" + bolunenler[2] + "$");
                    wrote.Close();
                }
            }

        private void buton8_Click(object sender, RoutedEventArgs e)
        {
            String ProjectFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.IO.DirectoryInfo diro = new System.IO.DirectoryInfo(ProjectFolder);
            cFile.Close();
            cFile2.Close();
            StreamReader file = new StreamReader(@"D:/SearchMe.txt");
            string dosya = file.ReadLine();
            file.Close();
            string girilen = textbox5.Text.ToString();
            string[] sembol = {"%"};
            string[] bolunenler = dosya.Split (sembol ,StringSplitOptions.RemoveEmptyEntries);
            int k = 5;
            bool kontrol = false;
            foreach (String word in bolunenler )
            {
                string[] sembol2 = {"*"};
                string[] bolunenler2 = word.Split(sembol2, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < bolunenler2.Count(); j++)
                {
                    if (girilen == bolunenler2[j])
                    {
                        foreach (String word2 in bolunenler2)
                        {
                                if (k == 13)
                                    break;
                                labels[k].Content = word2;
                                if(k==12)
                                labels[k + 11].Content = word2;
                                k++;
                            }
                        image3.Source = new ImageSourceConverter().ConvertFromString(diro.ToString()+"\\pics\\"+label6.Content.ToString()+label7.Content.ToString()+".png") as ImageSource;
                        kontrol = true;
                    }
                }
            }
            if ( kontrol == false) {
                System.Windows.MessageBox.Show("Aramaya uygun eşleşme bulunamadı.");
                string filePath = System.IO.Path.Combine(diro.ToString() + "\\images", "default-avatar.png");
                if (File.Exists(filePath))
                {
                    BitmapImage bitimg = new BitmapImage();
                    bitimg.BeginInit();
                    bitimg.UriSource = new Uri(@"" + diro + "\\images\\default-avatar.png", UriKind.RelativeOrAbsolute);
                    bitimg.EndInit();
                    Image img = new Image();
                    img.Stretch = Stretch.Fill;
                    image3.Source = bitimg;
                }
                for (int i = 5; i < 12; i++)
                    labels[i].Content = null;
            }
        }

        private void buton9_Click(object sender, RoutedEventArgs e)
        {
            buton12.Visibility = Visibility.Visible;
            buton11.Visibility = Visibility.Collapsed;
            canvas2.Visibility = Visibility.Collapsed;
            canvas1.Visibility = Visibility.Visible;
            ThicknessAnimation ta = new ThicknessAnimation();
            //your first place
            ta.From = new Thickness(500, 0, 0, 0);
            ta.To = new Thickness(0, 0, 0, 0);
            ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            canvas1.BeginAnimation(Grid.MarginProperty, ta);
            ThicknessAnimation ta2 = new ThicknessAnimation();
            ta2.From = new Thickness(264, 83, 0, 0);
            ta2.To = new Thickness(-264, 83, 0, 0);
            ta2.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            anacanvas.BeginAnimation(Grid.MarginProperty, ta2);

        }

        private void buton11_Click(object sender, RoutedEventArgs e)
        {
            anacanvas.Visibility = Visibility.Visible;
            canvas1.Visibility = Visibility.Collapsed;
            canvas2.Visibility = Visibility.Visible;
            buton11.Visibility = Visibility.Collapsed;
            buton12.Visibility = Visibility.Collapsed;
            ThicknessAnimation ta = new ThicknessAnimation();
            ta.From = new Thickness(10, 10, 0, 0);
            ta.To = new Thickness(-1000, 10, 0, 0);
            ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            canvas2.BeginAnimation(Grid.MarginProperty, ta);
            ThicknessAnimation ta2 = new ThicknessAnimation();
            ta2.From = new Thickness(600, 83, 0, 0);
            ta2.To = new Thickness(224, 83, 0, 0);
            ta2.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            anacanvas.BeginAnimation(Grid.MarginProperty, ta2);
        }

        private void buton10_Click(object sender, RoutedEventArgs e)
        {
            buton11.Visibility = Visibility.Visible;
            buton12.Visibility = Visibility.Collapsed;
            canvas1.Visibility = Visibility.Collapsed;
            canvas2.Visibility = Visibility.Visible;
            ThicknessAnimation ta2 = new ThicknessAnimation();
            ta2.From = new Thickness(224, 83, 0, 0);
            ta2.To = new Thickness(700, 83, 0, 0);
            ta2.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            anacanvas.BeginAnimation(Grid.MarginProperty, ta2);
            ThicknessAnimation ta = new ThicknessAnimation();
            ta.From = new Thickness(-664, 0, 0, 0);
            ta.To = new Thickness(10, 10, 0, 0);
            ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            canvas2.BeginAnimation(Grid.MarginProperty, ta);
        }

        private void buton12_Click(object sender, RoutedEventArgs e)
        {
            anacanvas.Visibility = Visibility.Visible;
            canvas1.Visibility = Visibility.Visible;
            canvas2.Visibility = Visibility.Collapsed;
            buton11.Visibility = Visibility.Collapsed;
            buton12.Visibility = Visibility.Collapsed;
            ThicknessAnimation ta2 = new ThicknessAnimation();
            ta2.From = new Thickness(0, 0, 0, 0);
            ta2.To = new Thickness(1000, 0, 0, 0);
            ta2.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            canvas1.BeginAnimation(Grid.MarginProperty, ta2);
            ThicknessAnimation ta = new ThicknessAnimation();
            ta.From = new Thickness(-224, 83, 0, 0);
            ta.To = new Thickness(224, 83, 0, 0);
            ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            anacanvas.BeginAnimation(Grid.MarginProperty, ta);
        }

        private void buton7_Click(object sender, RoutedEventArgs e)
        {
            if (canokon == true)
            {
                canvas3.Visibility = Visibility.Visible;
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(149, -500, 130, 0);
                ta.To = new Thickness(149, -350, 130, 0);
                ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
                canvas3.BeginAnimation(Grid.MarginProperty, ta);
                canokon = false;
            }
            else
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(149, -450, 130, 0);
                ta.To = new Thickness(149, -600, 130, 0);
                ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
                canvas3.BeginAnimation(Canvas.MarginProperty,ta);
                canokon = true;
            }
        }

        private void buton6_Click(object sender, RoutedEventArgs e)
        {
            if (canokon2 == true)
            {
                listview1.Items.Clear();
                cFile.Close();
                cFile2.Close();
                StreamReader file = new StreamReader(@"D:/SearchMe.txt");
                string dosya = file.ReadLine();
                file.Close();
                int k = 0;
                string[] sembol = { "%" };
                string[] bolunenler = dosya.Split(sembol, StringSplitOptions.RemoveEmptyEntries);
                foreach (String word in bolunenler)
                {
                    string[] sembol2 = { "*" };
                    string[] bolunenler2 = word.Split(sembol2, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word2 in bolunenler2)
                        {
                            if (bolunenler2[k] == bolunenler2[0] && bolunenler2[k+1] == bolunenler2[1] && bolunenler2[k+3] == bolunenler2[3] && bolunenler2[k+4] == bolunenler2[4])
                            {
                                listview1.Items.Add(new Item(bolunenler2[0], bolunenler2[1],bolunenler2[4],bolunenler2[3]));
                                k++;
                            }
                        }
                        k = 0;
                }
                canvas4.Visibility = Visibility.Visible;

                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(160, 545, 0, 0);
                ta.To = new Thickness(160, 245, 0, 0);
                ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
                canvas4.BeginAnimation(Grid.MarginProperty, ta);
                canokon2 = false;
            }
            else
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(160, 245, 0, 0);
                ta.To = new Thickness(160, 545, 0, 0);
                ta.Duration = new Duration(TimeSpan.FromMilliseconds(200));
                canvas4.BeginAnimation(Canvas.MarginProperty, ta);
                canokon2 = true;
            }
          }
        }
    }