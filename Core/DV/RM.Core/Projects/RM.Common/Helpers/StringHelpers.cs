using Newtonsoft.Json;

namespace RM.Common.Helpers
{
    /// <summary>
    /// Class StringHelpers.
    /// </summary>
    public static class StringHelpers
    {
        /// <summary>
        /// To the json string.
        /// </summary>
        /// <typeparam name="M"></typeparam>
        /// <param name="Model">The model.</param>
        /// <returns>System.String.</returns>
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
