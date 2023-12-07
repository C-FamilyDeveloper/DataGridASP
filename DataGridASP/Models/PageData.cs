namespace DataGridASP.Models
{
    public class PageData
    {
        public Page CurrentPage { get; set; }

        public int TotalCount { get; set; }
        public List<Data> Data { get; set; }
    }
}
