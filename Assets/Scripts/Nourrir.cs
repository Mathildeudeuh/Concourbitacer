using UnityEngine;

public class Nourrir : MonoBehaviour
{
    public GameObject objectToSpawn;

    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;
    public GameObject spawner7;
    public GameObject spawner8;

    public void MangePetitePlante()
    {
        Instantiate(objectToSpawn, spawner1.transform.position, spawner1.transform.rotation);
        Instantiate(objectToSpawn, spawner2.transform.position, spawner2.transform.rotation);
        Instantiate(objectToSpawn, spawner3.transform.position, spawner3.transform.rotation);
        Instantiate(objectToSpawn, spawner4.transform.position, spawner4.transform.rotation);
        Instantiate(objectToSpawn, spawner5.transform.position, spawner5.transform.rotation);
        Instantiate(objectToSpawn, spawner6.transform.position, spawner6.transform.rotation);
        Instantiate(objectToSpawn, spawner7.transform.position, spawner7.transform.rotation);
        Instantiate(objectToSpawn, spawner8.transform.position, spawner8.transform.rotation);

        Score.instance.AddPoint();
    }
}