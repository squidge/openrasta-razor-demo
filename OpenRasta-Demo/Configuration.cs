
namespace OpenRasta_Demo
{
    using OpenRasta.Configuration;
    using OpenRasta.Codecs.Razor;

    using OpenRasta_Demo.Handlers;
    using OpenRasta_Demo.Resources;

    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has
                    .ResourcesOfType<MovieResource>()
                    .AtUri("/movies")
                    .HandledBy<MovieHandler>()
                    .RenderedByRazor("~/Views/Movie.cshtml");
            }    
        }
    }
}