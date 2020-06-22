using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class RoomReservations : ContentPage
    {
        public RoomReservations()
        {
            InitializeComponent();

            Browser.Source = "https://script.google.com/a/macros/turunkonservatorio.fi/s/AKfycbyleLfNfSJKx0YX1VAvC7WgBE2ARZJZrBpg3iyDeeMKJem0FTo/exec";
            
        }
    }
}
