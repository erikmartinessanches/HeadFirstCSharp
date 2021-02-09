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
using EnumsAndCollections;

namespace Decks_of_cards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Resources["rightDeck"] is Deck rightDeck)
            {
                rightDeck.Clear();
            }
        }

        private void MoveCard(bool leftToRight)
        {
            if ((Resources["rightDeck"] is Deck rightDeck) && (Resources["leftDeck"] is Deck leftDeck))
            {
                if (leftToRight)
                {
                    if (leftDeckListBox.SelectedItem is Card card)
                    {
                        leftDeck.Remove(card);
                        rightDeck.Add(card);
                    }
                }
                else
                {
                    if (rightDeckListBox.SelectedItem is Card card)
                    {
                        rightDeck.Remove(card);
                        leftDeck.Add(card);
                    }
                }
            }
        }

        private void shuffleLeftDeck_Click(object sender, RoutedEventArgs e)
        {
            if (Resources["leftDeck"] is Deck leftDeck)
            {
                leftDeck.Shuffle();
            }
        }

        private void resetLeftDeck_Click(object sender, RoutedEventArgs e)
        {
            if (Resources["leftDeck"] is Deck leftDeck)
            {
                leftDeck.Reset();
            }
        }

        private void clearRightDeck_Click(object sender, RoutedEventArgs e)
        {
            if (Resources["rightDeck"] is Deck rightDeck)
            {
                rightDeck.Clear();
            }
        }

        private void sortRightDeck_Click(object sender, RoutedEventArgs e)
        {
            if (Resources["rightDeck"] is Deck rightDeck)
            {
                rightDeck.Sort();
            }
        }

        private void leftDeckListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MoveCard(true);
        }

        private void rightDeckListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MoveCard(false);
        }

        private void leftDeckListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MoveCard(true);
            }
        }

        private void rightDeckListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MoveCard(false);
            }
        }
    }
}
