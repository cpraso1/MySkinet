namespace Core.Specifications
{
    public class ProductSpecParams
    {
        private const int maxPageSize = 50;
        public int PageIndex { get; set; } = 1;
        private int _pageSize = 5;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }
        private string _search;
        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
        public string Sort { get; set; }

    }
}