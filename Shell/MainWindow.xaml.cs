
namespace Shell
{
	using System.Windows;

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			this.ContentRegion.Content = new Shell.HomeUserControl();
		}
	}
}
