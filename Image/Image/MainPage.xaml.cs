using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Image
{
    public partial class MainPage : ContentPage
    {
        private Color _buttonColor;
        private Color _buttonColor2;
        public MainPage()
        {
            InitializeComponent();
            _buttonColor = ColorButton.BackgroundColor;
            _buttonColor2 = ColorButton2.BackgroundColor;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            ColorBoxView.BackgroundColor = Color.DeepPink;
        }

        private void Button_Released(object sender, EventArgs e)
        {
            ColorBoxView.BackgroundColor = _buttonColor;
        }
        private void Button_Released2(object sender, EventArgs e)
        {
            ColorBoxView.BackgroundColor = _buttonColor2;
        }

    }
}
