using Android.Hardware.Camera2.Params;

namespace Garage1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }
}
