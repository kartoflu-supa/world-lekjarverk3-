using UnityEngine;
using UnityEngine.AI;

public class Hunt : MonoBehaviour
{
    public Transform goal;
    /*
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 8)
        {
            FindObjectOfType<gamemanager>().
        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
