using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Caliburn.Micro;
using Caliburn.Micro.Autofac;
using GUI.ViewModels;
using Logic;

namespace GUI
{
    class AppBootstrapper : TypedAutofacBootStrapper<MainViewModel>
    {
        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder
                .RegisterType<TicTacToeGame>()
                .As<ITicTacToeService>();
        }
    }
}
