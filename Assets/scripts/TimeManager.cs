using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTimeFloored;
    public Text txtCountdown;
    int counter;
    public float timeToChange;
    public float waitTime;

    float tiempo = 0;
    float countertiempo = -6;

    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
        txtCountdown.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        countertiempo = Time.time;
        

        if (Time.time -6  >= 0)
        { 
            txtTimeFloored.text = Mathf.FloorToInt(countertiempo - 6).ToString();
        }
          

        //Redondear el tiempo para obtener solo la parte entera
        if (Time.time >= tiempo + 6)
        {
           // txtTimeFloored.text = Mathf.FloorToInt(Time.time - 6).ToString();
           
        }
        //Cuenta regresiva a partir de cierto tiempo cada cierta cantidad de tiempo
        if (timeToChange < Time.time)
        {
            counter--;
           
           
                if (counter > 0)
                {
                    txtCountdown.text = counter.ToString();
                    timeToChange += waitTime;
                }
                else
                {
                    txtCountdown.text = "Go!";
                }
            
            if (counter <= -7)
            {
                Destroy(txtCountdown);
            }

        }
    }
}
