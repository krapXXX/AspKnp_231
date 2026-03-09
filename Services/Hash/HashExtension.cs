namespace AspKnP231.Services.Hash
{
    public static class HashExtension
    {
        public static IServiceCollection AddHash(this IServiceCollection services)
        {
            return services.AddSingleton<IHashService, Md5HashService>();
        }
    }
}
/* Клас-розширення дозволяє замінити запис 
 * builder.Services.AddSingleton<IHashService, Md5HashService>();
 * на
 * builder.Services.AddHash();
 */