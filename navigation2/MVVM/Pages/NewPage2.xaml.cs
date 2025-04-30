using System.Collections.ObjectModel;
using navigation2.MVVM.Models;

namespace navigation2.MVVM.Pages;

public partial class NewPage2 : ContentPage
{
    private readonly Person _person;
    private readonly ObservableCollection<Person> _census;
    private CollectionView kolekcja;

    public NewPage2(Person person, ObservableCollection<Person> census , CollectionView tmp)
    {
        InitializeComponent();
        _person = person;
        _census = census;
        kolekcja = tmp;
        entryName.Text = person.name;
        entrySurname.Text = person.surname;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _person.name = entryName.Text;
        _person.surname = entrySurname.Text;
        Navigation.RemovePage(this);
        kolekcja.BindingContext = null;
        kolekcja.ItemsSource = null;
        kolekcja.BindingContext = _census;
        kolekcja.ItemsSource = _census;
    }
}