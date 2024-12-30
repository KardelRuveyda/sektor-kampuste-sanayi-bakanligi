using Autofac;
using DotnetWorkshop.Core.Repositories;
using DotnetWorkshop.Core.Services;
using DotnetWorkshop.Core.UnitOfWorks;
using DotnetWorkshop.Repository;
using DotnetWorkshop.Repository.Repositories;
using DotnetWorkshop.Repository.UnitOfWorks;
using DotnetWorkshop.Service.Mapping;
using DotnetWorkshop.Service.Services;
using System.Reflection;

namespace DotnetWorkshop.API.Modules
{
    public class RepoModuleService : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Generic metotlar için aşağıdaki alanlarını belirttik
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            //Generic değildi o yüzden type olarak eklememiz gereken : Unitofwork
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            //Bulunduğu klasörde ara işlemi için aşağıdaki kod yazılmalıdır. 
            var apiAssembly = Assembly.GetExecutingAssembly();

            //Repo katmanındaki herhangi bir classı type of içinde verebilirsiniz. Bu şekilde diğerlerini de bulacaktır. 
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            //Service katmanındaki herhangi bir classı typeof içerisinde verirsen Service katmanını bulabiliyor. 
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            //InstancePerLifeTimeScope -> Program.cs'de kullandığım AddScoped buna karşılık gelir. 
            //InstancePerDependency => Program.cs'de kullandığım AddTransiet metotuna karşılık gelir. 

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Manager")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
