using System;
using Unity.Netcode;
using UnityEngine;

namespace PlayerController
{
    public class PlayerController : NetworkBehaviour
    {
        public float moveSpeed = 5f;

        private void Update()
        {
            if (!IsOwner) return;

            HandleMovement();
        }

        private void HandleMovement()
        {
            Vector3 movement = Vector3.zero;
            
            if (Input.GetKey(KeyCode.W))
            {
                movement += Vector3.forward;
            }
            if (Input.GetKey(KeyCode.S))
            {
                movement += Vector3.back;
            }
            if (Input.GetKey(KeyCode.A))
            {
                movement += Vector3.left;
            }
            if (Input.GetKey(KeyCode.D))
            {
                movement += Vector3.right;
            }

            if (movement.magnitude > 0.1f)
            {
                Vector3 moveDirection = Quaternion.Euler(0f, Camera.main.transform.eulerAngles.y, 0f) * movement.normalized;
                transform.position += moveDirection * moveSpeed * Time.deltaTime;
            }
        }
    }
}
