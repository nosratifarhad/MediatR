namespace WebApplicationMediatR.ViewModels.ProductViewModels
{
    public class ProductVM
    {
        public ProductVM(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
