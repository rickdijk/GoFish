using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Game
    {
        private string text;
        private List<string> list;
        private TextBox textProgress;

        public Game(string text, List<string> list, TextBox textProgress)
        {
            this.text = text;
            this.list = list;
            this.textProgress = textProgress;
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            throw new NotImplementedException();
        }

        public string DescribeBooks()
        {
            throw new NotImplementedException();
        }

        public string DescribePlayerHands()
        {
            throw new NotImplementedException();
        }

        public bool PlayOneRound(int selectedIndex)
        {
            throw new NotImplementedException();
        }

        public string GetWinnerName()
        {
            throw new NotImplementedException();
        }
    }
}
