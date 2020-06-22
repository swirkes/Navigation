using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource("Navigation.Images.TurunKonservatoriokeltainentunnusRGB1200px.png");
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RoomReservations());
        }

        
    }
}
