using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace MiniNetworkManager
{
    public static class RegistryMethods
    {
        public static IEnumerable<NetworkDetails> GetNetworks()
        {
            // Make sure we open 64 bit registry so we don't get stuck in Wow32Node
            //
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey networksKey = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles", RegistryKeyPermissionCheck.ReadSubTree))
                {
                    if (networksKey == null)
                    {
                        throw new InvalidOperationException("Could not open network list registry key");
                    }

                    foreach (string thisNetworkKeyName in networksKey.GetSubKeyNames())
                    {
                        yield return GetNetworkDetails(thisNetworkKeyName, networksKey);
                    }
                }
            }
        }

        public static NetworkDetails GetNetworkDetails(string name)
        {
            // Make sure we open 64 bit registry so we don't get stuck in Wow32Node
            //
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey networksKey = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles", RegistryKeyPermissionCheck.ReadSubTree))
                {
                    if (networksKey == null)
                    {
                        throw new InvalidOperationException("Could not open network list registry key.");
                    }

                    return GetNetworkDetails(name, networksKey);
                }
            }
        }

        public static NetworkDetails GetNetworkDetails(string name, RegistryKey networksKey)
        {
            using (RegistryKey networkKey = networksKey.OpenSubKey(name))
            {
                if (networkKey == null)
                {
                    throw new InvalidOperationException("Could not open network registry key.");
                }

                // Extract all network information
                //
                NetworkDetails networkDetails = new NetworkDetails()
                {
                    Id = name,
                    ProfileName = networkKey.GetValue("ProfileName") as string,
                    Description = networkKey.GetValue("Description") as string,
                    Category = ((NetworkCategoryKind?)(networkKey.GetValue("Category") as int?)) ?? NetworkCategoryKind.Private,
                    NameType = (networkKey.GetValue("NameType") as int?) ?? 0
                };

                return networkDetails;
            }
        }

        public static void SaveNetworkDetails(NetworkDetails networkDetails)
        {
            // Make sure we open 64 bit registry so we don't get stuck in Wow32Node
            //
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey networksKey = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles", RegistryKeyPermissionCheck.ReadSubTree))
                {
                    if (networksKey == null)
                    {
                        throw new InvalidOperationException("Could not open network list registry key.");
                    }

                    SaveNetworkDetails(networkDetails, networksKey);
                }
            }
        }

        public static void SaveNetworkDetails(NetworkDetails networkDetails, RegistryKey networksKey)
        {
            using (RegistryKey networkKey = networksKey.OpenSubKey(networkDetails.Id, RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                if (networkKey == null)
                {
                    throw new InvalidOperationException("Could not open network registry key.");
                }

                // Save all network information
                //
                networkKey.SetValue("ProfileName", networkDetails.ProfileName);
                networkKey.SetValue("Description", networkDetails.Description);
                networkKey.SetValue("Category", (int)networkDetails.Category);
                networkKey.SetValue("NameType", networkDetails.NameType);
            }
        }

        public static void DeleteNetwork(NetworkDetails networkDetails)
        {
            // Make sure we open 64 bit registry so we don't get stuck in Wow32Node
            //
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey networksKey = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles", RegistryKeyPermissionCheck.ReadSubTree))
                {
                    if (networksKey == null)
                    {
                        throw new InvalidOperationException("Could not open network list registry key.");
                    }

                    DeleteNetwork(networkDetails, networksKey);
                }
            }
        }

        public static void DeleteNetwork(NetworkDetails networkDetails, RegistryKey networksKey)
        {
            networksKey.DeleteSubKeyTree(networkDetails.Id, true);
        }
    }
}
