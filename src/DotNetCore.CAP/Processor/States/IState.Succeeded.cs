﻿using System;
using DotNetCore.CAP.Models;

namespace DotNetCore.CAP.Processor.States
{
    public class SucceededState : IState
    {
        public const string StateName = "Succeeded";

        public TimeSpan? ExpiresAfter => TimeSpan.FromHours(1);

        public string Name => StateName;

        public void Apply(CapPublishedMessage message, IStorageTransaction transaction)
        {
        }

        public void Apply(CapReceivedMessage message, IStorageTransaction transaction)
        {
        }
    }
}