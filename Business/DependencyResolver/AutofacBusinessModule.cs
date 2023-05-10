using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concreate;
using Castle.DynamicProxy;
using Core.Utilities.Interceptor;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolver;
public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
       
      
        var assembly = System.Reflection.Assembly.GetExecutingAssembly();

        builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
    }
}