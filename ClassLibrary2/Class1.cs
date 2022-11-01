using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    
    
        public delegate void AccountHandler(string message);
        public class Account
        {
            public int sum;
            public string Fio;
            AccountHandler taken;
            public Account(int sum, string fio)
            {
                this.sum = sum;
                Fio = fio;
            }
            
            public void RegisterHandler(AccountHandler del)
            {
                taken += del;
            }
           
            public void UnregisterHandler(AccountHandler del)
            {
                taken -= del; 
            }
            public void Add(int sum) => this.sum += sum;
            public void Take(int sum)
            {
                if (this.sum >= sum)
                {
                    this.sum -= sum;
                    taken?.Invoke($"Со счета списано {sum} у.е.");
                }
                else
                    taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
            }
        }
    
}
