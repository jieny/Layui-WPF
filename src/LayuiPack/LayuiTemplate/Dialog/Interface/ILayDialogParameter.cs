﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayuiTemplate.Dialog.Interface
{
    public interface ILayDialogParameter
    {
        /// <summary>
        /// 添加参数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Add(string key, object value);
    }
}