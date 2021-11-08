using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlternateRowColorSample
{
    public partial class MainPage : ContentPage
    {
        public List<string> Items { get; set; } = new List<string>()
        {
            "R2-D2",
            "3CPO",
            "Luke Skywalker",
            "Darth Vader",
            "Han Solo",
            "Chewbacca",
            "Yoda",
            "Obi-Wan Kenobi"
        };

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            Switch switchControl = sender as Switch;

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                if (switchControl.IsToggled)
                {
                    mergedDictionaries.Add(new DarkTheme());
                }
                else
                {
                    mergedDictionaries.Add(new LightTheme());
                }
            }
        }
    }
}