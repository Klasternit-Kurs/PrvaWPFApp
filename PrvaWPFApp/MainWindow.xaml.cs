using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrvaWPFApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Osoba o = new Osoba();

		public MainWindow()
		{
			InitializeComponent();



			DataContext = o;
			BindingGroup = new BindingGroup();

			/*Binding veza = new Binding();
			veza.Source = o;
			veza.Path = new PropertyPath("Ime");
			veza.Mode = BindingMode.OneWay;

			BindingOperations.SetBinding(labela, Label.ContentProperty, veza);*/

			/*veza = new Binding();
			veza.Source = o;
			veza.Path = new PropertyPath("Ime");
			veza.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

			BindingOperations.SetBinding(unosTeksta, TextBox.TextProperty, veza);*/

		}

		private void Klik(object sender, RoutedEventArgs e)
		{
			//BindingOperations.GetBindingExpression(unosTeksta, TextBox.TextProperty).UpdateSource();

			if (!BindingGroup.CommitEdit())
			{
				MessageBox.Show("Los unos!");
			}
		}

		private void Zatvaranje(object sender, System.ComponentModel.CancelEventArgs e)
		{
			MessageBox.Show("Bye!!!!");
		}
	}

	public class Osoba
	{
		public string Ime { get; set; } = "Pera";
		public int Broj { get; set; }
	}
}
