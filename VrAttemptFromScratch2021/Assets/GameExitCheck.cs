using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameExitCheck : MonoBehaviour
{
    public GameObject playerObject;
    public TMPro.TextMeshProUGUI exitMessage;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (playerObject.GetComponent<PlayerGoals>().HasFinishedGoal)
        {
            exitMessage.text = "Mission Accomplished!";
        }
        else
        {
            exitMessage.text = "You have not copied the\nsecret documents yet.";
        }
    }
}
