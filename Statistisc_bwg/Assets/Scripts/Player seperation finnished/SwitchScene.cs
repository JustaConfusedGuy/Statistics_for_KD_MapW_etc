using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScene : MonoBehaviour
{   
    [SerializeField]
    private seperatePlayers seperation;

    public void OnPlayerSpecified(int PlayerIn)
    {
        PlayerIn = seperation.playerIndex;
        SceneManager.LoadScene(PlayerIn, LoadSceneMode.Single);
        Debug.LogWarning("Loading in player scene " + "|| " +  PlayerIn);
    }
    
}