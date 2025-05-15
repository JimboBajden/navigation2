using navigation2.MVVM.Models;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.Windows.Input;
using System.Linq;
namespace navigation2.MVVM.Pages;
public partial class NewPage1 : ContentPage
{
	ObservableCollection<Person> census { get; set; } = new ObservableCollection<Person>();
    List<Person> tmp = new List<Person>();

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
        census.Add(new Person() { name = "Odin din din din din dun", surname = "Odin din din din din din Madun"});

        
        CensusDisplay.BindingContext = census;
        CensusDisplay.ItemsSource = census;
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

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        foreach(Person skibidi in tmp)
        {
            census.Remove(skibidi);
        }
        tmp.Clear();
    }

    private void CensusDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selection = ((CollectionView)sender);
        tmp = selection.SelectedItems.Cast<Person>().ToList();
        

    }
}

