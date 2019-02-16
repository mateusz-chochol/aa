using UnityEngine;

public class SpearController : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.tag == "Circle")
        {
            gameObject.GetComponentInParent<PinController>().Coll(collision);
        }
    }
}
