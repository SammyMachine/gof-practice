using GOF.facade.example;

namespace GOF.facade.study
{
    internal class CookingMicrowave
    {
        private Drive _drive;
        private Power _power;
        private Notification _notification;

        public CookingMicrowave(Drive drive, Power power, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
        }

        public void Cook()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 800;
            _drive.TurlRight();
            _power.MicrowavePower = 600;
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.MicrowavePower = 1000;
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }

        public void Defrost()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 1000;
            _drive.TurlRight();
            _drive.TurlRight();
            _power.MicrowavePower = 500;
            _drive.Stop();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.MicrowavePower = 200;
            _drive.Stop();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }
    }
}