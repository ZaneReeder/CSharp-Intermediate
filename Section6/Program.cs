using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{

    class Program
    {
        static void Main(string[] args)
        {
            //Unit Testing
            //var orderProcessor = new OrderProcessor(new ShippingCalculator());
            //var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            //orderProcessor.Process(order);

            //Extension
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            //Polymorphism
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());

        }
    }
}

