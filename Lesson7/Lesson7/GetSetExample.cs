using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    class GetSetExample
    {

        //Good example -- use this.
        private int _isProtected;
        public int isProtected 
        { 
            get 
            { return _isProtected; }
            set 
            { if (value > 0)
                {
                    _isProtected = value;
                }
            else
                {
                    throw new ArgumentException("Value must be greater than zero. These are the rules!");
                }
            } 
        }

        //Bad example -- don't do this.
        private int name;
        public int Name
        {
            get { return name; }
            set { name = value; }
        }
        //end of bad example

        public string readOnly { get; }
        public const string alwaysTheSame = "Never Changing Value";

        private string _objName;
        public string objName
        {
            get { return _objName; }
            set
            {
                if (objName.Length > 3)
                {
                    _objName = value;
                }
                else
                {
                    throw new ArgumentException("ObjName must be greater than 3 letters.. These are the rules!");
                }
            }
        }

        public string goodEncapsulation { get; private set; }



        public GetSetExample(string readOnly, string objName, int isProtected)
        {
            this.readOnly = readOnly;
            this._objName = objName;
            this._isProtected = isProtected;
        }

        public void ShowMeInternalName()
        {
            Console.WriteLine(_objName);
        }

    }
}
