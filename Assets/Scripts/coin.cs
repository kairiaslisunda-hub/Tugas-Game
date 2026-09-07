using UnityEngine;

public class coin : MonoBehaviour
{
    // Dipanggil otomatis saat Player menyentuh objek ber-Trigger 
    void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: cek apakah yang disentuh punya tag "Coin" 
        if (other.CompareTag("Coin"))
        {
            // TODO: hancurkan koin yang tersentuh 
            Destroy(other.gameObject);
        }
    }
}
