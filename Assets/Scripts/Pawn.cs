using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    public abstract void Move( float direction );
    public abstract void Jump();

}
