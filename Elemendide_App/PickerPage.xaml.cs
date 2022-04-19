using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        Picker picker;
        WebView webView;
     /* Entry Entry;*/
        StackLayout st;
        Button tagasi;
        string[] lehed = new string[4] { "https://www.tthk.ee/", "https://moodle.edu.ee/", "https://visualstudio.microsoft.com/", "https://www.sony.ee/" };
        public PickerPage()
        {
            picker = new Picker
            {
                Title = "Webilehed"
            };
            picker.Items.Add("TTHK");
            picker.Items.Add("Moodle");
            picker.Items.Add("Visual Studio");
            picker.Items.Add("Sony");

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            webView = new WebView
            {

            };
            
            tagasi = new Button
            {
                Text = "Tagasi"
            };
            tagasi.Clicked += Tagasi_Clicked;
            

            SwipeGestureRecognizer swipe = new SwipeGestureRecognizer();
            swipe.Swiped += Swipe_Swiped;
            swipe.Direction = SwipeDirection.Right;
            webView.GestureRecognizers.Add(swipe);
            st = new StackLayout { Children = { picker } };
            Content = st;
        }

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        

        private void Swipe_Swiped(object sender, SwipedEventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = lehed[4] };
        }


        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(webView!=null)
            {
                st.Children.Remove(webView);

            }
            webView = new WebView
            {
                Source = new UrlWebViewSource { Url = lehed[picker.SelectedIndex] },
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            st.Children.Add(webView);
        }
    }
} 