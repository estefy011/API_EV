using API_EV.Data_Ev;

namespace API_EV;

public partial class App : Application
{
   
        public static Data_EV ProductRepo { get; private set; }

        public App(Data_EV repoEV)
        {
            InitializeComponent();

            MainPage = new AppShell();

            ProductRepo = repoEV;
        }
    
}
