using System;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace Advanced
{
    class AppDomainDemo
    {
        public void Driver()
        {
            var permission = new PermissionSet(PermissionState.None);
            permission.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permission.AddPermission(new FileIOPermission(FileIOPermissionAccess.NoAccess, @"C:\"));

            var appDomainSetup = new AppDomainSetup();
            appDomainSetup.ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

            var secureAppDomain = AppDomain.CreateDomain("Secure AppDomain", null, appDomainSetup, permission);

            try
            {
                var thirdParty = typeof(ThirdPartyWeirdClass);
                secureAppDomain.CreateInstanceAndUnwrap(thirdParty.Assembly.FullName, thirdParty.Name);
            }
            catch(Exception ex)
            {
                AppDomain.Unload(secureAppDomain);
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    class ThirdPartyWeirdClass
    {
        public ThirdPartyWeirdClass()
        {
            Console.WriteLine("Third party loaded");
            File.Create(@"C:\temp\shit.txt");
        }

        ~ThirdPartyWeirdClass()
        {
            Console.WriteLine("Third party unloaded");
        }
    }
}