﻿using BindingEnums.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BindingEnums
{
    [TypeConverter(typeof(EnumDisplayTypeConverter))]
    public enum Status
    {
        [Display(ResourceType = typeof(EnumResource), Name = nameof(EnumResource.Horrible))]
        Horrible,
        [Display(ResourceType = typeof(EnumResource), Name = nameof(EnumResource.Bad))]
        Bad,
        [Display(ResourceType = typeof(EnumResource), Name = nameof(EnumResource.SoSo))]
        SoSo,
        [Display(ResourceType = typeof(EnumResource), Name = nameof(EnumResource.Good))]
        Good,
        [Display(ResourceType = typeof(EnumResource), Name = nameof(EnumResource.Better))]
        Better,
        [Display(ResourceType = typeof(EnumResource), Name = nameof(EnumResource.Best))]
        Best,
    }
}
