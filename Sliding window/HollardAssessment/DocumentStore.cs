using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollardAssessment
{
    public class DocumentStore
    {
        private readonly List<string> documents = new List<string>();
        private int _capacity { get; set; }

        public DocumentStore(int capacity)
        {
            _capacity = capacity;
        }

        public int Capacity { get { return _capacity; } }

        public IEnumerable<string> Documents { get { return documents; } }

        public void AddDocument(string document)
        {
            if (documents.Count > _capacity)
                throw new InvalidOperationException();

            documents.Add(document);
        }

        public override string ToString()
        {
            var result = $"{"Document store:"} {documents.Count} {"/"} {_capacity}";
            return result;
        }
    }
}