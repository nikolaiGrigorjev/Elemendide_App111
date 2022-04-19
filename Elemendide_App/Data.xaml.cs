using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Data : ContentPage
    {
        TimePicker picker;
        Label lbl;
        ImageButton img;
        Image img1, img2, img3, img4, img5, img6;
        public Data()
        {
            lbl = new Label()
            {
                Text = "AjaPlaan"
            };


            picker = new TimePicker()
            {

            };

            picker.PropertyChanged += Picker_PropertyChanged;

            img = new ImageButton
            {
                Source = "gelik.jpg"
            };
            img.Clicked += Img_Clicked;



            this.Content = new StackLayout { Children = { picker, img, img1, img2, img3, img4, img5, img6, lbl } };




        }

        private void Img_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Hea Pilt", "Gelik", "Jah!");
        }

        private void Picker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                /* TimeSpan selctTime = picker.Time;*/
                var time = picker.Time.Hours;

                if (time == 7)
                {
                    lbl.Text = "Kell 7 hommikul";
                    img1 = new Image { Source = "_7.png" };
                    img.IsVisible = false;
                }
                else if (time == 8)
                {
                    lbl.Text = "Kell 8 hommikul";
                    img2 = new Image { Source = "_8.jpg" };
                    img1.IsVisible = false;
                }
                else if (time == 9)
                {
                    lbl.Text = "Kell 9 hommikul";
                    img3 = new Image { Source = "_9.jpg" };
                    img2.IsVisible = false;
                }
                else if (time == 10)
                {
                    lbl.Text = "Kell 10 hommikul";
                    img4 = new Image { Source = "_10.jpg" };
                    img3.IsVisible = false;
                }
                else if (time == 11)
                {
                    lbl.Text = "Kell 11 hommikul";
                    img5 = new Image { Source = "_11.jpg" };
                    img4.IsVisible = false;
                }
                else if (time == 12)
                {
                    lbl.Text = "Kell 12 hommikul";
                    img6 = new Image { Source = "_12.jpg" };
                    img5.IsVisible = false;
                }

            }
        }
    }
}