﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace ShaderTools.CodeAnalysis.Editor.Implementation.IntelliSense.QuickInfo
{
    internal partial class Controller
    {
        internal override void OnTextViewBufferPostChanged(object sender, EventArgs args)
        {
            // Any time the caret moves or text changes, we stop what we're doing.
            AssertIsForeground();
            DismissSessionIfActive();
        }
    }
}