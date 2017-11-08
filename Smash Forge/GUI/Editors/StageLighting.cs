﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace Smash_Forge.GUI.Editors
{
    public partial class StageLighting : Form
    {
        public StageLighting()
        {
            InitializeComponent();
            for (int i = 0; i < VBNViewport.stageDiffuseLightSet.Length; i++)
            {
                lightSetLightListBox.Items.Add(VBNViewport.stageDiffuseLightSet[i].name);
            }
         
        }

        private void openLightSetButton_Click(object sender, EventArgs e)
        {

        }

        private void charLightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
