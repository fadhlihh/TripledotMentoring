using System.Collections.Generic;
using UnityEngine;

public enum PlayerID
{
    Player1,
    Player2,
    Player3
}

public class ExampleDictionary : MonoBehaviour
{
    private Dictionary<PlayerID, string> playerDictionary = new Dictionary<PlayerID, string>();

    private void Start()
    {
        playerDictionary.Add(PlayerID.Player1, "Fadhli");
        playerDictionary.Add(PlayerID.Player2, "Peter");
        playerDictionary.Add(PlayerID.Player3, "Julian");

        Debug.Log(playerDictionary[PlayerID.Player1]);
    }

}
