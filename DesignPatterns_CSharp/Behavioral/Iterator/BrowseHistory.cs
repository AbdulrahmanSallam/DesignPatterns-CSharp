using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Iterator
{
    internal class BrowseHistory
    {
        public List<string> Urls { get; } = new ();

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            var lastUrl = Urls.Last();
            Urls.RemoveAt(Urls.Count - 1);

            return lastUrl;
        }


        internal class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index = 0;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public string Current()
            {
                return _history.Urls[_index];
            }

            public bool HasNext()
            {
                return _index < _history.Urls.Count;
            }

            public void Next()
            {
               _index++;
            }



        }
    }
}
