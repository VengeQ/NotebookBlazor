using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Examples
{
    public class ExampleService
    {
        public async Task<IDictionary<int, String>> InitExampleDictionary()
        {
            return await Task.Run(() =>
            {
                var DropDownValues = new Dictionary<int, String>
                {
                    { 1, "First" },
                    { 2, "Second" },
                    { 3, "Third" }
                };
                return DropDownValues;
            });
        }
    }
}
