﻿// Anyone is free to copy, modify, use, compile, or distribute this software,
// either in source code form or as a compiled binary, for any non-commercial
// purpose.
//
// If modified, please retain this copyright header, and consider telling us
// about your changes.  We're always glad to see how people use our code!
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND.
// We do not accept any liability for damage caused by executing
// or modifying this code.

using System;
using Speculator.Core;

namespace Speculator.ViewModels;

public class MainWindowViewModel : ViewModelBase, IDisposable
{
    private readonly ZxSpectrum m_speccy;
    public ZXDisplay Display { get; } = new ZXDisplay();

    public MainWindowViewModel()
    {
        m_speccy =
            new ZxSpectrum(Display)
            .LoadBasicRom()
            .PowerOnAsync()
            ;
    }
    
    public void Dispose() => m_speccy.Dispose();
}