// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Class:  SafeFileHandle 
**
**
** A wrapper for file handles
**
** 
===========================================================*/

using System;
using System.Security;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Versioning;
using Microsoft.Win32;

namespace Microsoft.Win32.SafeHandles {

    [System.Security.SecurityCritical]  // auto-generated_required
    public sealed class SafeFileHandle: SafeHandleZeroOrMinusOneIsInvalid {

        private SafeFileHandle() : base(true) 
        {
        }

        public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle) {
            SetHandle(preexistingHandle);
        }

        [System.Security.SecurityCritical]
        [ResourceExposure(ResourceScope.Machine)]
        [ResourceConsumption(ResourceScope.Machine)]
        override protected bool ReleaseHandle()
        {
            return Win32Native.CloseHandle(handle);
        }
    }
}

