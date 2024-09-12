using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


namespace SampleApp
{
    public class ModelRepository
    {
        Random random;
        public ModelRepository()
        {
            random = new Random();
        }

        public ObservableCollection<Model> GenerateItems()
        {
            ObservableCollection<Model> collection = new ObservableCollection<Model>();
            for(int i=1000;i<1050;i++)
            {
                Model model = new Model();
                model.CustomerID = i;
                model.CustomerName =CustomerNames[random.Next(15)];
                model.Country = ShipCountries[random.Next(10)];
                model.OrderID = random.Next(501, 600);
                collection.Add(model);
            }
            return collection;
        }

        string[] CustomerNames = new string[]
        {
            "Krish",
            "Arjun",
            "Parthiban",
            "Dhananjeyan",
            "Kesav",
            "Sarathy",
            "Yuvaraj",
            "Madhavan",
            "SriRam",
            "Kannan",
            "Yeshwanth",
            "Sona",
            "Subathra",
            "Vishali",
            "Rukmani",
            "Anusha",
            "Devika"
        };

        string[] ShipCountries = new string[]
        {
            "Sweden",
            "Denmark",
            "Canada",
            "UK",
            "Brazil",
            "Germany",
            "France",
            "Spain",
            "UK",
            "Mexico"
        };
    }
}