﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICommand
{
    void Excute(INotifier inotifier);
}

