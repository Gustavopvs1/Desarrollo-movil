﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinPong.Core
{
    public interface ICommand
    {
        void Execute(object? parameter);

        bool CanExecute(object? parameter);
    }
}