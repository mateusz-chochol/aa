using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public GameObject pin;
    public int maxPins=5;
    public Text text;
    private int numberOfShots=0;

    private void Start() {

        text.text = numberOfShots.ToString() + "/" + maxPins.ToString();
    }

    private void Update() {
        
        if(Input.GetMouseButtonDown(0))
        {
            if (numberOfShots < maxPins)
            {
                Instantiate(pin);
                numberOfShots++;
            }
        }
    }

    public void SetScore() {

        text.text = numberOfShots.ToString() + "/" + maxPins.ToString();
    }
}
