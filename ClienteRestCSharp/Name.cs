using System.Collections.Generic;


namespace Pr
{
    public partial class Name
    {
        public string Common { get; set; }
        public string Official { get; set; }
        public Dictionary<string, Translation> NativeName { get; set; }
    }
}

