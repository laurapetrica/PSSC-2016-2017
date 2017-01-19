﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Command
{
    public interface ICommandHandler<in TCommand>
     where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}
