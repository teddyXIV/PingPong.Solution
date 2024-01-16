using System.Collections.Generic;
using System.Globalization;

namespace PingPong.Models
{
    public class PingPongCalc
    {
        private int _userInt;
        public int UserInt
        {
            get { return _userInt; }
            set { _userInt = value; }
        }

        public PingPongCalc(int userInt)   //Optionalish constructor
        {
            _userInt = userInt;
        }

        public List<int> CreateListFromUserInt()
        {
            List<int> pingPongList = new List<int>();
            for (int index = 1; index <= _userInt; index++)
            {
                pingPongList.Add(index);
            }
            return pingPongList;
        }
        public List<object> DivisibleBy3Check(List<object> pingPongList)
        {
            for (int index = 0; index < pingPongList.Count; index++)
            {
                if (pingPongList[index] is int number && number % 3 == 0)
                {
                    pingPongList[index] = "ping";
                }
            }
            return pingPongList;
        }
        public List<object> DivisibleBy5Check(List<object> pingPongList)
        {
            for (int index = 0; index < pingPongList.Count; index++)
            {
                if (pingPongList[index] is int number && number % 5 == 0)
                {
                    pingPongList[index] = "pong";
                }
            }
            return pingPongList;
        }

    }
}

