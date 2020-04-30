﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class DataBaseUtil 
{
    public static bool CheckDuplication(Vector3[] arr) {
        var hashset = new HashSet<Vector3>();
        foreach (var d in arr) if(hashset.Add(d) == false) return true;
        return false;
    }

    public static bool CheckDuplication(double3[] arr) {
        var hashset = new HashSet<double3>();
        foreach (var d in arr) if(hashset.Add(d) == false) return true;
        return false;
    }
}