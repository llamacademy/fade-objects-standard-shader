using UnityEngine;
using UnityEngine.AI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Camera Camera;
    [SerializeField]
    private LayerMask FloorLayers;
    [SerializeField]
    private NavMeshAgent Agent;
    [SerializeField]
    private Vector3 CameraFollowOffset = new Vector3(0, 8, -10);

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (Physics.Raycast(Camera.ScreenPointToRay(Input.mousePosition), out RaycastHit Hit, float.MaxValue, FloorLayers))
            {
                Agent.SetDestination(Hit.point);
            }
        }

        Camera.transform.position = Agent.transform.position + CameraFollowOffset;
    }
}