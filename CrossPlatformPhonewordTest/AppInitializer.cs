using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlatformPhonewordTest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                //return ConfigureApp.Android.StartApp();
                return ConfigureApp.Android.ApkFile("../../../Phoneword/Phoneword.Android/bin/Debug/com.companyname.Phoneword-Signed.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}