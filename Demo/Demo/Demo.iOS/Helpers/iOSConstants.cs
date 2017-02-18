using System;
using UIKit;

namespace Demo.iOS.Helpers
{
    public class iOSConstants
    {
        #region Page Titles

        public const string VIEW_CONTROLLER_HOME_TITLE = "Home";
        public const string VIEW_CONTROLLER_VECTOR_TITLE = "Vector";

        #endregion

        #region Colours

        public static UIColor DEMO_COLOR = UIColor.FromRGB(38, 50, 56);

        #endregion

        #region Dimensions

        public static nfloat CONTENT_PADDING = 12f;
        public static nfloat SIDE_PADDING = 12f;

        #endregion

        #region FONT

        public const string FONT_HELVETICA_NEUE = "HelveticaNeue";
        public static nfloat FONT_SMALL = 12f;

        #endregion

        #region Binding Keys

        public const string SIZE_TARGET_BINDING_KEY = "Size";

        #endregion

        public const string BUTTON_VECTOR = "View Vector";

        public const string VECTOR_EXPLANATION = "iOS does not natively support vector graphics. Id you like, you can provide a .pdf vector graphic for an image @1x scale, which Xamarin will rasterize at compile time into the appropriate dimensions for the various iOS scales. This is how the above image is being rendered. However, any resizing of images done after compile time is still happening on rasterised images, so the benefits over raster images aren't as pronounced as they are on Android.";
    }
}