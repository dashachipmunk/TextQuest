﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{
    [TextArea(10,50)]
    public string content;
    public string location;

    public Steps nextStep1;
    public Steps nextStep2;


}