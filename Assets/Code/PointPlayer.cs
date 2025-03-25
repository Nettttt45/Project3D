using UnityEngine;

public class PointPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Scene.instance.NextLevel();
        }
    }
}
