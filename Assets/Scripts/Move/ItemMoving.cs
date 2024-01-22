using UnityEngine;

namespace Item
{
    public class ItemMoving : MonoBehaviour
    {
        [Header("�㉺����ݒ�")]
        public float sinOffset = 3f;
        [Header("��]���x��ݒ�")]
        public float rotateSpeed = 1f;

        private float offsetY;

        private void Start()
        {
            offsetY = transform.position.y;
        }

        private void Update()
        {
            var posY = Mathf.Sin(Time.time) / sinOffset;
            Vector3 updateVec = transform.position;
            updateVec.y = offsetY + posY;
            transform.position = updateVec;

            transform.Rotate(0f, rotateSpeed, 0f);
        }
    }
}
