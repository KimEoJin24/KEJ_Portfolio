using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public long lastUpdated;

    public SerializableDictionary<string, bool> hiddenItemsCollected;
    public SerializableDictionary<string, bool> stageClear;

    public GameData()
    {
        hiddenItemsCollected = new SerializableDictionary<string, bool>();
        stageClear = new SerializableDictionary<string, bool>();
    }

    public int GetPercentageComplete()
    {
        int totalCollected = 0;
        foreach (bool collected in hiddenItemsCollected.Values)
        {
            if (collected)
            {
                totalCollected++;
            }
        }

        int percentageCompleted = -1;
        if (hiddenItemsCollected.Count != 0)
        {
            percentageCompleted = (totalCollected * 100 / hiddenItemsCollected.Count);
        }
        return percentageCompleted;
    }
}
