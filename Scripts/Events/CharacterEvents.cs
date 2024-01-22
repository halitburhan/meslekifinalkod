using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;



public class CharacterEvents
    {
    //karakter hasar aldı ve değeri
    public static UnityAction<GameObject, int> characterDamaged;
    //karakter iyileşti ve değeri
    public static UnityAction<GameObject, int> characterHealed;

}

