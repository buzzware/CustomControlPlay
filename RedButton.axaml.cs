using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CustomControlPlay;

public partial class RedButton : Button
{
    
    protected override Type StyleKeyOverride => typeof(Button); // this is the fix
    
    public RedButton()
    {
        InitializeComponent();
    }
}
