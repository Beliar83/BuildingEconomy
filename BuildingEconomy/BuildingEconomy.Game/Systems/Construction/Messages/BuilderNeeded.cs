﻿using System;

namespace BuildingEconomy.Systems.Construction.Messages
{
    /// <summary>
    /// Message that the site needs builders.
    /// </summary>
    public class BuilderNeeded
    {
        public Guid ComponentId { get; }

        public BuilderNeeded(Guid componentId)
        {
            ComponentId = componentId;
        }
    }
}
