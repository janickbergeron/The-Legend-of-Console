using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace The_Legend_of_Console
{

    public class Board
    {
        public string Line0;
        public string Line1;
        public string Line2;
        public string Line3;
        public string Line4;
        public string Line5;
        public string Line6;
        public string Line7;
        public string Line8;
        public string Line9;
        public string Line10;
        public string Line11;
        public string Line12;
        public string Line13;
        public string Line14;
        public string Line15;

        public Board(string line0, string line1, string line2, string line3, string line4, string line5, string line6, string line7, string line8, string line9, string line10, string line11, string line12, string line13, string line14, string line15)
        {
            Line0 = line0;
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            Line4 = line4;
            Line5 = line5;
            Line6 = line6;
            Line7 = line7;
            Line8 = line8;
            Line9 = line9;
            Line10 = line10;
            Line11 = line11;    
            Line12 = line12;
            Line13 = line13;
            Line14 = line14;
            Line15 = line15;
        }
        public static Board GenerateBoard(int x, List<Board> list)
        {
            Board board = new Board(
                list[x].Line0,
                list[x].Line1,
                list[x].Line2,
                list[x].Line3,
                list[x].Line4,
                list[x].Line5,
                list[x].Line6,
                list[x].Line7,
                list[x].Line8,
                list[x].Line9,
                list[x].Line10,
                list[x].Line11,
                list[x].Line12,
                list[x].Line13,
                list[x].Line14,
                list[x].Line15);
            return board;
        }
        public static List<Board> GetBoardData() 
        {
            var CurrentDirectory = Environment.CurrentDirectory;
            string path = $@"\Data\BoardData.json";
            string fullPath = CurrentDirectory + path;
            StreamReader r = new StreamReader(fullPath);
            string jsonString = r.ReadToEnd();
            List<Board> boardList = JsonConvert.DeserializeObject<List<Board>>(jsonString);
            return boardList;
        } // Function to fetch the Board Data File.
        
    }
}
