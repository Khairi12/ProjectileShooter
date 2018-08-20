using UnityEngine;
using UnityEngine.UI;

public class Lance : MonoBehaviour
{
    private GameObject powerBar;
    private Slider powerBarSlider;

	private void Start ()
    {
        powerBar = GameObject.FindGameObjectWithTag("PowerBar");
        powerBarSlider = powerBar.GetComponent<Slider>();
	}
	
	private void Update ()
    {
        if (Input.GetMouseButtonDown(1))
        {
            powerBarSlider.value = 0;
            powerBar.SetActive(true);
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        }
        else if (Input.GetMouseButton(1))
        {
            powerBarSlider.value += 1 * Time.deltaTime;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            powerBarSlider.value = 0;
            powerBar.SetActive(false);
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
	}
}
