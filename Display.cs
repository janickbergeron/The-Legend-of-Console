﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Display
    {
        public static char[][] MainTab = new char[16][];
        public static string[][] StringTab = new string[16][];
        public static char[][] FogTab = new char[16][];
        public static char[][] PostFogTab = new char[16][];
        public static List<string> ContextDisplayList = new List<string>();
        public static List<Board> BoardList = new List<Board>();

        public static void InitializeStringTab()
        {
            for (int i = 0; i < 16; i++)
            StringTab[i] = new string[] { "" };
        }  // Function to initialize the display array  62 Coll 16 row
        public static void InitializeGameboard1()
        {
            MainTab[0] = new char[] {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[1] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[2] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[3] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[4] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[5] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[6] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[7] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[8] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[9] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[10] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[11] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[12] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[13] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[14] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[15] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };


            // ╦ ╩ ╣ ║ ╬ ╠ ═ ╔ ╗ ╚ ╝
        }  // Function to initialize the display array  62 Coll 16 row
        public static void InitializeFogTab()
        {
            FogTab[0] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[1] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[2] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[3] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[4] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[5] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[6] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[7] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[8] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[9] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[10] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[11] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[12] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[13] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[14] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            FogTab[15] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };


            // ╦ ╩ ╣ ║ ╬ ╠ ═ ╔ ╗ ╚ ╝
        }  // Function to initialize the display array  62 Coll 16 row
        public static void InitializePostFogTab()
        {
            PostFogTab[0] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[1] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[2] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[3] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[4] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[5] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[6] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[7] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[8] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[9] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[10] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[11] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[12] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[13] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[14] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            PostFogTab[15] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };


            // ╦ ╩ ╣ ║ ╬ ╠ ═ ╔ ╗ ╚ ╝
        }  // Function to initialize the display array  62 Coll 16 row
        public static void TabLoading(Board board, char[][] Tab)
        {
                for (int i = 0; i < 63; i++)
                {
                    Tab[0][i] = board.Line0[i];
                    Tab[1][i] = board.Line1[i];
                    Tab[2][i] = board.Line2[i];
                    Tab[3][i] = board.Line3[i];
                    Tab[4][i] = board.Line4[i];
                    Tab[5][i] = board.Line5[i];
                    Tab[6][i] = board.Line6[i];
                    Tab[7][i] = board.Line7[i];
                    Tab[8][i] = board.Line8[i];
                    Tab[9][i] = board.Line9[i];
                    Tab[10][i] = board.Line10[i];
                    Tab[11][i] = board.Line11[i];
                    Tab[12][i] = board.Line12[i];
                    Tab[13][i] = board.Line13[i];
                    Tab[14][i] = board.Line14[i];
                    Tab[15][i] = board.Line15[i];
                }
        } //Function to load Board from BoardData File
        public static void GameboardOptimisation()
        {
            for (int i = 0; i < 16; i++)
            {
                string str = new string(MainTab[i]);
                Display.StringTab[i][0] = str;
            }
        } //Function for display optimisation
        public static void Gameline(int x)
        {
            foreach (string n in StringTab[x]) 
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }    //Function to draw one line of the gameboard.
        public static void Gameboard()
        {
            Console.Clear();
            for (int i = 0; i < 16; i++)
            {
                Gameline(i);
            }
            ContextDisplay();
        }   //Function to draw the gameboard.
        public static void BoardLoading(int boardNumber, char[][] charTab)
        {
            if (boardNumber == 0)
            {
                Player.isPlayerInTown = true;
                TabLoading(Board.GenerateBoard(boardNumber, BoardList),charTab);
            }
        }  //Function to load a given board
        public static void RandomBoardLoading(char[][] charTab)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(2,3);
            Player.isPlayerInTown = false;
            TabLoading(Board.GenerateBoard(randomNumber, BoardList),charTab);
        } //Function to load a random board
        public static void FogOfWarProcess(Coordinate playerCoord)
        {
            int x = playerCoord.X;
            int y = playerCoord.Y;

            for(int i = x-3;i <= x+3; i++)
            {
                PostFogTab[y][i] = FogTab[y][i];
            }
        }
        public static void TitleScreen()
        {
            Console.WriteLine(@" .____                                    .___         _____  _________                            .__");
            Console.WriteLine(@" |    |    ____   ____   ____   ____    __| _/   _____/ ____\ \_   ___ \  ____   ____   __________ |  |  ____ ");
            Console.WriteLine(@" |    |  _/ __ \ / ___\_/ __ \ /    \  / __ |   /  _ \   __\  /    \  \/ /  _ \ /    \ /  ___/  _ \|  | _/ __ \");
            Console.WriteLine(@" |    |__\  ___// /_/  >  ___/|   |  \/ /_/ |  (  <_> )  |    \     \___(  <_> )   |  \\___ (  <_> )  |_\  ___/");
            Console.WriteLine(@" |_______ \___  >___  / \___  >___|  /\____ |   \____/|__|     \______  /\____/|___|  /____  >____/|____/\___  >");
            Console.WriteLine(@"         \/   \/_____/      \/     \/      \/                         \/            \/     \/                \/ ");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        } //Function to display the Title Screen.
        public static void ContextDisplay()
        {
             string menuString = "╔═════════════════════════════════════════════════════════════╗ \n";                
                foreach (string n in ContextDisplayList)
                {
                   menuString += n + "\n";
                }
                   menuString += "╚═════════════════════════════════════════════════════════════╝";
            Console.WriteLine(menuString);
            Console.WriteLine("Space = Interact. I = Inventory. C = Character's statistics.");
        } //Function to draw the Context Display.
        public static void InitializeContextDisplay()
        {
            for (int i = 0; i < 4; i++)
            {
                ContextDisplayList.Clear();
            }
            for (int i = 0; i < 4; i++)
            {
                ContextDisplayList.Add("║                                                             ║");
            }
        } //Function to initialize the Context Display.
        public static void CombatLogDisplay()
        {
            Console.Clear();
                    string menuString = "╔════════════════════════════════════╦═══════════════════════════════════╦══════════════════════════════╗ \n";
            menuString += String.Format("║ Name: {0,-10}       {1,-3}/ {2,-3}HP  ║ Enemy: {3,-10}     {4,-3}/ {5,-3}HP  ║          Equipments          ║\n", Program.player.Name, Program.player.Health, Program.player.MaxHealth, Program.monster.Name, Program.monster.Health, Program.monster.MaxHealth) +
                          String.Format("║ Level: {0,-3}             Armor: {1,-3}  ║ Level: {2,-5}          Armor: {3,-3}  ║ Weapon: {4,-17}    ║\n", Program.player.Level, Program.player.Armor, Program.monster.Level, Program.monster.Armor, Inventory.EquippedWeapon[0].Name) +
                          String.Format("║ Damage: {0,3}-{1,-3}                    ║ Damage: {2,3}-{3,-3}                   ║ Off-Hand: {4,-17}  ║\n", Program.player.MinDamage, Program.player.MaxDamage, Program.monster.MinDamage, Program.monster.MaxDamage, Inventory.EquippedOffHand[0].Name) +
                          String.Format("║ Defense: {0,-5}                     ║ Defense: {1,-5}                    ║ Chest: {2,-17}     ║ \n", Program.player.Defense, Program.monster.Defense, Inventory.EquippedChest[0].Name); 
             menuString+= String.Format("║                                    ║                                   ║ Pants: {0,-17}     ║ \n", Inventory.EquippedPants[0].Name) +
                          String.Format("║                                    ║                                   ║ Gloves: {0,-17}    ║\n", Inventory.EquippedGloves[0].Name) +
                          String.Format("║                                    ║                                   ║ Boots: {0, -17}     ║\n",Inventory.EquippedBoots[0].Name) +
                          String.Format("║                                    ╠═══════════════════════════════════╣ Ring: {0,-17}      ║\n", Inventory.EquippedRing[0].Name) +
                          String.Format("║                                    ║ Next Action : {0,-10}          ║ Ring: {1,-17}      ║\n", Combat.monsterAction, Inventory.EquippedRing[1].Name) +
                                        "╠════════════════════════════════════╩═══════════════════════════════════╬══════════════════════════════╝\n";
            foreach(string n in Combat.CombatLog)
            {
                menuString += n + "\n";
            }
            menuString += "╚════════════════════════════════════════════════════════════════════════╝";
            Console.WriteLine(menuString);
        } //function to display the combat interface.
        public static void ShowInventory()
        {
            InventoryDisplay();
            Input.InventoryInput();
        } //Function to show the inventory + user input
        public static void InventoryDisplay()
        {
            Console.Clear();
            int index = 0;
            string menuString = "╔═════════════════════════════════════════════════════════════════╗ ╔═════════════╗ \n" +
                  String.Format("║                            Inventory                            ║ ║ Gold: {0,-6}║ \n", Program.player.Gold) +
                                "╠═════════════════════════════════════════════════════════════════╣ ╚═════════════╝ \n" +
                                "║       Weapon                                                    ║ \n" +
                                "╠══════════════════════╦══════════════════════════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryWeaponList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ \n", index, item.Name, item.Defense, item.Health, item.MinDamage,item.MaxDamage);
            }
                  menuString += "╠══════════════════════╩══════════════════════════════════════════╣ \n" +
                                "║       Armor                                                     ║ \n" +
                                "╠══════════════════════╦══════════════════════════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryArmorList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║\n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage);
            }
                  menuString += "╠══════════════════════╩══════════════════════════════════════════╣ \n" +
                                "║     Consumable                                                  ║ \n" +
                                "╠══════════════════════╦══════════════════════════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryConsumList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║\n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage);
            }
                  menuString += "╚══════════════════════╩══════════════════════════════════════════╝";
            Console.WriteLine(menuString);
            
        } //Function to display the inventory.
        public static void EquipmentDisplay()
        {
            Console.Clear();
                            string menuString = "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╗\n";
                                  menuString += "║         Statistics          ║                              Equipments                               ║\n" +
                                                "╠═════════════════════════════╬════════════════════════════╦══════════════════════════════════════════╣\n" +
                                  String.Format("║ Name: {0,-10}            ║ Weapon: {1,-17}  ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║\n", Program.player.Name, Inventory.EquippedWeapon[0].Name, Inventory.EquippedWeapon[0].Defense, Inventory.EquippedWeapon[0].Health, Inventory.EquippedWeapon[0].MinDamage, Inventory.EquippedWeapon[0].MaxDamage) +
                                  String.Format("║ Level: {0,-3}                  ║ Off-Hand: {1,-17}║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║\n", Program.player.Level, Inventory.EquippedOffHand[0].Name, Inventory.EquippedOffHand[0].Defense, Inventory.EquippedOffHand[0].Health, Inventory.EquippedOffHand[0].MinDamage, Inventory.EquippedOffHand[0].MaxDamage) +
                                  String.Format("║ Exp: {0,6} / 100           ║ Chest: {1,-17}   ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ \n", Program.player.Experience, Inventory.EquippedChest[0].Name, Inventory.EquippedChest[0].Defense, Inventory.EquippedChest[0].Health, Inventory.EquippedChest[0].MinDamage, Inventory.EquippedChest[0].MaxDamage);
                    menuString += String.Format("║ Health: {0,-5}               ║ Pants: {1,-17}   ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ \n", Program.player.Health, Inventory.EquippedPants[0].Name, Inventory.EquippedPants[0].Defense, Inventory.EquippedPants[0].Health, Inventory.EquippedPants[0].MinDamage, Inventory.EquippedPants[0].MaxDamage) +
                                  String.Format("║ Damage: {0,3}-{1,-3}             ║ Gloves: {2,-17}  ║ Defense: {3,-3} Health: {4,-3} Damage: {5,3}-{6,-3} ║\n", Program.player.MinDamage, Program.player.MaxDamage, Inventory.EquippedGloves[0].Name, Inventory.EquippedGloves[0].Defense, Inventory.EquippedGloves[0].Health, Inventory.EquippedGloves[0].MinDamage, Inventory.EquippedGloves[0].MaxDamage) +
                                  String.Format("║ Defense: {0,-5}              ║ Boots: {1, -17}   ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║\n", Program.player.Defense, Inventory.EquippedBoots[0].Name, Inventory.EquippedBoots[0].Defense, Inventory.EquippedBoots[0].Health, Inventory.EquippedBoots[0].MinDamage, Inventory.EquippedBoots[0].MaxDamage) +
                                  String.Format("║                             ║ Ring: {0,-17}    ║ Defense: {1,-3} Health: {2,-3} Damage: {3,3}-{4,-3} ║\n", Inventory.EquippedRing[0].Name, Inventory.EquippedRing[0].Defense, Inventory.EquippedRing[0].Health, Inventory.EquippedRing[0].MinDamage, Inventory.EquippedRing[0].MaxDamage) +
                                  String.Format("║                             ║ Ring: {0,-17}    ║ Defense: {1,-3} Health: {2,-3} Damage: {3,3}-{4,-3} ║\n", Inventory.EquippedRing[1].Name, Inventory.EquippedRing[1].Defense, Inventory.EquippedRing[1].Health, Inventory.EquippedRing[1].MinDamage, Inventory.EquippedRing[1].MaxDamage) +
                                                "╚═════════════════════════════╩════════════════════════════╩══════════════════════════════════════════╝\n";
            Console.WriteLine(menuString);
            Console.ReadKey();
        }   //Function to display the equipment + stats.
        public static void InventorySellDisplay()
        {
            Console.Clear();
            int index = 0;
            int itemValue;
            string menuString = "╔════════════════════════════════════════════════════════════════════════════════╗ \n" +
                                "║                                    Inventory                                   ║ \n" +
                                "╠════════════════════════════════════════════════════════════════════════════════╣ \n" +
                                "║       Weapon                                                                   ║ \n" +
                                "╠══════════════════════╦══════════════════════════════════════════╦══════════════╣ \n";
            foreach (Item item in Inventory.InventoryWeaponList)
            {
                index++;
                itemValue = item.GoldValue / 4;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ Gold: {6,-6} ║ \n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage, itemValue);
            }
            menuString += "╠══════════════════════╩══════════════════════════════════════════╩══════════════╣ \n" +
                          "║       Armor                                                                    ║ \n" +
                          "╠══════════════════════╦══════════════════════════════════════════╦══════════════╣ \n";
            foreach (Item item in Inventory.InventoryArmorList)
            {
                index++;
                itemValue = item.GoldValue / 4;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ Gold: {6,-6} ║\n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage, itemValue);
            }
            menuString += "╠══════════════════════╩══════════════════════════════════════════╩══════════════╣ \n" +
                          "║     Consumable                                                                 ║ \n" +
                          "╠══════════════════════╦══════════════════════════════════════════╦══════════════╣ \n";
            foreach (Item item in Inventory.InventoryConsumList)
            {
                index++;
                itemValue = item.GoldValue / 4;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ Gold: {6,-6} ║\n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage, itemValue);
            }
            menuString += "╚══════════════════════╩══════════════════════════════════════════╩══════════════╝";
            Console.WriteLine(menuString);

        }  //Function to display the inventory with gold value.
        public static void TitleMenuDisplay()
        {
            Console.Clear();
            string menuString = "╔═════════════════════╗\n" +
                                "║      Main Menu      ║\n" +
                                "╠═════════════════════╣\n" +
                                "║                     ║\n" +
                                "║   1 - New Game      ║\n" +
                                "║   2 - Load Game     ║\n" +
                                "║   3 - Quit          ║\n" +
                                "║                     ║\n" +
                                "╚═════════════════════╝";
            Console.WriteLine(menuString);
            Input.TitleMenuInput();
        }  //Function to display the title menu.
        public static void ArmorerDisplay()
        {
            Console.Clear();
            int index = 0;
             string menuString = "╔════════════════════════════════════════════════════════════════════════════════╗ ╔═════════════╗\n" +
                   String.Format("║                                   Armorer's Shack                              ║ ║ Gold: {0,-6}║ \n", Program.player.Gold) +
                                 "╠══════════════════════╦══════════════════════════════════════════╦══════════════╣ ╚═════════════╝\n";
            foreach (Item item in Merchant.ArmorerList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ Gold: {6,-6} ║  \n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage, item.GoldValue);
            }
            menuString += "╚══════════════════════╩══════════════════════════════════════════╩══════════════╝";
            Console.WriteLine(menuString);
            
        }  //Function to display the armorer's shop.
        public static void BlacksmithDisplay()
        {
            Console.Clear();
            int index = 0;
            string menuString = "╔════════════════════════════════════════════════════════════════════════════════╗ ╔═════════════╗\n" +
                  String.Format("║                                 Blacksmith's Workshop                          ║ ║ Gold: {0,-6}║ \n", Program.player.Gold) +
                                "╠══════════════════════╦══════════════════════════════════════════╦══════════════╣ ╚═════════════╝\n";
            foreach (Item item in Merchant.BlacksmithList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ Gold: {6,-6} ║  \n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage, item.GoldValue);
            }
            menuString += "╚══════════════════════╩══════════════════════════════════════════╩══════════════╝";
            Console.WriteLine(menuString);

        } //Function to display the blacksmith's shop.
        public static void AlchemistDisplay()
        {
            Console.Clear();
            int index = 0;
            string menuString = "╔════════════════════════════════════════════════════════════════════════════════╗ ╔═════════════╗\n" +
                  String.Format("║                                    Alchemist's Lab                             ║ ║ Gold: {0,-6}║ \n", Program.player.Gold) +
                                "╠══════════════════════╦══════════════════════════════════════════╦══════════════╣ ╚═════════════╝\n";
            foreach (Item item in Merchant.AlchemistList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║ Defense: {2,-3} Health: {3,-3} Damage: {4,3}-{5,-3} ║ Gold: {6,-6} ║  \n", index, item.Name, item.Defense, item.Health, item.MinDamage, item.MaxDamage, item.GoldValue);
            }
            menuString += "╚══════════════════════╩══════════════════════════════════════════╩══════════════╝";
            Console.WriteLine(menuString);

        } //Function to display the alchemist's shop.

    }
}
