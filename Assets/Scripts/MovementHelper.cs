﻿using UnityEngine;
using System.Collections;

public static class MovementHelper
{
    public static Vector3 GetStepFromSpeedAndRotation(float speed, Quaternion rotation)
    {
        return rotation * Vector3.up * speed;
    }
}
