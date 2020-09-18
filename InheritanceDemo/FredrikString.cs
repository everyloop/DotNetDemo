using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class FredrikStringEnumerator : IEnumerator
    {
        private string text = "";
        private int count = -1;

        public FredrikStringEnumerator(string text)
        {
            this.text = text;
        }

        public object Current
        {
            get
            {
                return text[count].ToString();
            }
        }

        public bool MoveNext()
        {
            if (count < text.Length - 1)
            {
                count++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
        }
    }

    class FredrikString : IEnumerable
    {
        private string text;

        public FredrikString(string text)
        {
            this.text = text;
        }

        public IEnumerator GetEnumerator()
        {
            return new FredrikStringEnumerator(text);
        }

    }
}

