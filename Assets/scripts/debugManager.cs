using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            for (int i = 0; i >= 20; i++)
            {
                PlayerPrefs.SetInt("card"+ i, 0);

            }
        }
    }
}
