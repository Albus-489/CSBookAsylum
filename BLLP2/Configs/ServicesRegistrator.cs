using Microsoft.Extensions.DependencyInjection;
using BLLP2.Interfaces;
using BLLP2.Services;

namespace BLLP2.Configs
{
    public static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IAuthorService, AuthorService>()
            .AddTransient<IBookService, BookService>()
            .AddTransient<ICommentService, CommentService>()
            .AddTransient<ICollectionService, CollectionService>()

        ;
    }
}