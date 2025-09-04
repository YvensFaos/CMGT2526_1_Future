using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    [SerializeField] private Camera faceCamera;

    private void Update()
    {
        if (faceCamera == null) return;
        var targetPosition = new Vector3(faceCamera.transform.position.x,
            transform.position.y,
            faceCamera.transform.position.z);
        transform.LookAt(targetPosition);
    }
}