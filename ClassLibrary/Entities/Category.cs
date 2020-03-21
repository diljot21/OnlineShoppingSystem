using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Category
    {
        private int _categoryId;
        private string _categoryName;
        private string _categoryDescription;

        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }
        public string CategoryDescription
        {
            get { return _categoryDescription; }
            set { _categoryDescription = value; }
        }

        public Category(int categoryId, string categoryName, string categoryDescription)
        {
            _categoryId = categoryId;
            _categoryName = categoryName;
            _categoryDescription = categoryDescription;
        }
    }
}
