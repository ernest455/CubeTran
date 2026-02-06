using UnityEngine;


public class CubeTransform : MonoBehaviour
{
    // Speed of movement along one axis
    public Vector3 moveSpeed = new Vector3(2f, 0f, 0f);

    // Speed of rotation around one axis
    public Vector3 rotateSpeed = new Vector3(0f, 50f, 0f);

    // Speed of scaling
    public Vector3 scaleSpeed = new Vector3(0.3f, 0.3f, 0.3f);

    // Maximum size limit for scaling
    public float maxScale = 3f;

    void Update()
    {
        // TRANSLATION:
        // Moves the object smoothly along one axis using Vector3
        transform.Translate(moveSpeed * Time.deltaTime);

        // ROTATION:
        // Rotates the object continuously around one axis
        transform.Rotate(rotateSpeed * Time.deltaTime);

        // SCALING:
        // Gradually increases the size of the object over time
        if (transform.localScale.x < maxScale)
        {
            transform.localScale += scaleSpeed * Time.deltaTime;
        }
    }
}