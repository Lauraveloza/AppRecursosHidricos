using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RecursoshidricosAplicacion
{
    public partial class MainPage : ContentPage
    {
                  public App()

        {
            //Consumption Alarm
            Mainpage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center
                         Children = {
                             new Label {
                                 XAlign = TextAlignment.Center,
                                 Text = "Welcome to consum0ption alarm!"

                             }

                         }


                }
            };


    }
        protected override void OnStart()
        {
            //Mandle when your app starts
        }
        protected override void OnSleep()


