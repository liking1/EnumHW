using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHW
{
    struct RequestItem
    {
        public uint NumberOfItems { get; set; }
        public Article article_ { get; set; }
        public RequestItem (uint numberOfItems, Article article)
        {
            this.NumberOfItems = numberOfItems;
            this.article_ = article;
        }
        public override string ToString()
        {
            return $"=========Request Items=========\n" +
                $"{article_}\n" +
                $"Number of Items : {NumberOfItems}";
        }
    }
}
