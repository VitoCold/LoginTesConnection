using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LoginToSql.Test
{
    public interface IHavePassword
    {
       SecureString Password { get; }
    }
}
