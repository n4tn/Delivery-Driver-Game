using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // cameras position should be the same as the cars position in the world map
    [SerializeField] GameObject thingToFollow;
    void LateUpdate() // smooth follow due to execution order of Unity
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
