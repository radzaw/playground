namespace MyApplicationNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Windows.ApplicationModel.Store;

    // switch to CurrentAppSimulator in development
#if DEBUG
    using aliasCurrentApp = Windows.ApplicationModel.Store.CurrentAppSimulator;
#else
    using aliasCurrentApp = Windows.ApplicationModel.Store.CurrentApp;
#endif

    internal class MyCurrentApp
    {
        internal static LicenseInformation GetLicenseInformation()
        {
            return aliasCurrentApp.LicenseInformation;
        }

        internal async static Task<string> RequestAppPurchaseAsync(bool arg)
        {
            return await aliasCurrentApp.RequestAppPurchaseAsync(arg);
        }

        internal async static Task<string> GetAppReceiptAsync()
        {
            return await CurrentApp.GetAppReceiptAsync();
        }
    }
}
