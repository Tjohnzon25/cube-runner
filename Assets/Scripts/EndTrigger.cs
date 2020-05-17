using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManger;
    
    void OnTriggerEnter()
    {
        gameManger.CompleteLevel();
    }

}
