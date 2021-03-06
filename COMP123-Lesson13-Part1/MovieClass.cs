﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson13_Part1
{
    //movie calss
    public class MovieClass: IComparable<MovieClass>
    {
        //private instance variables++++++++++++++++++++++++++++
        private string _title;
        private string _category;
        private double _cost;
        
        //public properties++++++++++++++++++++++++++++++++++++++
        public string Title 
        { 
            get 
            {
                return this._title; //read only
            } 
        }

        public string Category
        {
            get
            {
                return this._category; //read only
            }
        }

        public double Cost
        {
            get
            {
                return this._cost; //read only
            }
        } 
        //constructor+++++++++++++++++++++++++++++++++++++++++
        public MovieClass(string title,string category,double cost)
        { 
            //assign values to instance variables
            this._title = title;
            this._category = category;
            this._cost = cost;
        }

        // public method++++++++++++++++++
        //default comparer for movie type -- compares the title property
        public int CompareTo(MovieClass compareMovie)
        { 
            //a null value mens that this object is greater
            if (compareMovie==null)
            {
                return 1;
            }
            else
            {
                return this._title.CompareTo(compareMovie._title);
            }
        }
    }
}
