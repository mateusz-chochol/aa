using UnityEngine;

public class PinController : MonoBehaviour {

    public float pinSpeed;
    public static int pinCount;

    private bool shouldMove = true;
    private Rigidbody2D rb;
    private Vector2 velocity;
    private GameManager gameManager;
    private PlayerController playerController;

    private void Start() {

        playerController = FindObjectOfType<PlayerController>();
        gameManager = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0f, pinSpeed);
    }

    private void Update () {

        if (shouldMove)
        {
            rb.MovePosition(rb.position + velocity * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Pin")
        {
            gameManager.GameOver();
        }
    }

    public void Coll(Collider2D collision) {

        transform.SetParent(collision.transform);
        shouldMove = false;
        playerController.SetScore();

        if (pinCount < playerController.maxPins)
        {
            pinCount++;
        }

        if (pinCount == playerController.maxPins)
        {
            gameManager.LoadWinAnimation();
        }
    }
}
