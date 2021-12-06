using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cone : MonoBehaviour
{
    [SerializeField] float angleCorrections;
    Vector2 dirOfLook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetDir(Vector2 dir)
    {
        
        RotateCone(dir);

    }
    private void RotateCone(Vector2 dirOfLook)
    {
        float angle = Mathf.Atan2(dirOfLook.x, dirOfLook.y) * Mathf.Rad2Deg * -1;
        
        transform.rotation = Quaternion.Euler(0f, 0f, angle + angleCorrections);
        
    }
    public void NewGaze(Vector2 dirOfLook)
    {
        float angle = Mathf.Atan2(dirOfLook.x, dirOfLook.y) * Mathf.Rad2Deg ;

        transform.rotation = Quaternion.Euler(0f, 0f, angle - angleCorrections);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "carry")
        {
            FindObjectOfType<Player>().PlayerCaught();
        }
    }
}
