using API_EV.Models_EV;
using Newtonsoft.Json;
using System.Net;

namespace API_EV;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    

    public async void EV_Button_Clicked(object sender, EventArgs e)
    {
        string cadena = Buscador.Text;
        var request = new HttpRequestMessage();
        //request.RequestUri = new Uri("https://dummyjson.com/products/");
        request.RequestUri = new Uri("https://dummyjson.com/products?brand="+cadena);
        //string texto = "https://dummyjson.com/products/" + cadena;
        //label.Text = texto;
        request.Method = HttpMethod.Get;
        request.Headers.Add("Accept", "application/json");

        var client = new HttpClient();

        HttpResponseMessage response = await client.SendAsync(request);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            String content = await response.Content.ReadAsStringAsync();
            var root = JsonConvert.DeserializeObject<Root>(content);
            var resultado = root.products;

            //var resultado = root.products;

            //Console.WriteLine(resultado);


            
            ListaDemo.ItemsSource = resultado;
        }
    }

   
}

