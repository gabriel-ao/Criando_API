﻿using prmToolkit.NotificationPattern;
using System;

namespace XGame.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }


    }
}
