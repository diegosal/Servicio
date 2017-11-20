namespace RM.Core.Web.Entities.Views
{
    public class WebResponse<T,M>
    {
        public T Model { get; set; }
        public M Response { get;set; }
    }
}
