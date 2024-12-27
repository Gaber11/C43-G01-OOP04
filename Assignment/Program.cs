using Assignment.InterFaces;
using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01: Question 01

            //IAuthenticationService basicAuthenticationService = new BasicAuthenticationService()
            //{
            //    username = "Admin",
            //    password = "joker444",
            //};

            //Console.WriteLine(basicAuthenticationService.AuthenticateUser());





            #endregion

            #region Part01: Question 02


            //INotificationService notificationService = new EmailNotificationService();
            //INotificationService pushNotificationService= new PushNotificationService();

            //INotificationService smsNotificationService = new SmsNotificationService();

            //Console.WriteLine(notificationService.SendNotification("Hamed", "Take the channel"));
            //Console.WriteLine(pushNotificationService.SendNotification("Gaber", "Take the channel"));
            //Console.WriteLine(smsNotificationService.SendNotification("Gana", "Take the channel"));


            #endregion

            #region Part 02 1.	Define 3D Point Class and the basic Constructors (use chaining in constructors).

            //Point3D po1 = new Point3D(); 
            //Point3D po2 = new Point3D(7, 5); 
            //Point3D po3 = new Point3D(4,23 ,11 ); 

            //Console.WriteLine(po1);
            //Console.WriteLine(po2);
            //Console.WriteLine(po3);
            #endregion

            #region 2.	Override the ToString Function to produce this output:

            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());



            #endregion

            #region 3.	 Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            //Console.WriteLine("Enter the coordinates for point P1:");
            //double P1 =double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the coordinates for point P2:");
            //double P2 = double.Parse(Console.ReadLine());
            //----------------------------------
            //Console.WriteLine("Enter the coordinates for point P1:");
            //bool flag =double.TryParse(Console.ReadLine(),out double P1);

            //Console.WriteLine("Enter the coordinates for point P2:");
            //bool flag1 = double.TryParse(Console.ReadLine(), out double P2);
            //-------------------------------------
            //Console.WriteLine("Enter the coordinates for point P1:");
            //double P1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the coordinates for point P2:");
            //double P2 = Convert.ToDouble(Console.ReadLine());



            #endregion

            #region 4.	Try to use ==
            // If(P1 == P2) // Don Know
            #endregion

            #region 5.	Define an array of points and sort this array based on X & Y coordinates.
             //int[] arr = [1, 2, 7, 6, 5];
             //Array.Sort(arr);

            #endregion

        }

    }
    }

