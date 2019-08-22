﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer
{
    public class ActualRandom
    {
        static Random _random;
        static List<int> _items;
        public ActualRandom()
        {
            if (_random == null)
            {
                _random = new Random();
                _items = new List<int>();
            }
        }

        public int GetIt(int min, int max)
        {
            int number = 0;

            if (_items.Count == max)
                _items.Clear();

            while(_items.Contains(number))
            {
                number = _random.Next(min, max);
            }

            _items.Add(number);
            return number;
        }

        public int GetIt(int max)
        {
            return GetIt(0, max);
        }
    }
}
