namespace PaginationHelper
{
  public class PaginationHelper<T>
  {
    private IList<T> collection;
    private int itemsPerPage;

    /// <summary>
    /// constructor, takes a list of items and the number of items per page
    /// </summary>
    /// <param name="collection">The items to paginate</param>
    /// <param name="itemsPerPage">The number of items per page</param>
    public PaginationHelper(IList<T> collection, int itemsPerPage)
    {
      this.collection = collection;
      this.itemsPerPage = itemsPerPage;
    }

    /// <summary>
    /// number of items per page
    /// </summary>
    public int ItemsPerPage
    {
      get
      {
        return itemsPerPage;
      }
    }

    /// <summary>
    /// number of items
    /// </summary>
    public int ItemCount
    {
      get
      {
        return collection.Count;
      }
    }

    /// <summary>
    /// Number of pages
    /// </summary>
    public int PageCount
    {
      get
      {
        return (ItemCount / ItemsPerPage) + (ItemCount % ItemsPerPage > 0 ? 1 : 0);
      }
    }

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
      if (pageIndex < 0 || pageIndex > PageCount - 1) { return -1; }

      if (pageIndex == PageCount - 1)
      {
        return ItemCount - pageIndex * ItemsPerPage;
      }

      return ItemsPerPage;
    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
      if(itemIndex < 0 || itemIndex > ItemCount - 1) { return -1; }

      return itemIndex / ItemsPerPage;
    }
  }
}