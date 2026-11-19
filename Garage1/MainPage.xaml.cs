namespace Garage1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Здесь логика фильтрации по мере ввода (если нужно)
            string searchText = e.NewTextValue;
            // Например: FilterList(searchText);
        }

        private void OnSearchCompleted(object sender, EventArgs e)
        {
            // Вызывается при нажатии "Поиск" на клавиатуре
            string searchText = SearchEntry.Text;
            // Например: ExecuteSearch(searchText);
        }

        private void OnMenuTapped(object sender, TappedEventArgs e)
        {
            // Логика открытия фильтров или меню
        }

    }
}
