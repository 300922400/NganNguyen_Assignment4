using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Ngan Nguyen - ID:300922400
 * Date: July 25, 2017
 * Description: This is the abstract class Planet which other subclasses will
 * derive from.
 * Version: 0.1 - Create The Abstract Class Planet
 */

namespace NganNguyen_Assignment4
{
    /// <summary>
    /// This is the abstract class planet
    /// </summary>
    public abstract class Planet
    {
        // PRIVATE FIELDS (INSTANCE VARIABLES)
         private double _diameter;
         private double _mass;
         private int _moonCount;
         private string _name;
         private double _orbitalPeriod;
         private int _ringCount;
         private double _rotationPeriod;
         
        // PUBLIC PROPERTIES -----------------------------------------
         public double Diameter
         {
             get
             {
                 return this._diameter;
             }
         }
          public double Mass
         {
             get
             {
                 return  this._mass;
             }
         }
         public int MoonCount
         {
             get
             {
                 return this._moonCount;
             }
             set 
             {
                 this._moonCount = value;
             }
         }
         public string Name
         {
             get
             {
                 return this._name;
             }
         }
         public double OrbitalPeriod
         {
             get
             {
                 return this._orbitalPeriod;
             }
             set
             {
                 this._orbitalPeriod = value;
             }
         }
         public int RingCount
         {
             get
             {
                 return this._ringCount;
             }
             set
             {
                 this._ringCount = value;
             }
         }
         public double RotationPeriod
         {
             get
             {
                 return this._rotationPeriod;
             }
             set
             {
                 this._rotationPeriod = value;
             }
         }

        // CONSTRUCTORS -----------------------------------------------
         /// <summary>
         /// This is the constructor for the abstract class Planet
         /// it requires three parameter - name(string),diameter(double),mass(double)
         /// </summary>
         /// <param name="name"></param>
         /// <param name="diameter"></param>
         /// <param name="mass"></param>
         public Planet(string name,double diameter,double mass)
         {
             this._name = name;
             this._diameter = diameter;
             this._mass = mass;
         }
        // PUBLIC ABSTRACT METHODS
         public override string ToString()
         {
             return string.Format("Name:{0},Diameter:{1},Mass:{2}",Name,Diameter,Mass);
         }
    }
}
