﻿using System.Windows.Forms;
using Dev2.Studio.Core.Interfaces;

namespace Dev2.Dialogs
{
    public interface IResourcePickerDialog
    {
        IResourceModel SelectedResource { get; set; }
        DialogResult ShowDialog();
    }
}