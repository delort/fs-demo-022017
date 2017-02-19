using System;
using System.Diagnostics;
using UIKit;

namespace Demo.iOS
{
    public class Application
    {
        static void Main(string[] args)
        {
#if DEBUG
            try
            {
                UIApplication.Main(args, null, nameof(AppDelegate));
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
#else
            UIApplication.Main(args, null, nameof(AppDelegate));
#endif
        }
    }
}
