using UnityEngine;

public class GouttesDestroyer : MonoBehaviour
{
   private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("sol"))
        {
            Destroy(this);
        }
    }
}
