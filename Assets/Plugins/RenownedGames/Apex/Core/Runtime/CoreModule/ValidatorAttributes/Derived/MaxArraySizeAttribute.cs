﻿/* ================================================================
   ----------------------------------------------------------------
   Project   :   Apex
   Publisher :   Renowned Games
   Developer :   Tamerlan Shakirov
   ----------------------------------------------------------------
   Copyright 2020-2023 Renowned Games All rights reserved.
   ================================================================ */

using System;

namespace RenownedGames.Apex
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class MaxArraySizeAttribute : ValidatorAttribute
    {
        public readonly int size;

        public MaxArraySizeAttribute(int size)
        {
            this.size = size;
        }
    }
}