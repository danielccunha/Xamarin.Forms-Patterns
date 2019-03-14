﻿using Autofac;
using MyProject.Contracts.Services.General;
using MyProject.Services.General;
using MyProject.ViewModels;

namespace MyProject.Bootstrap
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            RegisterDependencies(builder);

            return builder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder builder)
        {
            // ViewModels
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<AboutViewModel>().SingleInstance();
            builder.RegisterType<ModalViewModel>().SingleInstance();

            // Services - General
            builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<DialogService>().As<IDialogService>();
        }
    }
}
