using System;
namespace DesignPatternLib.Visitor
{
    public class Client
    {
        public static void Test()
        {
            // Setup employee collection
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());
            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
            // Wait for user
            Console.ReadKey();
        }
    }
}