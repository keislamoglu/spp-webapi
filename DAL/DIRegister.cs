using DAL.Repo;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DIRegister
    {
        private static IServiceCollection _services;

        public static void RegisterServicesInto(IServiceCollection services)
        {
            SetServices(services);

            Provide<SessionRepo>();
            Provide<StoryRepo>();
            Provide<VoteRepo>();
            Provide<VoterRepo>();
        }

        private static void Provide<TService>() where TService : class
        {
            _services.AddTransient<TService, TService>();
        }

        private static void SetServices(IServiceCollection services)
        {
            _services = services;
        }
    }
}