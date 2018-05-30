﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Dock.Model
{
    public interface IDockManager
    {
        DockPoint Position { get; set; }
        DockPoint ScreenPosition { get; set; }
        bool Validate(IDock sourceDock, IDock targetDock, DragAction action, DockOperation operation, bool bExecute);
    }
}