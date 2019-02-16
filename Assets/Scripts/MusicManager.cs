using UnityEngine;

public class MusicManager : MonoBehaviour {

    private static bool isPlaying = false;

    private void Awake() {
        
        if(!isPlaying)
        {
            isPlaying = true;
        }
        else
        {
            DestroyObject(gameObject);
        }

        DontDestroyOnLoad(this);
    }
}
