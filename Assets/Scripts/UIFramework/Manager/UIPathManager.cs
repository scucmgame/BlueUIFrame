﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UIPathManager
{

    private static readonly Dictionary<EUiId, string> UIPathDic = new Dictionary<EUiId, string>()
    {
        {EUiId.MAIN_UI, ""}
    };

    public static string GetPath(EUiId id)
    {
        if (UIPathDic.ContainsKey(id))
        {
            return UIPathDic[id];
        }
        else
        {
            Debug.LogError("未在UIPathManager初始化该UI");
            return null;
        }
    } 
}

public enum EUiId
{
    MAIN_UI,
    SECOND_UI
}