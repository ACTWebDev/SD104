using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    class WithEncap
    {
        public int notProtected;  //not protected by Encapsulation
        private int isProtected; // is protected from other classes 

        public WithEncap()
        {
            notProtected = 1;
            isProtected = 1;
        }

        public void UpdatePrivateProperty(int newValue)  //if you want to change my protected value, you must use this.
        {
            if (newValue < 0) {
                isProtected = newValue;
            }

            //I won't let you set it to a negative number.
        }



    }




}
