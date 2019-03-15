﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.Server.Entities;
using Newtonsoft.Json;

// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local

namespace Intersect.Server.Database.PlayerData.Players
{
    public class SpellSlot : Spell, ISlot, IPlayerOwned
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }
        public Guid PlayerId { get; private set; }
        [JsonIgnore] public virtual Player Player { get; private set; }
        public int Slot { get; private set; }

        public SpellSlot()
        {

        }

        public SpellSlot(int slot)
        {
            Slot = slot;
        }
    }
}