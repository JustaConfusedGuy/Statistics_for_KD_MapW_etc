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
    public int playerIndex = 0; //The specific player index;
    public void seperatePlayer(int Pind)
    {
        print(Pind);
        switch (Pind)
        {
            case 1:
                PlayerPrefs.SetInt("Player nmbr 1 ", Pind);
                Debug.Log("Saveing player identifaction 1!  " + Pind);
                break;
            case 2:
                PlayerPrefs.SetInt("Player nmbr 2 ", Pind);
                Debug.Log("Saveing player identifaction 2!  " + Pind);
                    break;
            case 3:
                PlayerPrefs.SetInt("Player nmbr 3 ", Pind);
                Debug.Log("Saveing player identifaction 3!  " + Pind);
                    break;
            case 4:
                PlayerPrefs.SetInt("Player nmbr 4 ", Pind);
                Debug.Log("Saveing player identifaction 4!  " + Pind);
                    break;
            case 5:
                PlayerPrefs.SetInt("Player nmbr 5 ", Pind);
                Debug.Log("Saveing player identifaction 5!  " + Pind);
                    break;

        }

        playerIndex = Pind;
    }
    public void IsAddKills()
    {
        int Player_one = PlayerPrefs.GetInt("Player nmbr 1 ", playerIndex);
        Debug.LogWarning("Add kills to *playerName*: " + Player_one);

        playerIndex = Player_one;
    }
}
