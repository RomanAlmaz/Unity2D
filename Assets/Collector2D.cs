using UnityEngine;

public class Collector2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Монетка собрана!");
            Destroy(other.gameObject);
        }
    }
}