using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LoginToSql.Test
{
    public static class ConvertPasswordToString
    {

        public static string UnSecurePassword(SecureString SecurePassword)
        {
           
                if (SecurePassword == null)
                {
                    return string.Empty;
                }

                IntPtr unmanagedString = IntPtr.Zero;
                try
                {
                    unmanagedString = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(SecurePassword);
                    return System.Runtime.InteropServices.Marshal.PtrToStringUni(unmanagedString);
                }
                finally
                {
                    System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
                }
         
        }

    }
}
