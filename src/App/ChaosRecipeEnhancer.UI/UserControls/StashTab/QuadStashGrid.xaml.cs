﻿using ChaosRecipeEnhancer.UI.Utilities;
using System.Windows.Controls;

namespace ChaosRecipeEnhancer.UI.UserControls.StashTab;

public partial class QuadStashGrid
{
    public QuadStashGrid()
    {
        InitializeComponent();
    }

    public Button GetButtonFromCell(object cell)
    {
        for (var i = 0; i < Items.Count; i++)
        {
            if (Items[i] == cell)
            {
                var container = ItemContainerGenerator.ContainerFromIndex(i);
                return ControlHelpers.GetChild<Button>(container);
            }
        }

        return null;
    }
}