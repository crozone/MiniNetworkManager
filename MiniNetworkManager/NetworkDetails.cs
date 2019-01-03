using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNetworkManager
{
    public class NetworkDetails
    {
        public string Id { get; set; }
        public string ProfileName { get; set; }
        public string Description { get; set; }
        public NetworkCategoryKind Category { get; set; }
        public int NameType { get; set; }

        public override string ToString()
        {
            return ProfileName;
        }
    }

    public enum NetworkCategoryKind {
        Public = 0,
        Private = 1
    }
}
