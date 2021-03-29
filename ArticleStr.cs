using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHW
{
    struct Article : IComparable
    {
        uint code;
        public uint Code { get => code; }
        string name;
        public double Price { get; set; }
        Category category;
        public Article(uint code, string name, double price, Category category)
        {
            this.code = code; 
            this.name = name;
            this.Price = price;
            this.category = category;
        }
        public enum Category
        {
            Products = 1,
            IceCream,
            Chemistry,
            DogFood
        }
        public static int SortByPrice(Article one, Article two)
        {
            return one.Price.CompareTo(two.Price);
        }
        public override string ToString()
        {
            return $"=======Article=======\nCode : {code}\n" +
                $"Name : {name}\n" +
                $"Price : {Price}$\n" +
                $"Category : {category}";
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Article))
            {
                throw new Exception("Obj is not article");
            }
            Article tmp = (Article)obj;
            return Price.CompareTo(tmp.Price);
        }
        
    }
    struct ComparerByPrice : IComparer<Article>
    {
        public int CompareByPrice(Article x, Article y)
        {

            return x.Price.CompareTo(y.Price);
        }
    }
}