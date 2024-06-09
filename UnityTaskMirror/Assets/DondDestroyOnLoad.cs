using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DondDestroyOnLoad : MonoBehaviour
{
    private static bool destroy = false;
    private void Awake()
    {
        if (!destroy)
        {
            DontDestroyOnLoad(this.gameObject);
            destroy = true;
        }
    }

}
