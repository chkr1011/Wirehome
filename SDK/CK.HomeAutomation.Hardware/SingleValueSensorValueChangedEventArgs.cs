﻿using System;

namespace CK.HomeAutomation.Hardware
{
    public class SingleValueSensorValueChangedEventArgs : EventArgs
    {
        public SingleValueSensorValueChangedEventArgs(float oldValue, float newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public float OldValue { get; }
        public float NewValue { get; }
    }
}