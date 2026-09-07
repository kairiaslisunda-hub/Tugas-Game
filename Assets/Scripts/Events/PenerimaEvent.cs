using UnityEngine;

public class PenerimaEvent : MonoBehaviour
{
    private void OnEnable()
    {
        PemancarEvent.SaatTombolDitekan += respon;
    }

    private void OnDisable()
    {
        PemancarEvent.SaatTombolDitekan -= respon;
    }
    
    private void respon()
    {
        Debug.Log("Tombol ditekan");
    }
}