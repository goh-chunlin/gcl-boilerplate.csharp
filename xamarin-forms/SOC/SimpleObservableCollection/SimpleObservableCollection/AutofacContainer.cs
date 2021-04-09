using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using SimpleObservableCollection.Services;
using SimpleObservableCollection.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleObservableCollection
{
    public sealed class AutofacContainer
    {
        public static void Initialize()
        {
            // References:
            // 1. Autofac Instance Scope - https://autofaccn.readthedocs.io/en/latest/lifetime/instance-scope.html
            // 2. Registration Concepts - https://autofaccn.readthedocs.io/en/latest/register/registration.html
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MainViewModel>().AsSelf();
            containerBuilder.RegisterType<MainService>().As<IMainService>();

            IContainer container = containerBuilder.Build();

            AutofacServiceLocator autofacServiceLocator = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => autofacServiceLocator);
        }

    }
}
