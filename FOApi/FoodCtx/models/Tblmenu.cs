﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FOApi
{
    public partial class Tblmenu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public double Price { get; set; }
        public int MenuTypeId { get; set; }
        public string MenuImage { get; set; }
        public string Ingredients { get; set; }
        public int? MenuStatus { get; set; }

        public virtual Tblmenutype MenuType { get; set; }
    }
}