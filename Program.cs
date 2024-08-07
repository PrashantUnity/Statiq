using System;
using Statiq.App;
using Statiq.Markdown;

namespace Statiq
{
    internal class Program
    {
        public static async Task<int> Main(string[] args) => await Bootstrapper
        .Factory
        .CreateWeb(args)
        .RunAsync();
    }
}
