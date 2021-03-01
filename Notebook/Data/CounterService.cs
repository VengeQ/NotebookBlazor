using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Data
{
    public class CounterService
    {
        private int _count;
        public int Count
        {
            get => _count;
            set => _count = value;
        }
        public CounterService()
        {
            _count = 0;
        }

        public async Task Increment()
        {
            await Task.Run(() => _count += 1);
        }
    }
}
