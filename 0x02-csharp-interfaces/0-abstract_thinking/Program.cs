using System;

///<summary> Base class</summary>
abstract class Base
{
    ///<summary> public property</summary>
    public string name;

    ///<summary>method that overrides ToString</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType()}";
    }

}