using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class NightCollider : MonoBehaviour
{
    public NightChanger nightChanger;
    public PostProcessVolume volume;
    public const float TO_NIGHT_GRADIENT_START = 0.25f;
    public const float TO_NIGHT_GRADIENT_END = 0.5f;
    public const float TO_DAY_GRADIENT_START = 0.8f;
    public const float NIGHT_GRADIENT_DURATION = TO_NIGHT_GRADIENT_END - TO_NIGHT_GRADIENT_START;
    public const float DAY_GRADIENT_DURATION = 1 - TO_DAY_GRADIENT_START;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (nightChanger.timeProgress < TO_NIGHT_GRADIENT_START)
        {
            volume.weight = 0f;
        }
        else if (nightChanger.timeProgress >= TO_NIGHT_GRADIENT_START && nightChanger.timeProgress < TO_NIGHT_GRADIENT_END)
        {
            volume.weight = (nightChanger.timeProgress - TO_NIGHT_GRADIENT_START) * (1 / NIGHT_GRADIENT_DURATION);
        }
        else if (nightChanger.timeProgress >= TO_NIGHT_GRADIENT_END && nightChanger.timeProgress < TO_DAY_GRADIENT_START)
        {
            volume.weight = 1f;
        }
        else
        {
            volume.weight = 1 - (nightChanger.timeProgress - TO_DAY_GRADIENT_START) * (1 / DAY_GRADIENT_DURATION);
        }
    }
}
