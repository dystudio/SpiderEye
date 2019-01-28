﻿using System;
using System.Collections.Generic;

namespace SpiderEye.UI.Mac.Dialogs
{
    internal class CocoaSaveFileDialog : ISaveFileDialog
    {
        public string Title { get; set; }
        public string InitialDirectory { get; set; }
        public string FileName { get; set; }
        public bool OverwritePrompt { get; set; }
        public ICollection<FileFilter> FileFilters { get; }

        public DialogResult Show()
        {
            throw new NotImplementedException();
        }

        public DialogResult Show(IWindow parent)
        {
            throw new NotImplementedException();
        }
    }
}