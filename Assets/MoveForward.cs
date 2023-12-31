using UnityEngine;

public class MoveForward : MonoBehaviour {

    
    public static float speed = 0.03f;
    private bool ileri;
    private bool geri;
    private bool sag;
    private bool sol;
    private void Update() {
        if (PAUSE.IsPaused == false)
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (!Input.GetKeyUp(KeyCode.W))
                {
                    ileri = true;
                }
            }
            if (ileri)
            {
                transform.Translate(transform.forward * speed);
                transform.Translate(transform.forward * speed);
                if (Input.GetKeyUp(KeyCode.W))
                {
                    ileri = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (!Input.GetKeyUp(KeyCode.A))
                {
                    sol = true;
                }
            }
            if (sol)
            {
                transform.Translate(-transform.right * speed);
                transform.Translate(-transform.right * speed);
                if (Input.GetKeyUp(KeyCode.A))
                {
                    sol = false;
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (!Input.GetKeyUp(KeyCode.S))
                {
                    geri = true;
                }
            }
            if (geri)
            {
                transform.Translate(-transform.forward * speed);
                transform.Translate(-transform.forward * speed);
                if (Input.GetKeyUp(KeyCode.S))
                {
                    geri = false;
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (!Input.GetKeyUp(KeyCode.D))
                {
                    sag = true;
                }
            }
            if (sag)
            {
                transform.Translate(transform.right * speed);
                transform.Translate(transform.right * speed);
                if (Input.GetKeyUp(KeyCode.D))
                {
                    sag = false;
                }
            }
        }
    }

}