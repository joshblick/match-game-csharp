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

namespace match_game_csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐕", "🐕",
                "🦘", "🦘",
                "🦔", "🦔",
                "🦎", "🦎",
                "🐊", "🐊",
                "🐍", "🐍",
                "🐳","🐳",
                "🦦", "🦦",
            };

            Random randomGenerator = new Random();
            int current = 0;
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int numberEmoji = animalEmoji.Count;
                int chosenEmoji = randomGenerator.Next(numberEmoji);
                string nextEmoji = animalEmoji[chosenEmoji];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(chosenEmoji);
                current += 1;
            }
        }
    }
}
