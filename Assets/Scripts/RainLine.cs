using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AC
{
    public class RainLine : MonoBehaviour
    { 
        private void Update ()
        {
            Vector3 FollowMouse = Input.mousePosition;
            FollowMouse.z = 10f;
            this.transform.position = Camera.main.ScreenToWorldPoint(FollowMouse);
        }

    }
}
