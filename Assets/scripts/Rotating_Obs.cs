using UnityEngine;
using UnityEngine.SceneManagement;

    public class Rotating_Obs : obstacle
{
    [SerializeField] float rotateAngle = 0f;

    public override void Update()
    {
        base.Update();
        transform.Rotate(0f, 0f, rotateAngle * Time.deltaTime);
    }
}
