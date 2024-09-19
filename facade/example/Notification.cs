using System;

namespace GOF.facade.example
{
    internal class Notification
    {
        public event EventHandler notificationevent;

        private string mess;

        public string MessageFin
        {
            get { return mess; }
            set
            {
                mess = value;
                if (notificationevent != null)
                    notificationevent(this, new EventArgs());
            }
        }

        public void StartNotification()

        {
            MessageFin = "Операция началась";
        }

        public void StopNotification()
        {
            MessageFin = "Операция завершена";
        }

        public override string ToString()
        {
            string s = String.Format("Информация: {0}", MessageFin);
            return s;
        }
    }
}