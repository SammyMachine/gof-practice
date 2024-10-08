﻿namespace GOF.chain_of_responsibility.example
{
    internal abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }

        public abstract void Handle(Receiver receiver);
    }
}