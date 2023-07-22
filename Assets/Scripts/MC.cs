using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AC
{
    public class MC : MonoBehaviour
    {
        //public CameraController c;
        public float time = 5f;
        public static bool paused;
        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 1;
        }


        private void Update ()
        {
            time -= 0.05f;
            float t = getTime();
            if (t <= 0)
            {
                paused = true;
                ///c.paused = 1;
                Time.timeScale = 0;
               
            }
            if (!paused)
            {
                Vector3 FollowMouse = Input.mousePosition;
                FollowMouse.z = 10f;
                this.transform.position = Camera.main.ScreenToWorldPoint(FollowMouse);
            }
            
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Cloud")
            {
                time += 5;
            }
        }

        private float getTime()
        {
            return time;
        }

        public bool isPaused()
        {
            return paused;
        }

    }
}
