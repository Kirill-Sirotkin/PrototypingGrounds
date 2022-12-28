using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypingGrounds
{
    public class Movement : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("Small movement forward");
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Small movement left");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("Small movement back");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("Small movement right");
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Big movement forward");
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Debug.Log("Big movement left");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("Big movement back");
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Debug.Log("Big movement right");
            }
        }

        public void MoveMe(Vector3 targetPosition)
        {

        }
    }
}
