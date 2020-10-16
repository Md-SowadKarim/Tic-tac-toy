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
using System.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string sel_player = "_";
        public static string turn = "_";
        public string[] game_state = { "b", "l", "a", "h", "x", "_", "_", "_", "_" };
        public bool game_status = false;
        public string cur_player = null;
        Game newGame;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Tic Tac Toe with Ai";
            newGame = new Game();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[0].Equals("_"))
                {
                    game_state[0] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    iswonordraw();
                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        private void x_checked(object sender, RoutedEventArgs e)
        {
            sel_player = "x";
            turn = sel_player;
            selected_player.Content = "Selected Player: " + sel_player;
        }



        private void o_checked(object sender, RoutedEventArgs e)
        {
            sel_player = "o";
            turn = sel_player;
            selected_player.Content = "Selected Player: " + sel_player;
        }


        private void playgame(object sender, RoutedEventArgs e)
        {
            rendergame();
            
            cur_player = sel_player;
            current_player.Content = cur_player;
            newGame.gameIsOn();

            game_status = newGame.game_status;

        }

        private void rendergame()
        {
            game_state = newGame.state;
            button1.Content = game_state[0];
            button2.Content = game_state[1];
            button3.Content = game_state[2];
            button4.Content = game_state[3];
            button5.Content = game_state[4];
            button6.Content = game_state[5];
            button7.Content = game_state[6];
            button8.Content = game_state[7];
            button9.Content = game_state[8];
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[1].Equals("_"))
                {
                    game_state[1] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    iswonordraw();

                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }

        }


        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[2].Equals("_"))
                {
                    game_state[2] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    iswonordraw();
                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        private void changeTurn()
        {
            if (turn == "o")
            {
                turn = "x";
                current_player.Content = turn;
                cur_player = turn;
            }
            else
            {
                turn = "o";
                current_player.Content = turn;
                cur_player = turn;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[3].Equals("_"))
                {
                    game_state[3] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    iswonordraw();
                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[4].Equals("_"))
                {
                    game_state[4] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    iswonordraw();
                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[5].Equals("_"))
                {
                    game_state[5] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    string winstate = newGame.evluate();
                    iswonordraw();
                }
                }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[6].Equals("_"))
                {
                    game_state[6] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    iswonordraw();
                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[7].Equals("_"))
                {
                    game_state[7] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                    
                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (newGame.playerSelected(sel_player) && turn == sel_player)
            {
                if (game_state[8].Equals("_"))
                {
                    game_state[8] = sel_player;
                    newGame.updateStates(game_state);
                    rendergame();
                    changeTurn();
                    oplayer();
                   
                    iswonordraw();
                }
            }
            else
            {
                MessageBox.Show("Player Not Selected! or may be computer's turn");
            }
        }

        public void oplayer() {
            
            newGame.predict(cur_player);
            rendergame();
            changeTurn();
        }

        public void iswonordraw()
        {
            int counter = 0;
            if (newGame.isDraw())
            {
                won.Content = "Game is Draw";
                rtgame();
            }
            else
            {
                string winstate = newGame.evluate();
                if (winstate.Equals("_"))
                {
                    counter++;
                }
                else
                {
                    if (winstate.Equals("x"))
                    {
                        won.Content = "Winner is x";
                        rtgame();
                    }
                    else if (winstate.Equals("o"))
                    {
                        won.Content = "Winner is o";
                        rtgame();
                    }
                }
            }
        }

        private void resetgame(object sender, RoutedEventArgs e)
        {
            rtgame();
        }

        public void rtgame()
        {
            Thread.Sleep(1000);
            newGame = new Game();
            rendergame();
        }
    }
}
