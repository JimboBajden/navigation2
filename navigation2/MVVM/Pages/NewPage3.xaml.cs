using System.Collections.ObjectModel;
using navigation2.MVVM.Models;
namespace navigation2.MVVM.Pages;

public partial class NewPage3 : ContentPage
{

    private  ObservableCollection<Person> _census;
    private CollectionView kolekcja;
    public NewPage3( ObservableCollection<Person> census, CollectionView tmp)
    {
        _census = census;
        kolekcja = tmp;
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Person TMP = new Person();
        TMP.name = name.Text;
        TMP.surname = surname.Text;
        _census.Add( TMP );
        kolekcja.ItemsSource = null;
        kolekcja.BindingContext = null;

        kolekcja.ItemsSource = _census;
        kolekcja.BindingContext = _census;
        Navigation.RemovePage(this);

    }
}
