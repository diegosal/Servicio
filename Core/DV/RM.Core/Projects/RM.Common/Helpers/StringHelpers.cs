using Newtonsoft.Json;

namespace RM.Common.Helpers
{
    public static class StringHelpers
    {
        public static string ToJsonString<M>(this M Model) where M : class
        {
            try
            {
                return JsonConvert.SerializeObject(Model);
            }
            catch
            {
                return "";
            }
        }
    }
}
