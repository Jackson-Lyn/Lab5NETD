/* name: Jackson
 * date: 12/28/02
 * Description: Lab5 NETD
 * */

using System;

namespace Lab5NETD.Models
{
    public class ErrorViewModels
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
