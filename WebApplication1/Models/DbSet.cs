using System;
using MvcApplication1.Models;

namespace WebApplication1.Models
{
    public class DbSet<T>
    {
        internal User Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}