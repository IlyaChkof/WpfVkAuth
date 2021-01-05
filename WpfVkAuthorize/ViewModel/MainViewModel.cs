namespace WpfVkAuthorize.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            var api = Authorize.Auth();
        }
    }
}
