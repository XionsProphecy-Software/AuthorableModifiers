﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;

namespace AuthorableModifiers
{
    public class HiddenTelegraphs : Modifier
    {
        /*public HiddenTelegraphs(ModifierType _type, float _startTick, float _endTick)
        {
            Type = _type;
            StartTick = _startTick;
            EndTick = _endTick;
        }*/

        public override void Activate()
        {
            base.Activate();
            Hooks.hideTeles = true;
        }

        public override void Deactivate()
        {
            base.Deactivate();
            Hooks.hideTeles = false;
        }
    }
}
