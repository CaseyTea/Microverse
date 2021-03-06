using UnityEngine;

public class Coin : MonoBehaviour {
    public float speed = 40.0f;
    private Rigidbody2D rb;
    //private Vector2 screenBounds;

    // Use this for initialization
    private void Start() {
        //int randNum = Random.Range(-1, 2);
        //if(randNum == 0)
        //{
        //    randNum++;
        //}
        //rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(speed * randNum, speed * randNum);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void OnEnable() {
        float randNum = Random.Range(-1, 2);
        if (randNum == 0) {
            randNum++;
        }
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed * randNum, speed * randNum);
    }

    // Update is called once per frame
    private void Update() {
        //if (transform.position.x < screenBounds.x * 2)
        //{
        //    //Destroy(this.gameObject);
        //    speed = speed * -1;
        //}
    }
}