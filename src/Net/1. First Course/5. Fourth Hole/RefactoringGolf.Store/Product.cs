namespace RefactoringGolf.Store
{
    public class Product
    {
        /*The Name*/
        public string Name { get; private set; }

        /*The UnitPrice*/
        public decimal UnitPrice { get; private set; }

        /*The Category*/
        public ProductCategory Category { get; private set; }

        /*The Image*/
        public ImageInfo Image { get; private set; }

        /*The Category*/
        public int UnitsInStock { get; set; }

        public Product(string name, decimal unitPrice, ProductCategory category, ImageInfo image)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Category = category;
            this.Image = image;
        }

        public string ToXml()
        {
            return "<product>" +
                        "<name>" + Name + "</name>" +
                        "<category>" + Category + "</category>" +
                    "</product>";
        }
    }
}