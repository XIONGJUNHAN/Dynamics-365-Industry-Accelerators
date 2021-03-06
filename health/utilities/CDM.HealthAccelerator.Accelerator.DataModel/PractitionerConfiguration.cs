﻿// =====================================================================
//  This file is part of the Microsoft Dynamics Accelerator code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
// =====================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.HealthAccelerator.DataModel
{
    [Serializable]
    public class PractitionerConfiguration
    {
        public PractitionerConfiguration ()
        {
            Qualifications = 1;
            Roles = 1;
        }

        private int qualifications;

        private int roles;

        public int Qualifications
        {
            get
            {
                return qualifications;
            }

            set
            {
                qualifications = value;
            }
        }

        public int Roles
        {
            get
            {
                return roles;
            }

            set
            {
                roles = value;
            }
        }
    }
}
