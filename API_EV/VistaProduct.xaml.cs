using API_EV.Models_EV;

namespace API_EV.Views_EV;

public partial class VistaProduct : ContentPage
{
	public VistaProduct()

    {

        InitializeComponent();
        List<Product> products = App.ProductRepo.GetAllProducts();
        burgerList.ItemsSource = products;
        BindingContext = this;

    }
    //public void OnItemAdded(object sender, EventArgs e)
    //{
    //    Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
    //       {
    //       {"Item",new BurgerEV()}
    //   });

    //}
    public void EVActualizarLista()
    {
        List<Product> products = App.ProductRepo.GetAllProducts();
        burgerList.ItemsSource = products;
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();
        {
            EVActualizarLista();
        }
    }
    private void EVOnCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //Product product = e.CurrentSelection.FirstOrDefault() as Product;
        //if (product == null)
        //    return;
        //Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        //{
        //    {"Item",burger}
        //});
        //((CollectionView)sender).SelectedItem = null;



    }
}