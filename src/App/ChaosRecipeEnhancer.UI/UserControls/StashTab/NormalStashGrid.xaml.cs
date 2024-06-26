﻿using ChaosRecipeEnhancer.UI.Utilities;
using System.Windows.Controls;

namespace ChaosRecipeEnhancer.UI.UserControls.StashTab;

public partial class NormalStashGrid
{
    public NormalStashGrid()
    {
        InitializeComponent();
    }

    public Button GetButtonFromCell(object cell)
    {
        for (var i = 0; i < Items.Count; i++)
            if (Items[i] == cell)
            {
                var container = ItemContainerGenerator.ContainerFromIndex(i);
                var t = ControlHelpers.GetChild<Button>(container);
                return t;
            }

        return null;
    }
}