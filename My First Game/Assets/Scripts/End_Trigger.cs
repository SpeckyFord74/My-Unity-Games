using Unity.VisualScripting;
using UnityEngine;

public class End_Trigger : MonoBehaviour
{
    public Game_Manager game_Manager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            game_Manager.CompleteLevel();
        }
    }
}
