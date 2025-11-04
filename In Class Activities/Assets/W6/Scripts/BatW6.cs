using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{   
    //Vector3 movement = (0, 0, 0);
    //Vector3 trf = getComponent<Transform>();
    public void chase(Vector3 destination, float spd){
        Debug.Log("1");
        transform.position = Vector3.MoveTowards(transform.position, destination, spd*Time.deltaTime);
    }
}
