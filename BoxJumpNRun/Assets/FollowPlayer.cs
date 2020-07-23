using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // All game objects derive from Transform (see that the inspector has a transform section with Position, Rotation, scale)
    public Transform player;

    // Vector 3 is basically 3 doubles for 3d space
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = this.player.position + this.offset;
    }
}
