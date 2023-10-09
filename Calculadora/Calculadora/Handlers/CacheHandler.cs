using Calculadora.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Handlers
{
    public class CacheHandler
    {
        public List<Operation> Operations { get; private set; }
        public CacheHandler()
        {
            Operations = new List<Operation>();
        }
        public void Save(Operation opToSave)
        {
            if(Operations.Count == 3)
            {
                Operations.Remove(Operations[0]);
            }
            Operations.Add(opToSave);
        }
    }
}
