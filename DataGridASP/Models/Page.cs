namespace DataGridASP.Models
{
    public class Page
    {
        public int PageCount { get; private set; }
        public int CurrentPage { get; private set; }
        public Page(long datacount, int pagesize, int page)
        {
            PageCount = (int)Math.Ceiling((double)datacount / pagesize);
            CurrentPage = page;
        }
        public bool IsCanGoNext()
        {
            return (CurrentPage + 1) < PageCount;
        }
        public bool IsCanGoPrevious()
        {
            return (CurrentPage - 1) > 0;
        }
        public bool IsFirst()
        {
            return CurrentPage == 1;
        }
    }
}
