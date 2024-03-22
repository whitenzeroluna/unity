using UnityEngine;

public class MoblieOnly : MonoBehaviour
{
    private void Start() 
    {
        if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
            gameObject.SetActive(false);
    }
}
