﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueUIFrame.Easy.Utility
{
    public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
    {

        private static T instance;

        public static T Instance
        {
            get
            {
                T t = FindObjectOfType<T>();
                if (instance == null)
                {
                    if (t != null)
                    {
                        instance = t;
                    }
                    else
                    {
                        Debug.LogError("类" + typeof(T).Name + "单例对象为空");
                    }
                }
                return instance;
            }
        }
    }
}
