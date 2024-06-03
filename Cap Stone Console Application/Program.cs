using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Capstone_Application
{
    abstract class Data
    {
        public string Email;
        public string Password;

        public abstract void data(string email, string password);
    }

    class Login : Data
    {
        public override void data(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }

    class Register : Data
    {
        public override void data(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }

    class Room
    {
        public string Machine;
        public string previousProd;
        public string CleanedBy;
        public string CheckedBy;
        public DateTime Date = DateTime.Now;
        public string BatchNo;
        public string Signature;

        public void Clean()
        {
            while (true)
            {
                Console.WriteLine("Room Page (Clean) \n");

                Console.WriteLine("(Room / Machine) Name :");
                Machine = Console.ReadLine();


                Console.WriteLine("Previous Product :");
                previousProd = Console.ReadLine();


                Console.WriteLine("Batch.No :");
                BatchNo = Console.ReadLine();

                if (Regex.IsMatch(BatchNo, @"^\d+$"))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("wrong Batch.No inputs !");
                    continue;
                }

                Console.WriteLine("Cleaned By / Date :");
                CleanedBy = Console.ReadLine();
                Console.WriteLine("The Date is : " + Date);

                Console.WriteLine("Checked By / Date :");
                CheckedBy = Console.ReadLine();
                Console.WriteLine("The Date is : " + Date);


                Console.WriteLine("Are You Need To Edit Anything ? :");
                Console.WriteLine("1- Yes");
                Console.WriteLine("2- No");
                int p = int.Parse(Console.ReadLine());

                if (p == 2)
                {
                    break;
                }
                else if (p == 1)
                {
                    Console.WriteLine("You can Edit now :");
                }
                else
                {
                    Console.WriteLine("invalid data input !");
                }
            }
            Console.WriteLine("Face ID");
            Thread.Sleep(1000);

            Console.WriteLine("Look for Camera ...");
            Thread.Sleep(2000);

            Console.WriteLine("Processing ...");
            Thread.Sleep(4000);

            Console.WriteLine("Successfull Data (Clean : Room / Machine)");
        }
        public void UnderCleaning()
        {
            while (true)
            {
                Console.WriteLine("Room Page (UnderCleaning) \n");

                Console.WriteLine("(Room / Machine) Name :");
                Machine = Console.ReadLine();


                Console.WriteLine("Previous Product :");
                previousProd = Console.ReadLine();


                Console.WriteLine("Batch.No :");
                BatchNo = Console.ReadLine();

                if (Regex.IsMatch(BatchNo, @"^\d+$"))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("wrong Batch.No inputs !");
                    continue;
                }

                Console.WriteLine("Signature :");
                Signature = Console.ReadLine();


                Console.WriteLine("Are You Need To Edit Anything ? :");
                Console.WriteLine("1- Yes");
                Console.WriteLine("2- No");
                int u = int.Parse(Console.ReadLine());

                if (u == 2)
                {
                    break;
                }
                else if (u == 1)
                {
                    Console.WriteLine("You can Edit now :");
                }
                else
                {
                    Console.WriteLine("invalid data input !");
                }
            }
            Console.WriteLine("Face ID");
            Thread.Sleep(1000);

            Console.WriteLine("Look for Camera ...");
            Thread.Sleep(2000);

            Console.WriteLine("Processing ...");
            Thread.Sleep(4000);

            Console.WriteLine("Successfull Data (Under Cleaning : Room / Machine)");
            Console.WriteLine("The Date of this process is : ( " + Date + " )");
        }
        public void NotCleaning()
        {
            while (true)
            {
                Console.WriteLine("Room Page (Not Cleaning) \n");

                Console.WriteLine("(Room / Machine) Name :");
                Machine = Console.ReadLine();


                Console.WriteLine("Previous Product :");
                previousProd = Console.ReadLine();


                Console.WriteLine("Batch.No :");
                BatchNo = Console.ReadLine();

                if (Regex.IsMatch(BatchNo, @"^\d+$"))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("wrong Batch.No inputs !");
                    continue;
                }

                Console.WriteLine("Signature :");
                Signature = Console.ReadLine();


                Console.WriteLine("Are You Need To Edit Anything ? :");
                Console.WriteLine("1- Yes");
                Console.WriteLine("2- No");
                int t = int.Parse(Console.ReadLine());

                if (t == 2)
                {
                    break;
                }
                else if (t == 1)
                {
                    Console.WriteLine("You can Edit now :");
                }
                else
                {
                    Console.WriteLine("invalid data input !");
                }
            }
            Console.WriteLine("Face ID");
            Thread.Sleep(1000);

            Console.WriteLine("Look for Camera ...");
            Thread.Sleep(2000);

            Console.WriteLine("Processing ...");
            Thread.Sleep(4000);

            Console.WriteLine("Successfull Data (Not Cleaning : Room / Machine)");
            Console.WriteLine("The Date of this process is : ( " + Date + " )");
        }
    }
    class Product
    {
        public string ProductName;
        public string Type;
        public string Description;
        public string Signature;
        public string QTY;
        public int PreprationDate;
        public string BatchNo;
        public double BatchSize;
        public DateTime Date = new DateTime();

        public void RMProcess()
        {
            while (true)
            {
                Console.WriteLine("Product Page (Room/Machine in Process)\n");

                Console.WriteLine("Product Name :");
                ProductName = Console.ReadLine();


                Console.WriteLine("Batch.No :");
                BatchNo = Console.ReadLine();

                if (Regex.IsMatch(BatchNo, @"^\d+$"))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("wrong Batch.No inputs !");
                    continue;
                }
                Console.WriteLine("Batch Size :");
                BatchSize = int.Parse(Console.ReadLine());


                Console.WriteLine("Date Started in :");
                Console.WriteLine("( " + Date + " )");


                Console.WriteLine("Signature :");
                Signature = Console.ReadLine();


                Console.WriteLine("Are You Need To Edit Anything ? :");
                Console.WriteLine("1- Yes");
                Console.WriteLine("2- No");
                int j = int.Parse(Console.ReadLine());

                if (j == 2)
                {
                    break;
                }
                else if (j == 1)
                {
                    Console.WriteLine("You can Edit now :");
                }
                else
                {
                    Console.WriteLine("invalid data input !");
                }
            }
            Console.WriteLine("Face ID");
            Thread.Sleep(1000);

            Console.WriteLine("Look for Camera ...");
            Thread.Sleep(2000);

            Console.WriteLine("Processing ...");
            Thread.Sleep(3000);

            Console.WriteLine("Successfull Data (RMProcess : Product)");
            Console.WriteLine("The Date of this process is : ( " + Date + " )");
        }
        public void NonProduct()
        {
            while (true)
            {

                Console.WriteLine("Product Page (NON-Product Item)\n");


                Console.WriteLine("Enter The Type of The Product :");
                Type = Console.ReadLine();


                Console.WriteLine("fill The Description :");
                Description = Console.ReadLine();


                Console.WriteLine("Prepration Date in :");
                Console.WriteLine("( " + Date + " )");


                Console.WriteLine("Signature :");
                Signature = Console.ReadLine();
                Console.WriteLine("The Date is : " + Date);


                Console.WriteLine("Are You Need To Edit Anything ? :");
                Console.WriteLine("1- Yes");
                Console.WriteLine("2- No");
                int j3 = int.Parse(Console.ReadLine());

                if (j3 == 2)
                {
                    break;
                }
                else if (j3 == 1)
                {
                    Console.WriteLine("You can Edit now :");
                }
                else
                {
                    Console.WriteLine("invalid data input !");
                }
            }
            Console.WriteLine("Face ID");
            Thread.Sleep(1000);

            Console.WriteLine("Look for Camera ...");
            Thread.Sleep(2000);

            Console.WriteLine("Processing ...");
            Thread.Sleep(3000);

            Console.WriteLine("Successfull Data (NON-Product Item : Product)");
            Console.WriteLine("The Date of this process is : ( " + Date + " )");
        }
        public void Waste()
        {
            while (true)
            {
                Console.WriteLine("Product Page (Waste)\n");

                Console.WriteLine("Enter The Item Description :");
                Description = Console.ReadLine();


                Console.WriteLine("Q.t.Y :");
                QTY = Console.ReadLine();


                Console.WriteLine("Signature :");
                Signature = Console.ReadLine();
                Console.WriteLine("The Date is : " + Date);


                Console.WriteLine("Are You Need To Edit Anything ? :");
                Console.WriteLine("1- Yes");
                Console.WriteLine("2- No");
                int j2 = int.Parse(Console.ReadLine());

                if (j2 == 2)
                {
                    break;
                }
                else if (j2 == 1)
                {
                    Console.WriteLine("You can Edit now :");
                }
                else
                {
                    Console.WriteLine("invalid data input !");
                }

            }
            Console.WriteLine("Face ID");
            Thread.Sleep(1000);

            Console.WriteLine("Look for Camera ...");
            Thread.Sleep(2000);

            Console.WriteLine("Processing ...");
            Thread.Sleep(3000);

            Console.WriteLine("Successfull Data (Waste : Product)");
            Console.WriteLine("The Date of this process is : ( " + Date + " )");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int room = 0;
            int product = 0;

            List<Login> list = new List<Login>(1);
            bool While1 = true;
            while (While1)
            {
                Console.WriteLine("Welcome to digital cards application  ");
                Console.WriteLine();
                Console.WriteLine("1- sign up");
                Console.WriteLine("2- Login");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter Your First Name :");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Your Last Name :");
                    string n1 = Console.ReadLine();
                    Console.WriteLine("please Enter Email");
                    string Email = Console.ReadLine();
                    Console.WriteLine("please Enter Password : (Password atleast 6 Litters - numbers)");
                    string Password = Console.ReadLine();
                    Console.WriteLine("Confirm Password :");
                    string Password1 = Console.ReadLine();

                    string Emailpattern = @"@gmail\.com$";
                    string passwordpattern = @".{6,}";

                    if (Password == Password1)
                    {

                    }
                    else
                    {
                        Console.WriteLine("incorrect confirm Password !");
                        continue;
                    }

                    if (Regex.IsMatch(Email, Emailpattern) && Regex.IsMatch(Password, passwordpattern))
                    {
                        Login register = new Login();
                        register.data(Email, Password);
                        list.Add(register);
                        Console.WriteLine("you add New Email successfuly");
                    }
                    else
                    {
                        Console.WriteLine("wrong data");
                        continue;
                    }
                }


                else if (choice == 2)
                {
                    bool While = false;
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Please Sign Up.");
                        continue;
                    }
                    Console.WriteLine("Enter Email:");
                    string email = Console.ReadLine();

                    Console.WriteLine("Enter Password:");
                    string password = Console.ReadLine();

                    int login = 0;

                    foreach (var loginObject in list)
                    {
                        if (loginObject.Email == email && loginObject.Password == password)
                        {
                            login = 1;
                            While = true;
                            break;
                        }
                        else if (loginObject.Email != email || loginObject.Password != password)
                        {
                            Console.WriteLine("Invalid Data inputs !");
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("Invalid data inputs");
                            continue;
                        }

                    }

                    while (While)
                    {

                        Console.WriteLine("Hello from Home Page :)");
                        if (login == 1)
                        {

                            Console.WriteLine();

                            Console.WriteLine("1- Settings");
                            Console.WriteLine("2- Search");

                            int p = int.Parse(Console.ReadLine());

                            if (p == 1)
                            {
                                Console.WriteLine("1- My Account");
                                Console.WriteLine("2- Notifications");
                                Console.WriteLine("3- Log out =>");

                                int l1 = int.Parse(Console.ReadLine());

                                if (l1 == 1)
                                {
                                    foreach (var item in list)
                                    {
                                        Console.WriteLine("Your Email is " + email + "And Your Password is " + password);
                                    }
                                }
                                else if (l1 == 2)
                                {
                                    Console.WriteLine("1- Vibrate");
                                    Console.WriteLine("2- Sound");
                                    Console.WriteLine("3- Mute");

                                    int x = int.Parse(Console.ReadLine());

                                    if (x == 1)
                                    {
                                        Console.WriteLine("Your Notifications is (Vibrate)");
                                    }
                                    else if (x == 2)
                                    {
                                        Console.WriteLine("Your Notifications is (Sound)");
                                    }
                                    else if (x == 3)
                                    {
                                        Console.WriteLine("Your Notifications is (Mute)");
                                    }

                                    Console.WriteLine("You had logged in");
                                    if (room >= 1)
                                    {
                                        Console.WriteLine("You had search about room / machine These times : " + room);
                                    }
                                    if (product >= 1)
                                    {
                                        Console.WriteLine("You had search about product these times : " + product);
                                    }
                                }
                                else if (l1 == 3)
                                {
                                    While = false;
                                    Console.WriteLine("Your Logged out successfully :)");
                                }
                                else
                                {
                                    Console.WriteLine("invalid data input");
                                    break;
                                }
                            }
                            else if (p == 2)
                            {
                                Console.WriteLine("What do you need to seach : (Room / Machine - Product)");
                                string search = Console.ReadLine();

                                if (search == "Room" || search == "room" || search == "Machine" || search == "Machine")
                                {
                                    Console.WriteLine("1- Clean");
                                    Console.WriteLine("2- Not Clean");
                                    Console.WriteLine("3- Under Cleaning");

                                    int l = int.Parse(Console.ReadLine());

                                    if (l == 1)
                                    {
                                        Room room1 = new Room();
                                        room1.Clean();
                                        room++;
                                    }
                                    else if (l == 2)
                                    {
                                        Room room2 = new Room();
                                        room2.NotCleaning();
                                        room++;
                                    }
                                    else if (l == 3)
                                    {
                                        Room room3 = new Room();
                                        room3.UnderCleaning();
                                        room++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Data Inputs !");
                                        continue;
                                    }
                                }
                                else if (search == "product" || search == "Product")
                                {
                                    Console.WriteLine("1- Room / Machine in process");
                                    Console.WriteLine("2- NON - Product item");
                                    Console.WriteLine("3- Waste");

                                    int l3 = int.Parse(Console.ReadLine());

                                    if (l3 == 1)
                                    {
                                        Product product1 = new Product();
                                        product1.RMProcess();
                                        product++;
                                    }
                                    else if (l3 == 2)
                                    {
                                        Product product2 = new Product();
                                        product2.NonProduct();
                                        product++;
                                    }
                                    else if (l3 == 3)
                                    {
                                        Product product3 = new Product();
                                        product3.Waste();
                                        product++;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Data Inputs !");
                                    continue;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Data Inputs !");
                    continue;
                }
            }
        }
    }
}
