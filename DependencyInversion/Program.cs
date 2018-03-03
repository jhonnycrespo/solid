using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversion.correct;

namespace DependencyInversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            NotificationSystem notificationSystem1 = new NotificationSystem(new Email());
            NotificationSystem notificationSystem2 = new NotificationSystem(new Sms());

            notificationSystem1.Notify();
            notificationSystem2.Notify();
        }
    }
}
