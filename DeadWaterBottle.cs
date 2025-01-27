﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameByCash
{
    class DeadWaterBottle : Artifact
    {
        public enum VolumeTypes { small = 10, medium = 25, big = 50 };
        public VolumeTypes Volume; //{ get; set; } 
        public DeadWaterBottle(VolumeTypes volume) : base(0, true)
        {
            Volume = volume;
        }
        public override bool MainCast(MagicHero targetHero)
        {
            if (Renewable)//Если ещё не использовали артефакт
            {
                if (targetHero.CurMn + (uint)Volume > targetHero.MaxMana)
                {
                    targetHero.CurMn = targetHero.MaxMana;
                }
                else
                {
                    targetHero.CurMn = targetHero.CurMn + (uint)Volume;
                }
                Renewable = false;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "DeadWaterBottle " + Volume.ToString();
        }
    }
}
