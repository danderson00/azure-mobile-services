﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.TestFramework;

namespace Microsoft.WindowsAzure.MobileServices.Test
{
    /// <summary>
    /// Helper assert functions
    /// </summary>
    public static class AssertEx
    {
        public static async Task<TException> Throws<TException>(Func<Task> action) where TException: Exception
        {
            TException thrown = null;
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                thrown = ex as TException;
            }

            Assert.IsNotNull(thrown, "Expected exception not thrown");

            return thrown;
        }
    }
}