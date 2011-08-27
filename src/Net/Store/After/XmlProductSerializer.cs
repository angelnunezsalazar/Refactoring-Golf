namespace After
{
    public class XmlProductSerializer
    {
        public string ToXml(Product product)
        {
            return "<product>" +
                   "<name>" + product.Name + "</name>" +
                   "<category>" + product.Category + "</category>" +
                   "</product>";
        }
    }
}