using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5 : MonoBehaviour{
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform destination;

    private string _isWalkingName = "IsWalking";

    private void Start(){
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destination.position);
    }
    //Vector3 direction = targetObj.postion - transform.postion;

    //private void Update(){
    //    float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
    //    transform.Rotate(0, rotation, 0);
    //}
}