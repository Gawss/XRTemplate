using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehavior : MonoBehaviour
{
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
    }

    public void UpdatePosition(Transform _transform)
    {
        _transform.position = new Vector3(_transform.position.x,
            _transform.position.y,
            slider.value);
    }
}
