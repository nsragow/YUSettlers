using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContainsImage
{
    //returns a string representation of a path to the image file associated with the object
    string imagePath { get; }
}
