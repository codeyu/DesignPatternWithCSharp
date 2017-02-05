using System;

namespace DesignPatternLib.Chain.NETOptimized
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    class VicePresident : Approver
    {
        public override void PurchaseHandler(object sender, PurchaseEventArgs e)
        {
            if (e.Purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, e.Purchase.Number);
            }
            else if (Successor != null)
            {
                Successor.PurchaseHandler(this, e);
            }
        }
    }

}