using UnityEngine;

public class disappear : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            RocketController rocketController = other.GetComponent<RocketController>();
            if (rocketController != null)
            {
                rocketController.points++; // Makes Scores go up
            }

            Destroy(gameObject);            // Destroys object
            gameObject.SetActive(false);    //  Disables object
        }
    }
}