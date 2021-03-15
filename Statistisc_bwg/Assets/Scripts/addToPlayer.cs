using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addToPlayer : MonoBehaviour
{
    [SerializeField]
    private SwitchScene identify;

    public void IsAddKills(int playerInd)
    {
        playerInd = identify.playerIndex;
        if (playerInd == 1)
        {
            Debug.LogWarning("Add kills to *playerName*: " + playerInd);
            //It did not find the player index because the player index probably was not changed and saved
        }
    }
}
