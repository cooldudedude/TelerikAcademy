using System;

class InfoAboutCompany
{
    static void Main()
    {
        Console.Write("Enter company's name: ");
        string companyName = Console.ReadLine();
        
        Console.Write("Enter company's adress: ");
        string adress = Console.ReadLine();
        
        Console.Write("Enter company's phone number: ");  //It's better to write the phone number as a string,
        string companyPhoneNumber = Console.ReadLine();   //because it may cointain letters or dashes, 
                                                          //or could exceed int length
        Console.Write("Enter company's fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Enter company's website: ");
        string website = Console.ReadLine();

        Console.Write("Enter manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter manager's last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter manager's age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter manager's phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company profile:");
        Console.WriteLine("Name: {0}", companyName);
        Console.WriteLine("Adress: {0}", adress);
        Console.WriteLine("Phone number: {0}", companyPhoneNumber);
        Console.WriteLine("Fax number: {0}", faxNumber);
        Console.WriteLine("Company website: {0}", website);
        Console.WriteLine();
        Console.WriteLine("Manager profile:");
        Console.WriteLine("Name: {0} {1}", managerFirstName, managerLastName);
        Console.WriteLine("Age: {0}", managerAge);
        Console.WriteLine("Phone number: {0}", managerPhoneNumber);
    }
}

