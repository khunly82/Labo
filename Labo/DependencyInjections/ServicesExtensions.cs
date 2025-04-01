using Labo.BLL.Interfaces;
using Labo.BLL.Services;
using Labo.DAL.Repositories;
using Labo.IL.Configurations;
using Labo.IL.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;

namespace Labo.API.DependencyInjections
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddJwt(this IServiceCollection services, JwtConfiguration config)
        {
            services.AddSingleton(config);
            services.AddScoped<JwtSecurityTokenHandler>();
            services.AddScoped<IJwtManager, JwtManager>();

            return services;
        }

        public static IServiceCollection AddMailer(this IServiceCollection services, MailerConfig config)
        {
            services.AddSingleton(config);
            services.AddScoped<SmtpClient>();
            services.AddScoped<IMailer, Mailer>();

            return services;
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ITournamentService, TournamentService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IMatchService, MatchService>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
           services.AddScoped<ITournamentRepository, TournamentRepository>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMatchRepository, MatchRepository>();
            return services;
        }

    }
}
