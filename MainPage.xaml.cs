using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace ChessWithKI {
	/// <summary>
	/// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
	/// </summary>
	public sealed partial class MainPage : Page {

		private Button[,] gameFieldButtons = new Button[8, 8];

		public MainPage() {
			this.InitializeComponent();
			BitmapImage tempImage = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Chess_kll45.svg/2000px-Chess_kll45.svg.png"));
			for(int x = 0; x < 8; x++) {
				for(int y = 0; y < 8; y++) {
					Button b = new Button();
					Image i = new Image();
					i.Source = tempImage;
					b.Content = i;
					b.Width = 256;
					b.Height = 256;
					b.Margin = new Thickness(4);
					gameFieldButtons[x, y] = b;
					Grid.SetColumn(b, x);
					Grid.SetRow(b, y);
					gameFieldGrid.Children.Add(b);
				}
			}
		}
	}
}
