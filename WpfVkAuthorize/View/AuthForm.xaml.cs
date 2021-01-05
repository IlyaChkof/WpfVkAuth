using System.Windows;
using VkNet.Model;

namespace WpfVkAuthorize.View
{
	/// <summary>
	/// Логика взаимодействия для AuthForm.xaml
	/// </summary>
	public partial class AuthForm : Window
	{
		public AuthorizationResult Auth { get; set; }

		public string Tfa { get; set; }

		public AuthForm()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
