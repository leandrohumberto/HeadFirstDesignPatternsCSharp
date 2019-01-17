using CustomersBase.Implementors;
using System;

namespace CustomersBase.Abstractions
{
    public class CustomersBase
    {
        protected string Group { get; set; }
        protected DataObject Data { get; set; }

        public CustomersBase(string group)
        {
            Group = group;
        }

        public virtual void Next()
        {
            Data.NextRecord();
        }

        public virtual void Prior()
        {
            Data.PriorRecord();
        }
        
        public virtual void Add(string customer)
        {
            Data.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            Data.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            Data.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group: " + Group);
            Data.ShowAllRecords();
        }

        public void SetData(DataObject dataObject) => Data = dataObject;
    }
}
