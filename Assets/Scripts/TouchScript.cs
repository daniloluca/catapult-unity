using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	private Vector2 screenPoint;
    private Vector2 offset;
     
    void OnMouseDown(){
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        transform.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    void OnMouseUp(){
        transform.GetComponent<Rigidbody2D>().isKinematic = false;
    }
     
    void OnMouseDrag(){
        Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;
    }
}
