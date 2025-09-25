
        Student good = new Student("Ali", "Dushanbe", "IT", 2, 1500);
        Console.WriteLine(good.ToString());
        good.SetProgram("C#");
        Console.WriteLine("Program after update: " + good.GetProgram());
        Console.WriteLine(good.ToString());
        Staff nice = new Staff("Shamsiddin", "Khujand", "SchoolA", 2000);
        Console.WriteLine(nice.ToString());
        nice.SetPay(2500);
        Console.WriteLine("Pay after update: " + nice.GetPay());
        Console.WriteLine(nice.ToString());
    
