using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float xMargin = 1f;
    public float yMargin = 1f;
    public float xSmooth = 8f;
    public float ySmooth = 8f;
    public Vector2 maxXandy;
    public Vector2 minXandy;

    public Transform miPlayer;

    private void Awake()
    {
    }

    private bool CheckXWmargin()
    {
        return Mathf.Abs(transform.position.x - miPlayer.position.x) > xMargin;
    }

    private bool CheckYWarning()
    {
        return Mathf.Abs(transform.position.y - miPlayer.position.y) > xMargin;
    }

    private void Update()
    {
        TrackPlayer();
    }

    private void TrackPlayer()
    {
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        if (CheckXWmargin())
        {
            targetX = Mathf.Lerp(transform.position.x, miPlayer.position.x, xSmooth * Time.deltaTime);
        }

        if (CheckYWarning())
        {
            targetY = Mathf.Lerp(transform.position.y, miPlayer.position.y, ySmooth * Time.deltaTime);
        }

        targetX = Mathf.Clamp(targetX, minXandy.x, maxXandy.x);
        targetY = Mathf.Clamp(targetY, minXandy.y, maxXandy.y);

        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}
