using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class clsCalculator
    {
        public enum enOreration :Byte
        {
            _Null,_Add ,_Minus,_Multy,_Divide,Breakage,_Sqr ,_Pow,_Mod
        }

        private float _Num1;
        private float _Num2;
        private enOreration _Operation;

        public float Num1 
        { 
            get 
            { 
                return _Num1; 
            }
            set
            {
                _Num1 = value; 
            } 
        }

        public float Num2
        {
            get
            {
                return _Num2;
            }
            set 
            { 
            _Num2 = value;
            }
        }

        public enOreration Operation
        {
            get 
            { 
            return _Operation;
            }
            set 
            { 
                _Operation = value; 
            }
        }

        private float Do_Operation()
        {
            switch(_Operation) 
            {
                case enOreration._Add:
                    return Add();  
                case enOreration._Minus:
                    return Minus();
                case enOreration._Multy:
                    return Multy();
                case enOreration._Divide:
                    return Divide();
                case enOreration.Breakage:
                    return Divide();
                case enOreration._Pow:
                    return Pow();
                case enOreration._Sqr:
                    return Square();
                case enOreration._Mod:
                    return Mod();
                default:
                    return 0;
            }
        }


        public string Get_Sign()
        {
            switch (_Operation)
            {
                case clsCalculator.enOreration._Add:
                    return "+";
                case clsCalculator.enOreration._Minus:
                    return "-";
                case clsCalculator.enOreration._Multy:
                    return "*";
                case clsCalculator.enOreration._Divide:
                    return "/";
                case enOreration.Breakage:
                    return "/";
                case enOreration._Pow:
                    return "^";
                case enOreration._Sqr:
                    return "|/-";
                case enOreration._Mod:
                    return "%";
                default:
                    return "+";
            }
        }

        private float Add()
        {
            return _Num1 + _Num2;
        }

        private float Minus()
        {
            return _Num1-_Num2;
        }

        private float Multy()
        {
            return _Num1*_Num2;

        }

        private float Divide()
        {
            if(_Num2 > 0) 
            {
                return _Num1 / _Num2;
            }
            return -1;
        }

        private float Square()
        {
            return (float)Math.Sqrt(_Num2);
        }

        private float Pow() 
        {
            return (float)Math.Pow(_Num1,_Num2);
        }

        private float Mod()
        {
            return _Num1/_Num2;
        }
        public float Result()
        {
            return Do_Operation();
        }

        public string StrResult()
        {
            return _Num1 + Get_Sign() + _Num2 + "=";
        }

        public void Clear()
        {
            _Num1 = 0;
            _Num2 = 0;
            _Operation = enOreration._Null;
        }
    }
}
