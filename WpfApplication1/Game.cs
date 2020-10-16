using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Game
    {

        public string[] state = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };
        public string[,] nstate;
        public char[,] cnstate;
        public bool game_status = false;
        public bool draw = false;
        public Game()
        {
            nstate = new string[3, 3];
            cnstate = new char[3, 3];

        }

        public void updateStates(string[] newstate)
        {
            state = newstate;

        }
        public void gameIsOn()
        {
            this.game_status = true;
        }

        public bool playerSelected(string sel_player)
        {
            if (sel_player.Equals("_"))
            {
                return false;
            }
            return true;
        }

        public void tochararray()
        {
           for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    cnstate[i, j] = char.Parse(nstate[i, j]);
                }
            }
        }
        public void predict(string cur_player)
        {
            convertState();
            tochararray();

            Move bestMove = new Move();
            GFG gfg = new GFG();
            bestMove = gfg.findBestMove(cnstate);
            if (bestMove.row == -1 && bestMove.col == -1)
            {
                draw = true;
            }
            else
            {
                nstate[bestMove.row, bestMove.col] = cur_player;
              
            }

            convertnState();

            
        }

        public bool isDraw()
        {
            return draw;
        }

        public void convertnState()
        {
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    state[k] = nstate[i, j];
                    k++;
                }
            }
        }
        public void convertState()
        {
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nstate[i, j] = state[k];
                    k++;
                }

            }
        }


        public bool hasMovesLeft()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(nstate[i, j].Equals("_"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string evluate()
        {
            //checking rows for victory
            convertState();
            for (int row = 0; row < 3; row++)
            {
                if (nstate[row, 0] == nstate[row, 1] && nstate[row, 1] == nstate[row, 2])
                {
                    if (nstate[row, 0].Equals("x"))
                    {
                        return "x";
                    }
                    else if (nstate[row, 0].Equals("o"))
                    {
                        return "o";
                    }
                    else
                    {
                        return "draw";
                    }
                }
            }

            //checking for column for victory
            for (int col = 0; col < 3; col++)
            {
                if (nstate[0, col] == nstate[1, col] &&
                    nstate[1, col] == nstate[2, col])
                {
                    if (nstate[0, col].Equals("x"))
                    {
                        return "x";
                    }

                    else if (nstate[0, col].Equals("o"))
                    {
                        return "o";
                    }
                }
            }

            if (nstate[0, 0] == nstate[1, 1] && nstate[1, 1] == nstate[2, 2])
            {
                if (nstate[0, 0] == "x")
                {
                    return "x";
                }
                else if (nstate[0, 0] == "o")
                {
                    return "o";
                }
            }

            if (nstate[0, 2] == nstate[1, 1] && nstate[1, 1] == nstate[2, 0])
            {
                if (nstate[0, 2] == "x")
                {
                    return "x";
                }
                else if (nstate[0, 2] == "o")
                {
                    return "o";
                }
            }

            return "_";

        }

    }
}
