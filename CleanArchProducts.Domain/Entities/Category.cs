using System.Collections.Generic;
using CleanArchProducts.Domain.Validation;

namespace CleanArchProducts.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        public Category (string name)
        {
            ValidateDomain(name);
        }
        public Category (int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id.");
            Id = id;
            ValidateDomain(name);
        }

        public void Update (string name)
        {
            ValidateDomain(name);
        }
        
        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Name is too short, minimum 3 characters.");
            Name = name;
        }
        
    }
}