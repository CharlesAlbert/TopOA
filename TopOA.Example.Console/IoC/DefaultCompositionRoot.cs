using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using TopOA.Core;
using TopOA.Core.Commands;
using TopOA.Core.Readers;

namespace TopOA.Example.Console.IoC
{
    internal class DefaultCompositionRoot
    {
        public IServiceProvider Initialize()
        {
            var loginCommandhandler = new LoginCommandHandler();
            var positionsReader = new PositionsReader();
            IServiceProvider serviceProvider = new ServiceCollection()
                .AddSingleton<IValidator<LoginCommand>>(loginCommandhandler)
                .AddSingleton<ICommandHandler<LoginCommand>>(loginCommandhandler)
                .AddSingleton<IValidator<PositionsQuery>>(positionsReader)
                .AddSingleton<IQueryHandler<PositionsQuery, PositionsList>>(positionsReader)
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
