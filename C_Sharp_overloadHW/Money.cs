using System;

namespace C_Sharp_overloadHW
{
    internal class Money
    {
        private int gr { get; set; }
        private int kop { get; set; }
        // Constructors
        public Money()
        {
            gr = 0;
            kop = 0;
        }
        public Money(int gr, int kop)
        {
            this.gr = gr;
            this.kop = kop;
        }
        //Methods
        public override string ToString()
        {
            return $"{gr} гр. и {kop} коп.";
        }
        //overloading
        public static Money operator +(Money a, Money b)
        {
            int total = (a.gr + b.gr) * 100 + (a.kop + b.kop);
            return new Money(total / 100, total % 100);
        }
        public static Money operator -(Money a, Money b)
        {
            if (a.gr - b.gr < 0)
            {
                Console.WriteLine("Error");
                return new Money(0, 0);
            }
            int total = (a.gr - b.gr) * 100 + (a.kop - b.kop);
            return new Money(total / 100, total % 100);
        }
        public static Money operator *(Money a, int b)
        {
            int total = (a.gr * 100 + a.kop) * b;
            return new Money(total / 100, total % 100);
        }
        public static Money operator /(Money a, int b)
        {
            try
            {
                int total = (a.gr * 100 + a.kop) / b;
                return new Money(total / 100, total % 100);

            }
            catch (DivideByZeroException)
            {
                
                Console.WriteLine("Делить на нуль нехорошо!");
                return new Money(a.gr, a.kop);
            }
        }
        public static Money operator ++(Money a)
        {
            a.kop += 1;
            if (a.kop >= 100)
            {
                a.gr += a.kop / 100;
                a.kop = a.kop % 100;
            }
            return new Money(a.gr, a.kop);
        }
        public static Money operator --(Money a)
        {
            if (a.kop == 0)
            {
                a.gr -= 1;
                a.kop = 100 - 1;
            }
            else a.kop -= 1;

            return new Money(a.gr, a.kop);
        }
        public static bool operator >(Money a, Money b)
        {
            if (a.gr.CompareTo(b.gr) < 0)
                return false;
            else if (a.gr.CompareTo(b.gr) > 0)
                return true;
            else
            {
                if (a.kop.CompareTo(b.kop) > 0)
                    return true;
                else return false;
            }
        }
        public static bool operator <(Money a, Money b)
        {
            if (a.gr.CompareTo(b.gr) < 0)
                return true;
            else if (a.gr.CompareTo(b.gr) > 0)
                return false;
            else
            {
                if (a.kop.CompareTo(b.kop) < 0)
                    return true;
                else return false;
            }
        }
        public static bool operator ==(Money a, Money b)
        {
            if (a.gr.Equals(b.gr) && (a.kop.Equals(b.kop)))
                return true;
            else return false;
        }
        public static bool operator !=(Money a, Money b)
        {
            if (a.gr.Equals(b.gr) && (a.kop.Equals(b.kop)))
                return false;
            else return true;
        }
        public bool Equals(Money a)
        {
            if (a == null)
                return false;

            return a.gr == this.gr && a.kop == this.kop;
        }

        public override int GetHashCode()
        {
            int hashCode = -2074480135;
            hashCode = hashCode * -1521134295 + gr.GetHashCode();
            hashCode = hashCode * -1521134295 + kop.GetHashCode();
            return hashCode;
        }
    }
}
