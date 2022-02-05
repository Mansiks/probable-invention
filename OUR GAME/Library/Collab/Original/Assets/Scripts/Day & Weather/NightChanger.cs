using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class NightChanger : MonoBehaviour
{
    [SerializeField] Gradient directLight;
    [SerializeField] Gradient ambLight;
    const float timeDayInSeconds = 60f;
    public bool isEvening = false;
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
        if (timeProgress > 0.5f && timeProgress < 1f)
        {
            isEvening = true;
        }
        else isEvening = false;
        lightSource.transform.localEulerAngles = new Vector3(360f * timeProgress - 150, defaultAngles.x, defaultAngles.z);
    }
}
