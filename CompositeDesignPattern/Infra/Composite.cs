using CompositeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Infra
{
    public class Composite : ICustomComponent
    {
        public string Name { get; set; }
        List<ICustomComponent> components = new List<ICustomComponent>();

        public Composite(string name)
        {
            Name = name;   
        }
        public void AddComponent(ICustomComponent component)
        {
            components.Add(component);
        }

        public decimal CalculatePrice()
        {
            decimal totalPrice = 0;
            foreach (var item in components)
            {
                totalPrice += item.CalculatePrice();
            }
            return totalPrice;
        }
    }
}



