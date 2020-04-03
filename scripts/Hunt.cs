using UnityEngine;
using UnityEngine.AI;

public class Hunt : MonoBehaviour
{
    public Transform goal;  //hvert hluturinn vill fara
    NavMeshAgent agent;  //NavMeshAgent partur
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();//nær í navmesh component sem er partur af hlutnum sem scriptann er partur af
        
    }
    
    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.position;//segir agent að fara til staðinn sem hlutrinn vill fara
    }
}
