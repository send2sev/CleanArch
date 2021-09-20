﻿using CleanArch.Domain.Core.Events;
using System;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
