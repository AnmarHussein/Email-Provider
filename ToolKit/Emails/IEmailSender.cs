﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit.Emails;
public interface IEmailSender
{
    Task SendAsync();
}
