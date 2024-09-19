using System;

namespace GOF.facade.example
{
    internal class Drive
    {
        public event EventHandler driveevent;

        private string twist;

        public string Twist
        {
            get { return twist; }
            set
            {
                twist = value;
                if (driveevent != null)
                    driveevent(this, new EventArgs());
            }
        }

        public Drive()
        {
            Twist = "исходная позиция";
        }

        public void TurlLeft()
        {
            Twist = "Поверот налево";
        }

        public void TurlRight()
        {
            Twist = "Поверот направо";
        }

        public void Stop()
        {
            Twist = "Стоп";
        }

        public override string ToString()
        {
            string s = String.Format("Привод: {0}", Twist);
            return s;
        }
    }
}