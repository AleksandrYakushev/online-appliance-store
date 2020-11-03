using Autofac;
using OnlineApplianceStore.Business.Managers;
using OnlineApplianceStore.Business.Models.Mappings;
using OnlineApplianceStore.Data.Repositories;

namespace OnlineApplianceStore.API.Configuration
{
    public class AutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().SingleInstance();
            //builder.RegisterType<AuthorizationManager>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>().SingleInstance();
            //builder.RegisterType<TokenService>().SingleInstance();
        }
    }
}
