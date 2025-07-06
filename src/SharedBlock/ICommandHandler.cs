﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedBlock.CQRS;
public interface ICommandHandler<TCommand> where TCommand : ICommand
{
    Task HandleCommandAsync(TCommand command);
}
