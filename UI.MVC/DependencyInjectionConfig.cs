using System.ComponentModel;
using Microsoft.AspNetCore.Hosting.Internal;
using Autofac;
using BL;
using DAL;
using IContainer = Autofac.IContainer;

namespace UI.MVC
{
    public class DependencyInjectionConfig
    {
        public IContainer container { get; set; }

        public DependencyInjectionConfig()
        {
            register();
        }

        public void register()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<IIdeationManager>().As<IdeationManager>();
            builder.RegisterType<IQuestionnaireManager>().As<QuestionnaireManager>();
            builder.RegisterType<IProjectManager>().As<ProjectManager>();
            builder.RegisterType<IIdentityManager>().As<IdentityManager>();
            
            builder.RegisterType<IIdeationRepository>().As<IdeationRepository>();
            builder.RegisterType<IQuestionnaireRepository>().As<QuestionnaireRepository>();
            builder.RegisterType<IProjectRepository>().As<ProjectRepository>();
            builder.RegisterType<IIdentityRepository>().As<IdentityRepository>();




        }
    }
    
}