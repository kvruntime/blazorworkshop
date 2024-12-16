using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIntro.Domain
{
    public static class Countries
    {
        public static Dictionary<string, string> All { get; } = new()
        {
            ["us"] = "United States",
            ["ca"] = "Canada",
            ["uk"] = "United Kingdom",
            ["be"] = "Belgium"
        };
    }
}