using System;

namespace App.Business.Model
{
    public class Example
    {
        public Example() => ExampleId = Guid.NewGuid();
        public Guid ExampleId { get; set; }
        public string Description { get; set; }
    }
}