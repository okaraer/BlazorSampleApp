using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.DTO
{
    public class PageResult<T>
    {
        public int TotalCount { get; set; }

        public IEnumerable<T> Items { get; set; }
    }
}
