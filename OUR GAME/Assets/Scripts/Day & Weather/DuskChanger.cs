using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DuskChanger : MonoBehaviour
{
    [SerializeField] Gradient directLight;
    [SerializeField] Gradient ambLight;

    const float timeDayInSeconds = 60f;

    [SerializeField, Range(0f, 1f)] float timeProgress;

    [SerializeField] Light lightSource;

    Vector3 defaultAngles;
    // Start is called before the first frame update
    void Start()
    {
        defaultAngles = lightSource.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isPlaying) timeProgress += Time.deltaTime / timeDayInSeconds;

        if (timeProgress > 1f) timeProgress = 0f;

        lightSource.color = directLight.Evaluate(timeProgress);
        RenderSettings.ambientLight = ambLight.Evaluate(timeProgress);

        lightSource.transform.localEulerAngles = new Vector3(360f * timeProgress - 60, defaultAngles.x, defaultAngles.z);
    }
}
