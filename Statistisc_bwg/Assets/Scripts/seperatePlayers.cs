using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This could be called the main script. This is where every script
/// fetches the serial number or the index for every player.
/// The player index is for stating who you are. When we add stats
/// or kills and deaths they are not going to get mixed up with every player.
/// Let me clarify: when you add the kills for the player you do not wan't to 
/// every player or another player.
/// </summary>
public class seperatePlayers : MonoBehaviour
{
    public int playerIndex; //The specific player index;
    public void seperatePlayer(int Pind)
    {
        
        switch (Pind)
        {
            case 0:
                Pind = 1;
                Debug.Log("Case 1! " + Pind);
                break;
            case 1:
                Pind = 2;
                Debug.Log("Case 2! " + Pind);
                break;
            case 2:
                Pind = 3;
                Debug.Log("Case 3! " + Pind);
                break;
            case 3:
                Pind = 4;
                Debug.Log("Case 4! " + Pind);
                break;
            case 4:
                Pind = 5;
                Debug.Log("Case 5! " + Pind);
                break;
        }

        playerIndex = Pind;
    }
}
