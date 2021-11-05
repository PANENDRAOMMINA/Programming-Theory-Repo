using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Base : MonoBehaviour
{
    public static Data_Base instance;

    public string Player_Name;

    public void Awake()
    {
        if(instance!=null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }





}
