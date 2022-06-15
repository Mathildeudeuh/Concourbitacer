using UnityEngine;

public class GraineSpawner : MonoBehaviour
{
    public GameObject graine;
    public GameObject spawnerGraine;


    void Start()
    {
        Instantiate(graine, spawnerGraine.transform.position, spawnerGraine.transform.rotation);
    }
}
