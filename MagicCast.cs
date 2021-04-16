﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameByCash
{
    abstract class MagicCast: IMagic
    {
        public uint MinMana;// лучше private мы же его нигде не меняем + только задаем в дочернем
        public bool MoveAbility;// 
        public bool SpeakAbility;//

        public MagicHero SpellCastingHero;// лучше private мы же его нигде не меняем
        //public Hero TargetHero; а зачем вообще нужны?
        //public int Strength;

        public MagicCast(MagicHero spellCastingHero, uint minMana, bool moveAbility, bool speakAbility)
        {
            SpellCastingHero = spellCastingHero;
            MinMana = minMana;
            MoveAbility = moveAbility;
            SpeakAbility = speakAbility;
        }

        public virtual bool MainCast(Hero targetHero,uint strength)
        {
            return false;//Если метод не переопределён в дочернем классе
                         //то данную перегрузку нельзя кастануть поэтому false
        }
        public virtual bool MainCast(Hero targetHero)
        {
            return false;
        }
        public virtual bool MainCast(uint strength)
        {
            return false;
        }
        public virtual bool MainCast()
        {
            return false;
        }
    }
}
