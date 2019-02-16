using UnityEngine;

public class Circle : MonoBehaviour {

    public Rigidbody2D rb;
    public float rotationSpeed;
    public int directionOfSpinning = 1;
    public bool isChangingDirections = false;

    private void Update() {

        rb.rotation += rotationSpeed * directionOfSpinning;
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (isChangingDirections)
        {
            directionOfSpinning *= -1;
        }
    }
}
