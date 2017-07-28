using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Ngan Nguyen - ID: 300922400
 * Date: July 27, 2017
 * Description: This is IHasMoon Interface define the HasMoon method that must be 
 * implemented in any class subscribes it 
 * Version: 0.1 - create the IHasMoon Interface
 */
namespace NganNguyen_Assignment4
{
    public interface IHasMoons
    {
        /// <summary>
        /// creat the single method HasMoon returns a bool data type
        /// </summary>
        /// <returns></returns>
        bool HasMoons();
    }
}