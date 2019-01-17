using System;
using System.Collections.Generic;

namespace CustomersBase.Implementors
{
    public class CustomersData : DataObject
    {
        private List<string> _customers;
        private int _current = 0;

        public CustomersData()
        {
            _customers = new List<string>
            {
                "Jim Jones",
                "Samual Jackson",
                "Allen Good",
                "Ann Stills",
                "Lisa Giolani",
            };
        }

        public override void AddRecord(string name)
        {
            _customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            _customers.Remove(name);
        }

        public override void NextRecord()
        {
            if (_current <= _customers.Count - 1)
            {
                _current++;
            }
        }

        public override void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        public override void ShowAllRecords()
        {
            foreach (string customer in _customers)
            {
                Console.WriteLine(" " + customer);
            }
        }

        public override void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }
    }
}
