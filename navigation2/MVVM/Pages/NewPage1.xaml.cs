using navigation2.MVVM.Models;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Windows.Input;
namespace navigation2.MVVM.Pages;
public partial class NewPage1 : ContentPage
{
	ObservableCollection<Person> census { get; set; } = new ObservableCollection<Person>();
	public NewPage1()
	{
		InitializeComponent();
        census.Add(new Person() { name = "Tralalelo", surname = "Tralala"});
        census.Add(new Person() { name = "Boneka", surname = "Ambalabu"});
        census.Add(new Person() { name = "Lirili", surname = "Larila"});
        census.Add(new Person() { name = "Frigo Camello", surname = "Buffo Fradello"});
        census.Add(new Person() { name = "IIlcacto", surname = "Hipopotamo"});
        census.Add(new Person() { name = "Fruli", surname = "Frula"});
        census.Add(new Person() { name = "Tung tung tung tung", surname = "Sahur"});
        census.Add(new Person() { name = "Tripi", surname = "Tropi"});
        census.Add(new Person() { name = "Odin din din din din dun", surname = "ma dun"});

        
        CensusDisplay.BindingContext = census;
        CensusDisplay.ItemsSource = census;
	}

    private async void CensusDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        /*
        Uri url = new Uri("https://crazycattle3d.github.io/");
        await Browser.Default.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
        */

        if (CensusDisplay.SelectedItem is Person selectedPerson)
        {
            Navigation.PushAsync(new NewPage2(selectedPerson, census, CensusDisplay));
            
        }
        CensusDisplay.SelectedItem = null; 
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
            Navigation.PushAsync(new NewPage3(census, CensusDisplay));

    }
    public ICommand Test {  get; set; } 
    
    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        var clickedItem = sender as MenuFlyoutItem;
        var contact = clickedItem?.BindingContext as Person;

            Navigation.PushAsync(new NewPage2(contact, census, CensusDisplay));

        
        CensusDisplay.SelectedItem = null;
    }
}

