using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Data
{
    public class RecordService
    {
        private List<Record> records;

        public RecordService()
        {
            records = new List<Record>
            {
                new Record(1, "First"),
                new Record(2, "Second"),
                new Record(3, "Third")
            };
        }

        public Task<IEnumerable<Record>> GetRecordsAsync()
        {
            return Task.FromResult(records.AsEnumerable());
        }

        public Task DeleteTaskAsync(uint filter)
        {
            return Task.Run(() => 
                records = records
                    .Where(record => record.Id != filter)
                    .ToList()
            );
        }

    }
}
