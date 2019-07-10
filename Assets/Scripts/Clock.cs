using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
   public Transform hoursTransform;
   public Transform minutesTransform;
   public Transform secondsTransform;
   public bool continuous;

   private const float DEGREES_PER_HOUR = 30f;
   private const float DEGREES_PER_MINUTE = 6f;
   private const float DEGREES_PER_SECOND = 6f;

   void Awake()
   {
      //Shows a message in the bottom Unity toolbar
      //Debug.Log("Hello, World!");
   }

   // Start is called before the first frame update
   void Start()
   {

   }

   void Update()
   {
      if(continuous == true)
      {
         UpdateContinuous();
      }
      else
      {
         UpdateDiscrete();
      }
   }

   void UpdateContinuous()
   {
      //set clock rotations
      TimeSpan time = DateTime.Now.TimeOfDay;
      hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * DEGREES_PER_HOUR, 0f);
      minutesTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * DEGREES_PER_MINUTE, 0f);
      secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * DEGREES_PER_SECOND, 0f);
   }

   void UpdateDiscrete()
   {
      //set clock rotations
      DateTime now = DateTime.Now;
      hoursTransform.localRotation = Quaternion.Euler(0f, now.Hour * DEGREES_PER_HOUR, 0f);
      minutesTransform.localRotation = Quaternion.Euler(0f, now.Minute * DEGREES_PER_MINUTE, 0f);
      secondsTransform.localRotation = Quaternion.Euler(0f, now.Second * DEGREES_PER_SECOND, 0f);
   }
}
