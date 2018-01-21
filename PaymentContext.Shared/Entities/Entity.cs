using System;
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            //Guid é menos performático que usar int
            //Mas nao depende de banco para gerar
        }

        public Guid Id { get; private set; }
    }
}