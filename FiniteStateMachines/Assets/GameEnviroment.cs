using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnviroment : MonoBehaviour
{
    private static GameEnviroment Instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints {  get { return checkpoints; } }

    public static GameEnviroment Singleton
    {
        get
        {
            if(Instance == null)
            {
                Instance = new GameEnviroment();
                Instance.checkpoints.AddRange(
                    GameObject.FindGameObjectsWithTag("Checkpoint"));
            }
            return Instance;
        }
    }
}
