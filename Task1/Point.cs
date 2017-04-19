using System;

namespace Task1
{
    public class Point // однонаправленный список
    {
        public byte data;
        public Point next;

        public byte Number
        {
            get { return data; }
            set
            {
                data = (byte)(value % 10);
                if (next == null)
                    next = new Point(0);
                next.Number += (byte) (value / 10);
            }
        }

        public Point(byte d)
        {
            data = d;
            next = null;
        }

        public Point this[int i]
        {
            get
            {
                var p = this;
                if (i == 0)
                    return p;
                return next?[i - 1];
            }
        }
        public int length
        {
            get
            {
                var p = this;
                int r = 0;
                while (p != null)
                {
                    r++;
                    p = p.next;
                }
                return r;
            }
        }

        public static Point operator +(Point right, Point left)
        {
            var result = new Point(0);
            for (int i = 0; i < Math.Min(left.length, right.length); i++)
            {
                result[i].Number = (byte)(right[i].Number + left[i].Number);
            }
            return result;
        }

        public Point getLast()
        {
            var p = this;
            while (p.next != null)
                p = p.next;
            return p;
        }
        public void add(byte p)
        {
            var b = getLast();
            b.next = new Point(1);
        }

        public override string ToString()
        {
            var p = this;
            string result = string.Empty;
            while (p != null)
            {
                result = p.data + result;
                p = p.next;
            }
            return result;
        }
    }
}
