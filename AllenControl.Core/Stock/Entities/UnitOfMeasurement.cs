﻿using System;
using AllenControl.Core.Stock.Scopes;

namespace AllenControl.Core.Stock.Entities
{
    public class UnitOfMeasurement
    {
        protected UnitOfMeasurement() { }

        public UnitOfMeasurement(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }

        public void Register()
        {
            this.RegisterScopeIsValid();
        }
    }
}