using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testmath : MonoBehaviour
{
    public float hp;
    public Slider LerpSlider;
    public Slider moveTowards;
    public Slider PingPong;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LerpSlider.value = Mathf.Lerp(LerpSlider.value,LerpSlider.maxValue, Speed * Time.deltaTime);
        moveTowards.value = Mathf.MoveTowards(moveTowards.value, moveTowards.maxValue, Speed * Time.deltaTime);
        PingPong.value   = Mathf.PingPong(Speed * Time.time, PingPong.maxValue);
    }

    private void OnValidate()
    {
        float absolute = Mathf.Abs(-8.5f);
        Debug.Log(absolute);
        
        float roundToINt = Mathf.RoundToInt(8.5f);
        Debug.Log(roundToINt);

        float CeilToInt = Mathf.CeilToInt(8.5f);
        Debug.Log("Ceil To Int:" + CeilToInt);
        
        float FloorToInt = Mathf.FloorToInt(8.5f);
        Debug.Log("Floor To Int:" + FloorToInt);
        
        float Pow = Mathf.Pow(8,2f);
        Debug.Log("Pow:" + Pow);

        float SQRT = Mathf.Sqrt(16);
        Debug.Log("SQRT:" +  SQRT);

        float Clamp = Mathf.Clamp(hp, 0, 100);
    }
}
