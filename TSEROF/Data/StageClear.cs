using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour, IDataPersistence
{
    [SerializeField] private GameObject[] stagePortal;
    private bool[] _clear;

    public void LoadData(GameData data)
    {
        for(int i=0; i<data.stageClear.Length; i++)
        {
            this._clear[i] = data.stageClear[i];
        }
    }

    public void SaveData(GameData data)
    {
        for (int i = 0; i < data.stageClear.Length; i++)
        {
            this._clear[i] = data.stageClear[i];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            for(int i=0; i< stagePortal.Length; i++) 
            {
                if (stagePortal[i])
                {
                    _clear[i] = true;
                }
            }
        }
    }
}
